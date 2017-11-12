using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarTransform
    {
        public AvatarVector3f Position;
        public AvatarQuatf Orientation;
        public AvatarVector3f Scale;
    }
}
