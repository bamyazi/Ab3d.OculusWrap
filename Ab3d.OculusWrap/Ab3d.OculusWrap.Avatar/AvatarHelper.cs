using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    //TODO: Make the extension methods on the classes ??
    public static class AvatarHelper
    {
        public static AvatarTransform AvatarTransformFromPosef(Posef pose)
        {
            return new AvatarTransform()
            {
                Position = AvatarVector3fFromVector3f(pose.Position),
                Orientation = AvatarQuatfFromQuaternionf(pose.Orientation),                
            };
        }

        public static AvatarVector3f AvatarVector3fFromVector3f(Vector3f vector3f)
        {
            return new AvatarVector3f()
            {
                X = vector3f.X,
                Y = vector3f.Y,
                Z = vector3f.Z,
            };
        }

        public static AvatarQuatf AvatarQuatfFromQuaternionf(Quaternionf quaternionf)
        {
            return new AvatarQuatf()
            {
                X = quaternionf.X,
                Y = quaternionf.Y,
                Z = quaternionf.Z,
                W = quaternionf.W
            };
        }
    }
}
