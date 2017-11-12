using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ab3d.OculusWrap.Avatar.Temp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarPacket
    {
        internal IntPtr nativePointer;

        internal AvatarPacket(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}
