using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [Flags]
    public enum AvatarButton
    {
        AvatarButton_One = 0x0001,
        AvatarButton_Two = 0x0002,
        AvatarButton_Three = 0x0004,
        AvatarButton_Joystick = 0x0008
    }
}
