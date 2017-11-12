using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar.Temp
{
    [Flags]
    public enum AvatarVisibilityFlags
    {
        AvatarVisibilityFlag_FirstPerson = 0x0001,
        AvatarVisibilityFlag_ThirdPerson = 0x0002,
        AvatarVisibilityFlag_SelfOccluding = 0x0004
    }
}
