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
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    //TODO: Make the extension methods on the classes ??
    /// <summary>
    /// 
    /// </summary>
    public static class AvatarHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pose">The pose.</param>
        /// <returns></returns>
        public static AvatarTransform AvatarTransformFromPosef(Posef pose)
        {
            return new AvatarTransform()
            {
                Position = AvatarVector3fFromVector3f(pose.Position),
                Orientation = AvatarQuatfFromQuaternionf(pose.Orientation),                
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector3f">The vector3f.</param>
        /// <returns></returns>
        public static AvatarVector3f AvatarVector3fFromVector3f(Vector3f vector3f)
        {
            return new AvatarVector3f()
            {
                X = vector3f.X,
                Y = vector3f.Y,
                Z = vector3f.Z,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quaternionf">The quaternionf.</param>
        /// <returns></returns>
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
