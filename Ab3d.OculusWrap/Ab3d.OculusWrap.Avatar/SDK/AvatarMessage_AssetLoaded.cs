using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMessage_AssetLoaded
    {
        public UInt64 AssetID;
        public IntPtr asset;

        public AvatarAsset Asset
        {
            get { return new AvatarAsset(asset); }
        }
    }
}
