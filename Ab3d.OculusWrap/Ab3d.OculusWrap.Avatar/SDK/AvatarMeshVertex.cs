using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMeshVertex
    {
        public float X;
        public float Y;
        public float Z;
        public float NX;
        public float NY;
        public float NZ;
        public float TX;
        public float TY;
        public float TZ;
        public float TW;
        public float U;
        public float V;

        // Commented to allow using GCHandle.Alloc on array of AvatarMeshVertex (to make this struct blitable)
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //public byte[] blendIndices;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //public float[] blendWeights;

        public byte BlendIndice0;
        public byte BlendIndice1;
        public byte BlendIndice2;
        public byte BlendIndice3;

        public float BlendWeight0;
        public float BlendWeight1;
        public float BlendWeight2;
        public float BlendWeight3;
    }
}
