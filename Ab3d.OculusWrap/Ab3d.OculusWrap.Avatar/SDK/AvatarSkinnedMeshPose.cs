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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Avatar
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AvatarSkinnedMeshPose
    {
        public UInt32 JointCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public AvatarTransform[] JointTransform;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public Int32[] JointParents;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] JointNamePtrs;

        /// <summary>
        /// Gets the joint names.
        /// </summary>
        /// <returns></returns>
        public string[] GetJointNames()
        {
            var jointNames = new string[JointCount];

            for (int i = 0; i < JointCount; i++)
            {
                var jointNamePtr = JointNamePtrs[i];

                string jointName;

                if (jointNamePtr != IntPtr.Zero)
                    jointName = Marshal.PtrToStringAnsi(jointNamePtr);
                else
                    jointName = null;

                jointNames[i] = jointName;
            }

            return jointNames;
        }
    }
}
