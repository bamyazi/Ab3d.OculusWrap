using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMessage
    {     
        internal IntPtr nativePointer;

        public bool Empty
        {
            get { return nativePointer == IntPtr.Zero; }
        }

        internal AvatarMessage(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}
