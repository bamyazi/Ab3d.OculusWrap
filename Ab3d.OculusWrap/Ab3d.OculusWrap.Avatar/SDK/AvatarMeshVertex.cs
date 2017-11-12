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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] blendIndices;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] blendWeights;
    }
}
