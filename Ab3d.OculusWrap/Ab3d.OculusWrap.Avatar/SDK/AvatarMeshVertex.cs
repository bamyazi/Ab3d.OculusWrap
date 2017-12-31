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
    public struct AvatarMeshVertex
    {
        public float X;
        public float Y;
        public float Z;
        public float NX;
        public float NY;
        public float NZ;
        public float TX;
        public float TY;
        public float TZ;
        public float TW;
        public float U;
        public float V;

        // Commented to allow using GCHandle.Alloc on array of AvatarMeshVertex (to make this struct blitable)
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //public byte[] blendIndices;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //public float[] blendWeights;

        public byte BlendIndice0;
        public byte BlendIndice1;
        public byte BlendIndice2;
        public byte BlendIndice3;

        public float BlendWeight0;
        public float BlendWeight1;
        public float BlendWeight2;
        public float BlendWeight3;
    }
}
