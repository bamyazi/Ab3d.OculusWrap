using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        // THIS IS UGLY - NOT FIGURED OUT HOW TO DO IT BETTER YET, AND IT WORKS FOR TESTING
        public AvatarMeshVertex[] GetVertexData()
        {
            var vertexData = new AvatarMeshVertex[VertexCount];
            var size = Marshal.SizeOf(typeof(AvatarMeshVertex));
            var startPtr = VertexBuffer.ToInt64();
            for(int i=0;i<VertexCount;i++)
            {
                vertexData[i] = (AvatarMeshVertex) Marshal.PtrToStructure(new IntPtr(startPtr + (i * size)), typeof(AvatarMeshVertex));
            }
            return vertexData;
        }

        // THIS IS UGLY - NOT FIGURED OUT HOW TO DO IT BETTER YET, AND IT WORKS FOR TESTING
        public UInt16[] GetIndexData()
        {
            var indexData = new UInt16[IndexCount];
            var size = Marshal.SizeOf(typeof(UInt16));
            var startPtr = IndexBuffer.ToInt64();
            for (int i = 0; i < IndexCount; i++)
            {
                indexData[i] = (UInt16)Marshal.PtrToStructure(new IntPtr(startPtr + (i * size)), typeof(UInt16));
            }
            return indexData;
        }
    }
}
