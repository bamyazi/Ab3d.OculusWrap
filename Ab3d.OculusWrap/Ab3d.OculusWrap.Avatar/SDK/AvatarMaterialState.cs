// Copyright (c) 2017 BamYazi / AB4D d.o.o.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
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
