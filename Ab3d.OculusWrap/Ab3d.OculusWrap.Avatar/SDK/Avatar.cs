using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Avatar
    {      
        internal IntPtr nativePointer;

        internal Avatar(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}
