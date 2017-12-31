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
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMeshAssetData
    {
        public UInt32 VertexCount;
        public IntPtr VertexBuffer;
        public UInt32 IndexCount;
        public IntPtr IndexBuffer;

        [MarshalAs(UnmanagedType.Struct)]
        public AvatarSkinnedMeshPose SkinnedBindPose;

        /// <summary>
        /// Gets the vertex data.
        /// </summary>
        /// <returns></returns>
        public AvatarMeshVertex[] GetVertexData()
        {
            var managedVertexBuffer = new AvatarMeshVertex[VertexCount];
            int size = Marshal.SizeOf(typeof(AvatarMeshVertex));

            var gcHandle = GCHandle.Alloc(managedVertexBuffer, GCHandleType.Pinned);

            try
            {
                SafeNativeMethods.CopyMemory(dest: gcHandle.AddrOfPinnedObject(), src: VertexBuffer, count: size * (int)VertexCount);
            }
            finally
            {
                gcHandle.Free();
            }

            return managedVertexBuffer;
        }

        /// <summary>
        /// Gets the index data.
        /// </summary>
        /// <returns></returns>
        public UInt16[] GetIndexData()
        {
            var managedIndexBuffer = new UInt16[IndexCount];
            int size = Marshal.SizeOf(typeof(UInt16));

            var gcHandle = GCHandle.Alloc(managedIndexBuffer, GCHandleType.Pinned);

            try
            {
                SafeNativeMethods.CopyMemory(dest: gcHandle.AddrOfPinnedObject(), src: IndexBuffer, count: size * (int)IndexCount);
            }
            finally
            {
                gcHandle.Free();
            }

            return managedIndexBuffer;
        }

        static class SafeNativeMethods
        {
            [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
            public static extern void CopyMemory(IntPtr dest, IntPtr src, int count);
        }
    }
}
