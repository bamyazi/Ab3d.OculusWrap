using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarRenderPart_SkinnedMeshRenderPBS
    {
        public AvatarTransform LocalTransform;
        public UInt32 VisibilityMask;
        public UInt64 MeshAssetID;
        public UInt64 AlbedoTextureAssetID;
        public UInt64 SurfaceTextureAssetID;
        public AvatarSkinnedMeshPose SkinnedPose;
    }
}
