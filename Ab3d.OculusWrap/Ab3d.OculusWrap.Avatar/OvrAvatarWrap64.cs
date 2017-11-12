using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    public sealed partial class OvrAvatarWrap64 : OvrAvatarWrap
    {
        internal const string _ovrPlatformDllName = "LibOVRAvatar.dll";

        public override string OvrPlatformDllName { get { return _ovrPlatformDllName; } }
    }
}
