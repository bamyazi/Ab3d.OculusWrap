﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AvatarSkinnedMeshPose
    {
        public UInt32 JointCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public AvatarTransform[] JointTransforms; 
        
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public Int32[] JointParents;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        internal IntPtr[] jointNames;
    }
}
