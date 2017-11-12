using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Platform
{
    public partial class OvrPlatformWrap64
    {
        public override void InitializeWindows(string appID)
        {
            SafeNativeMethods.ovr_PlatformInitializeWindows(appID);
        }

        public override bool IsPlatformInitialized()
        {
            return SafeNativeMethods.ovr_IsPlatforminitialized();
        }

        public override UInt64 GetLoggedInUserID()
        {
            return SafeNativeMethods.ovr_GetLoggedInUserID();
        }
    }
}
