using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarBaseComponent
    {
        public AvatarVector3f BasePosition;
        private IntPtr renderComponent;

        public AvatarComponent RenderComponent => 
            (AvatarComponent) Marshal.PtrToStructure(renderComponent, typeof(AvatarComponent));
    }
}
