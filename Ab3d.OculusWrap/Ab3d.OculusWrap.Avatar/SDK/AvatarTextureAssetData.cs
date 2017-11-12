using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    public struct AvatarTextureAssetData
    {
        public AvatarTextureFormat Format;
        public UInt32 SizeX;
        public UInt32 SizeY;
        public UInt32 MipCount;
        public UInt64 TextureDataSize;
        public IntPtr TextureData;
    }
}
