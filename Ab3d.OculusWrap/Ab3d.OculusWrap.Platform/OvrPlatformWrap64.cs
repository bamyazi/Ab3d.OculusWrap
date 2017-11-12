using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Platform
{
    public partial class OvrPlatformWrap64 : OvrPlatformWrap
    {
        internal const string _ovrPlatformDllName = "LibOVRPlatform64_1.dll";
        public override string OvrPlatformDllName { get { return _ovrPlatformDllName; } }
    }
}
