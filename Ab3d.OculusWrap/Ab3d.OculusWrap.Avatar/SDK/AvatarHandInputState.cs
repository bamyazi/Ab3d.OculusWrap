using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarHandInputState
    {
        public AvatarTransform Transform;
        public UInt32 ButtonMask;
        public UInt32 TouchMask;
        public float JoystickX;
        public float JoystickY;
        public float IndexTrigger;
        public float HandTrigger;
        public bool IsActive;
    }
}
