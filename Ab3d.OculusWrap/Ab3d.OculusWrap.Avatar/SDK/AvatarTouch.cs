using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [Flags]
    public enum AvatarTouch
    {
        AvatarTouch_One = 0x0001,
        AvatarTouch_Two = 0x0002,
        AvatarTouch_Joystrick = 0x0004,
        AvatarTouch_ThumbRest = 0x0008,
        AvatarTouch_Index = 0x0010,
        AvatarTouch_Pointing = 0x0040,
        AvatarTouch_ThumbUp = 0x0080,
    }
}
