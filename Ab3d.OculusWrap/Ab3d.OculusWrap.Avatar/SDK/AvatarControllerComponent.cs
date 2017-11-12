using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarControllerComponent
    {
        public AvatarHandInputState InputState;
        internal IntPtr renderComponent;

        public AvatarComponent RenderComponent =>
            (AvatarComponent) Marshal.PtrToStructure(renderComponent, typeof(AvatarComponent));
    }
}
