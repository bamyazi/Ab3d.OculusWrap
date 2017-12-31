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
    /// <summary>
    /// 
    /// </summary>
    public abstract class OvrAvatarWrap
    {
        public const int OVR_AVATAR_MAX_MATERIAL_LAYER_COUNT = 8;
        public const int OVR_AVATAR_MAXIMUM_JOINT_COUNT = 64;

        public abstract string OvrAvatarDllName { get; }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Avatar support is 64bit only</exception>
        public static OvrAvatarWrap Create()
        {
            if (Environment.Is64BitProcess)
                return new OvrAvatarWrap64();

            throw new Exception("Avatar support is 64bit only");
        }

        public abstract void Initialize(string appId);
        public abstract void RequestAvatarSpecification(UInt64 userId);

        #region AVATAR MESSAGE
        public abstract AvatarMessage AvatarMessage_Pop();
        public abstract AvatarMessageType AvatarMessage_GetType(AvatarMessage avatarMessage);
        public abstract void AvatarMessage_Free(AvatarMessage avatarMessage);
        public abstract AvatarMessage_AssetLoaded AvatarMessage_GetAssetLoaded(AvatarMessage avatarMessage);
        public abstract AvatarMessage_AvatarSpecification AvatarMessage_GetAvatarSpecification(AvatarMessage avatarMessage);
        #endregion

        #region AVATAR
        public abstract Avatar Avatar_Create(AvatarSpecification avatarSpecification, AvatarCapabilities avatarCapabilities);
        public abstract UInt32 Avatar_GetReferencedAssetCount(Avatar avatar);
        public abstract UInt64 Avatar_GetReferencedAsset(Avatar avatar, UInt32 index);
        public abstract void Avatar_SetLeftControllerVisibility(Avatar avatar, bool visibility);
        public abstract void Avatar_SetRightControllerVisibility(Avatar avatar, bool visibility);
        public abstract void Avatar_SetLeftHandGesture(Avatar avatar, AvatarHandGesture gesture);
        public abstract void Avatar_SetRightHandGesture(Avatar avatar, AvatarHandGesture gesture);
        public abstract void Avatar_SetActiveCapabilities(Avatar avatar, AvatarCapabilities capabilities);
        public abstract void Avatar_ClearCustomBasePosition(Avatar avatar);
        public abstract void Avatar_SetCustomBasePosition(Avatar avatar, AvatarVector3f position);
        public abstract void Avatar_Destroy(Avatar avatar);
        #endregion

        #region AVATAR ASSET
        public abstract void AvatarAsset_BeginLoading(UInt64 assedId);
        public abstract AvatarAssetType AvatarAsset_GetType(AvatarAsset avatarAsset);
        public abstract AvatarMeshAssetData AvatarAsset_GetMeshData(AvatarAsset avatarAsset);
        public abstract AvatarTextureAssetData AvatarAsset_GetTextureData(AvatarAsset avatarAsset);
        public abstract AvatarMaterialState AvatarAsset_GetMaterialData(AvatarAsset avatarAsset);
        #endregion

        #region AVATAR POSE
        public abstract AvatarBodyComponent AvatarPose_GetBodyComponent(Avatar avatar);
        public abstract AvatarBaseComponent AvatarPose_GetBaseComponent(Avatar avatar);
        public abstract AvatarControllerComponent AvatarPose_GetLeftControllerComponent(Avatar avatar);
        public abstract AvatarControllerComponent AvatarPose_GetRightControllerComponent(Avatar avatar);
        public abstract AvatarHandComponent AvatarPose_GetLeftHandComponennt(Avatar avatar);
        public abstract AvatarHandComponent AvatarPose_GetRightHandComponent(Avatar avatar);
        public abstract void AvatarPose_UpdateBody(Avatar avatar, AvatarTransform avatarTransform);
        public abstract void AvatarPose_UpdateHands(Avatar avatar, AvatarHandInputState inputStateLeft, AvatarHandInputState inputStateRight);
        public abstract void AvatarPose_Finalize(Avatar avatar, float deltaSeconds);
        #endregion

        #region AVATAR COMPONENT
        public abstract UInt32 AvatarComponent_Count(Avatar avatar);
        public abstract AvatarComponent AvatarComponent_Get(Avatar avatar, UInt32 index);
        #endregion

        #region AVATAR RENDER PART
        public abstract AvatarRenderPartType AvatarRenderPart_GetType(AvatarRenderPart avatarRenderPart);
        public abstract AvatarRenderPart_SkinnedMeshRender AvatarRenderPart_GetSkinnedMeshRender(AvatarRenderPart avatarRenderPart);
        public abstract AvatarRenderPart_SkinnedMeshRenderPBS AvatarRenderPart_GetSkinnedMeshRenderPBS(AvatarRenderPart avatarRenderPart);
        public abstract AvatarRenderPart_ProjectorRender AvatarRenderPart_GetProjectorRender(AvatarRenderPart avatarRenderPart);
        #endregion

        #region AVATAR SKINNED MESH RENDER
        public abstract AvatarTransform AvatarSkinnedMeshRender_GetTransform(AvatarRenderPart avatarRenderPart);
        public abstract AvatarTransform AvatarSkinnedMeshRenderPBS_GetTransform(AvatarRenderPart avatarRenderPart);
        public abstract UInt32 AvatarSkinnedMeshRender_GetVisibilityMask(AvatarRenderPart avatarRenderPart);
        public abstract UInt32 AvatarSkinnedMeshRenderPBS_GetVisibilityMask(AvatarRenderPart avatarRenderPart);
        public abstract bool AvatarSkinnedMeshRender_MaterialStateChanged(AvatarRenderPart avatarRenderPart);
        public abstract AvatarMaterialState AvatarSkinnedMeshRender_GetMaterialState(AvatarRenderPart avatarRenderPart);
        public abstract UInt64 AvatarSkinnedMeshRender_GetDirtyJoints(AvatarRenderPart avatarRenderPart);
        public abstract UInt64 AvatarSkinnedMeshRenderPBS_GetDirtyJoints(AvatarRenderPart avatarRenderPart);
        public abstract AvatarTransform AvatarSkinnedMeshRender_GetJointTransform(AvatarRenderPart avatarRenderPart, UInt32 jointIndex);
        public abstract AvatarTransform AvatarSkinnedMeshRenderPBS_GetJointTransform(AvatarRenderPart avatarRenderPart, UInt32 jointIndex);
        public abstract UInt64 AvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(AvatarRenderPart avatarRenderPart);
        public abstract UInt64 AvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(AvatarRenderPart avatarRenderPart);
        #endregion
    }
}
