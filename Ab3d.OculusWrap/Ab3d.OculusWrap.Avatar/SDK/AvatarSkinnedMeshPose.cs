using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarSkinnedMeshPose
    {
        public UInt32 JointCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public AvatarTransform[] JointTransform;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public int[] JointParents;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] JointNamePtrs;

        public string[] GetJointNames()
        {
            var jointNames = new string[JointCount];

            for (int i = 0; i < JointCount; i++)
            {
                var jointNamePtr = JointNamePtrs[i];

                string jointName;

                if (jointNamePtr != IntPtr.Zero)
                    jointName = Marshal.PtrToStringAnsi(jointNamePtr);
                else
                    jointName = null;

                jointNames[i] = jointName;
            }

            return jointNames;
        }
    }
}
