﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMaterialState
    {
        public AvatarVector4f BaseColor;
        public AvatarMaterialMaskType BaseMaskType;
        public AvatarVector4f BaseMaskParameters;
        public AvatarVector4f BaseMaskAxis;
        public UInt64 AlphaMaskTextureID;
        public AvatarVector4f AlphaMaskScaleOffset;
        public UInt64 NormalMapTextureID;
        public AvatarVector4f NormalMapScaleOffset;
        public UInt64 ParallaxMapTextureID;
        public AvatarVector4f ParallaxMapScaleOffset;
        public UInt64 RoughnessMapTextureID;
        public AvatarVector4f RoughnessMapScaleOffset;
        public UInt32 LayerCount;
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType=UnmanagedType.Struct, SizeConst=8)]
        public AvatarMaterialLayerState[] Layers;
    }
}
