﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarQuatf
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
    }
}
