using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMaterialLayerState
    {
        public AvatarMaterialLayerBlendMode BlendMode;
        public AvatarMaterialLayerSampleMode SampleMode;
        public AvatarMaterialMaskType MaskType;
        public AvatarVector4f LayerColor;
        public AvatarVector4f SampleParameters;
        public UInt64 SampleTexture;
        public AvatarVector4f SampleScaleOffset;
        public AvatarVector4f MaskParameters;
        public AvatarVector4f MaskAxis;
    }
}
