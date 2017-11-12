﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarAsset
    {
        internal IntPtr nativePointer;

        internal AvatarAsset(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}
