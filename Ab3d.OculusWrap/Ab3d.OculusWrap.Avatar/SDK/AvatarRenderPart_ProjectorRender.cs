using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarRenderPart_ProjectorRender
    {
        public AvatarTransform LocalTransform;
        public UInt32 ComponentIndex;
        public UInt32 RenderPartIndex;
        public AvatarMaterialState MaterialState;
    }
}
