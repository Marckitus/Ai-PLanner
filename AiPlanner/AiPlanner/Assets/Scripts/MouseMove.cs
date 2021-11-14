using UnityEngine;
using UnityEngine.AI;

public class MouseMove : MonoBehaviour {
	private NavMeshAgent agent;
    public Animator anim;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	void Update () {
        if (agent.velocity != Vector3.zero)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }

		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (camRay, out hit, 100)) {
				agent.destination = hit.point;
			}
		}
	}
}
