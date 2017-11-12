using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarMessage_AvatarSpecification
    {
        public IntPtr avatarSpecification;
        public UInt64 OculusUserID;

        public AvatarSpecification AvatarSpecification
        {
            get { return new AvatarSpecification(avatarSpecification); }
        }
    }
}
