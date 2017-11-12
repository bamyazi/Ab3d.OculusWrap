using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    [Flags]
    public enum AvatarCapabilities
    {
        AvatarCapability_Body = 0x0001,
        AvatarCapability_Hands = 0x0002,
        AvatarCapability_Base = 0x0004,
        AvatarCapability_Voice = 0x0008,
        AvatarCapability_BodyTilt = 0x0010,
        AvatarCapability_All = 0xFFFF
    }
}
