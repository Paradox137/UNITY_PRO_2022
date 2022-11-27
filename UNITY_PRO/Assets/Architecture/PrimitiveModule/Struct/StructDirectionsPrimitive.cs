using System;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Struct
{ 
    [Serializable]
    public struct StructDirectionsPrimitive
    {
        public Vector3 forward;
        public Vector3 back;
        public Vector3 left;
        public Vector3 right;
    }
}