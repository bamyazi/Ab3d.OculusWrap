using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
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
