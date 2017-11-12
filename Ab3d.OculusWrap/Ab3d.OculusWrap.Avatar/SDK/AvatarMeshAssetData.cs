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
        public AvatarSkinnedMeshPose SkinnedBindPose;

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
