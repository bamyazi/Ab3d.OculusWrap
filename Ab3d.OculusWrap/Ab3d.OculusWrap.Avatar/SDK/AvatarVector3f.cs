using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarVector3f
    {
        /// <summary>
        /// X
        /// </summary>
        public float X;

        /// <summary>
        /// Y
        /// </summary>
        public float Y;

        /// <summary>
        /// Z
        /// </summary>
        public float Z;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public AvatarVector3f(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
