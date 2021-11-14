using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Generated.Semantic.Traits;

public class PlannerCallback : MonoBehaviour
{
    public Moves moves;
    public UnityEngine.AI.NavMeshAgent agent;
    public Robber trt;
    public GameObject cop;
    public GameObject treasure;
    public Animator anim;

    public void Steal()
    {
        Debug.Log("Steal");
        treasure.GetComponent<Renderer>().enabled = false;
        anim.SetBool("walking", false);
    }

    public IEnumerator Seek()
    {
        Debug.Log("Approach");
        if (agent.velocity != Vector3.zero)
        {
            anim.SetBool("steel", true);
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
        agent.SetDestination(treasure.transform.position);
        while ((Vector3.Distance(treasure.transform.position, transform.position) > 2f) &&
               (Vector3.Distance(treasure.transform.position, cop.transform.position) > 10f))
            yield return null;
        if (Vector3.Distance(treasure.transform.position, cop.transform.position) < 10f)
        {
            trt.CopAway = false;
        }
        else
        {
            trt.Ready2Steal = true;
        }
    }

    public IEnumerator Wander()
    {
        Debug.Log("Wander");
        if (agent.velocity != Vector3.zero)
        {
            anim.SetBool("steel", false);
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
        while (Vector3.Distance(treasure.transform.position, cop.transform.position) < 10f)
        {
            moves.Wander();
            yield return null;
        }
    }
}
