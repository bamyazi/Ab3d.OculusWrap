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
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public struct AvatarComponent
    {
        public AvatarTransform Transform;
        public UInt32 RenderPartCount;      
        internal IntPtr renderParts;
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;

        // THIS IS UGLY - NOT FIGURED OUT HOW TO DO IT BETTER YET, AND IT WORKS FOR TESTING
        public AvatarRenderPart[] GetRenderParts()
        {
            var renderPartData = new AvatarRenderPart[RenderPartCount];
            var size = Marshal.SizeOf(typeof(IntPtr));
            var startPtr = renderParts.ToInt64();
            for(int i = 0; i < RenderPartCount; i++)
            {
                var ptr = (IntPtr)Marshal.PtrToStructure(new IntPtr(startPtr + (i * size)), typeof(IntPtr));
                renderPartData[i] = new AvatarRenderPart(ptr);
            }
            return renderPartData;
        }
    }
}
