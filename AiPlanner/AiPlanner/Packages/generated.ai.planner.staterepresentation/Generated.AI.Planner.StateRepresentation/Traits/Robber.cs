using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.AI.Planner.Traits;

namespace Generated.AI.Planner.StateRepresentation
{
    [Serializable]
    public struct Robber : ITrait, IBufferElementData, IEquatable<Robber>
    {
        public const string FieldCopAway = "CopAway";
        public const string FieldReady2Steal = "Ready2Steal";
        public const string FieldStolen = "Stolen";
        public System.Boolean CopAway;
        public System.Boolean Ready2Steal;
        public System.Boolean Stolen;

        public void SetField(string fieldName, object value)
        {
            switch (fieldName)
            {
                case nameof(CopAway):
                    CopAway = (System.Boolean)value;
                    break;
                case nameof(Ready2Steal):
                    Ready2Steal = (System.Boolean)value;
                    break;
                case nameof(Stolen):
                    Stolen = (System.Boolean)value;
                    break;
                default:
                    throw new ArgumentException($"Field \"{fieldName}\" does not exist on trait Robber.");
            }
        }

        public object GetField(string fieldName)
        {
            switch (fieldName)
            {
                case nameof(CopAway):
                    return CopAway;
                case nameof(Ready2Steal):
                    return Ready2Steal;
                case nameof(Stolen):
                    return Stolen;
                default:
                    throw new ArgumentException($"Field \"{fieldName}\" does not exist on trait Robber.");
            }
        }

        public bool Equals(Robber other)
        {
            return CopAway == other.CopAway && Ready2Steal == other.Ready2Steal && Stolen == other.Stolen;
        }

        public override string ToString()
        {
            return $"Robber\n  CopAway: {CopAway}\n  Ready2Steal: {Ready2Steal}\n  Stolen: {Stolen}";
        }
    }
}
