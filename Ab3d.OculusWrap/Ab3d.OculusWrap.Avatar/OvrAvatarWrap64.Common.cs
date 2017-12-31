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

namespace Ab3d.OculusWrap.Avatar
{
    public sealed partial class OvrAvatarWrap64
    {
        public override void Initialize(string appId)
        {
            SafeNativeMethods.ovrAvatar_Initialize(appId);
        }

        public override void RequestAvatarSpecification(UInt64 userId)
        {
            SafeNativeMethods.ovrAvatar_RequestAvatarSpecification(userId);
        }

        #region AVATAR
        public override Avatar Avatar_Create(AvatarSpecification avatarSpecification, AvatarCapabilities avatarCapabilities)
        {
            return new Avatar(SafeNativeMethods.ovrAvatar_Create(avatarSpecification.nativePointer, avatarCapabilities));
        }

        public override UInt32 Avatar_GetReferencedAssetCount(Avatar avatar)
        {
            return SafeNativeMethods.ovrAvatar_GetReferencedAssetCount(avatar.nativePointer);
        }

        public override UInt64 Avatar_GetReferencedAsset(Avatar avatar, UInt32 index)
        {
            return SafeNativeMethods.ovrAvatar_GetReferencedAsset(avatar.nativePointer, index);
        }

        public override void Avatar_SetLeftControllerVisibility(Avatar avatar, bool visibility)
        {
            SafeNativeMethods.ovrAvatar_SetLeftControllerVisibility(avatar.nativePointer, visibility);
        }

        public override void Avatar_SetLeftHandGesture(Avatar avatar, AvatarHandGesture gesture)
        {
            SafeNativeMethods.ovrAvatar_SetLeftHandGesture(avatar.nativePointer, gesture);
        }

        public override void Avatar_SetRightControllerVisibility(Avatar avatar, bool visibility)
        {
            SafeNativeMethods.ovrAvatar_SetRightControllerVisibility(avatar.nativePointer, visibility);
        }

        public override void Avatar_SetRightHandGesture(Avatar avatar, AvatarHandGesture gesture)
        {
            SafeNativeMethods.ovrAvatar_SetRightHandGesture(avatar.nativePointer, gesture);
        }

        public override void Avatar_SetActiveCapabilities(Avatar avatar, AvatarCapabilities capabilities)
        {
            SafeNativeMethods.ovrAvatar_SetActiveCapabilities(avatar.nativePointer, capabilities);
        }

        public override void Avatar_ClearCustomBasePosition(Avatar avatar)
        {
            SafeNativeMethods.ovrAvatar_ClearCustomBasePosition(avatar.nativePointer);
        }

        public override void Avatar_SetCustomBasePosition(Avatar avatar, AvatarVector3f position)
        {
            SafeNativeMethods.ovrAvatar_SetCustomBasePosition(avatar.nativePointer, position);
        }

        public override void Avatar_Destroy(Avatar avatar)
        {
            SafeNativeMethods.ovrAvatar_Destroy(avatar.nativePointer);
        }
        #endregion

        #region AVATAR MESSAGE
        public override AvatarMessage AvatarMessage_Pop()
        {
            return new AvatarMessage(SafeNativeMethods.ovrAvatarMessage_Pop());
        }

        public override AvatarMessageType AvatarMessage_GetType(AvatarMessage avatarMessage)
        {
            return SafeNativeMethods.ovrAvatarMessage_GetType(avatarMessage.nativePointer);
        }

        public override void AvatarMessage_Free(AvatarMessage avatarMessage)
        {
            SafeNativeMethods.ovrAvatarMessage_Free(avatarMessage.nativePointer);
        }

        public override AvatarMessage_AssetLoaded AvatarMessage_GetAssetLoaded(AvatarMessage avatarMessage)
        {
            return (AvatarMessage_AssetLoaded) Marshal.PtrToStructure(SafeNativeMethods.ovrAvatarMessage_GetAssetLoaded(avatarMessage.nativePointer), typeof(AvatarMessage_AssetLoaded));
        }

        public override AvatarMessage_AvatarSpecification AvatarMessage_GetAvatarSpecification(AvatarMessage avatarMessage)
        {
            return (AvatarMessage_AvatarSpecification) Marshal.PtrToStructure(SafeNativeMethods.ovrAvatarMessage_GetAvatarSpecification(avatarMessage.nativePointer), typeof(AvatarMessage_AvatarSpecification));
        }
        #endregion

        #region AVATAR ASSET
        public override void AvatarAsset_BeginLoading(UInt64 assedId)
        {
            SafeNativeMethods.ovrAvatarAsset_BeginLoading(assedId);
        }

        public override AvatarAssetType AvatarAsset_GetType(AvatarAsset avatarAsset)
        {
            return SafeNativeMethods.ovrAvatarAsset_GetType(avatarAsset.nativePointer);
        }

        public override AvatarMeshAssetData AvatarAsset_GetMeshData(AvatarAsset avatarAsset)
        {
            return (AvatarMeshAssetData) Marshal.PtrToStructure(SafeNativeMethods.ovrAvatarAsset_GetMeshData(avatarAsset.nativePointer), typeof(AvatarMeshAssetData));
        }

        public override AvatarMaterialState AvatarAsset_GetMaterialData(AvatarAsset avatarAsset)
        {
            throw new NotImplementedException();
        }

        public override AvatarTextureAssetData AvatarAsset_GetTextureData(AvatarAsset avatarAsset)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region AVATAR POSE
        public override AvatarBaseComponent AvatarPose_GetBaseComponent(Avatar avatar)
        {
            return (AvatarBaseComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarBaseComponent));
        }

        public override AvatarBodyComponent AvatarPose_GetBodyComponent(Avatar avatar)
        {
            return (AvatarBodyComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarBodyComponent));
        }

        public override AvatarControllerComponent AvatarPose_GetLeftControllerComponent(Avatar avatar)
        {
            return (AvatarControllerComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarControllerComponent));
        }

        public override AvatarHandComponent AvatarPose_GetLeftHandComponennt(Avatar avatar)
        {
            return (AvatarHandComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarHandComponent));
        }

        public override AvatarControllerComponent AvatarPose_GetRightControllerComponent(Avatar avatar)
        {
            return (AvatarControllerComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarControllerComponent));
        }

        public override AvatarHandComponent AvatarPose_GetRightHandComponent(Avatar avatar)
        {
            return (AvatarHandComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarPose_GetBaseComponent(avatar.nativePointer),
                typeof(AvatarHandComponent));
        }

        public override void AvatarPose_UpdateBody(Avatar avatar, AvatarTransform headPose)
        {
            SafeNativeMethods.ovrAvatarPose_UpdateBody(avatar.nativePointer, headPose);
        }

        public override void AvatarPose_UpdateHands(Avatar avatar, AvatarHandInputState inputStateLeft, AvatarHandInputState inputStateRight)
        {
            SafeNativeMethods.ovrAvatarPose_UpdateHands(avatar.nativePointer, inputStateLeft, inputStateRight);
        }

        public override void AvatarPose_Finalize(Avatar avatar, float deltaSeconds)
        {
            SafeNativeMethods.ovrAvatarPose_Finalize(avatar.nativePointer, deltaSeconds);
        }
        #endregion

        #region AVATAR COMPONENT
        public override UInt32 AvatarComponent_Count(Avatar avatar)
        {
            return SafeNativeMethods.ovrAvatarComponent_Count(avatar.nativePointer);
        }

        public override AvatarComponent AvatarComponent_Get(Avatar avatar, UInt32 index)
        {
            return (AvatarComponent)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarComponent_Get(avatar.nativePointer, index),
                typeof(AvatarComponent));
        }
        #endregion

        #region AVATAR RENDER PART
        public override AvatarRenderPartType AvatarRenderPart_GetType(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarRenderPart_GetType(avatarRenderPart.nativePointer);
        }

        public override AvatarRenderPart_SkinnedMeshRender AvatarRenderPart_GetSkinnedMeshRender(AvatarRenderPart avatarRenderPart)
        {
            return (AvatarRenderPart_SkinnedMeshRender)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarRenderPart_GetSkinnedMeshRender(avatarRenderPart.nativePointer),
                typeof(AvatarRenderPart_SkinnedMeshRender));
        }

        public override AvatarRenderPart_SkinnedMeshRenderPBS AvatarRenderPart_GetSkinnedMeshRenderPBS(AvatarRenderPart avatarRenderPart)
        {
            return (AvatarRenderPart_SkinnedMeshRenderPBS)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(avatarRenderPart.nativePointer),
                typeof(AvatarRenderPart_SkinnedMeshRenderPBS));
        }

        public override AvatarRenderPart_ProjectorRender AvatarRenderPart_GetProjectorRender(AvatarRenderPart avatarRenderPart)
        {
            return (AvatarRenderPart_ProjectorRender)Marshal.PtrToStructure(
                SafeNativeMethods.ovrAvatarRenderPart_GetProjectorRender(avatarRenderPart.nativePointer),
                typeof(AvatarRenderPart_ProjectorRender));
        }
        #endregion

        #region AVATAR SKINNED MESH RENDER
        public override AvatarTransform AvatarSkinnedMeshRender_GetTransform(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetTransform(avatarRenderPart.nativePointer);
        }

        public override AvatarTransform AvatarSkinnedMeshRenderPBS_GetTransform(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRenderPBS_GetTransform(avatarRenderPart.nativePointer);
        }

        public override UInt32 AvatarSkinnedMeshRender_GetVisibilityMask(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetVisibilityMask(avatarRenderPart.nativePointer);
        }

        public override UInt32 AvatarSkinnedMeshRenderPBS_GetVisibilityMask(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetVisibilityMask(avatarRenderPart.nativePointer);
        }

        public override UInt64 AvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(avatarRenderPart.nativePointer);
        }

        public override AvatarMaterialState AvatarSkinnedMeshRender_GetMaterialState(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetMaterialState(avatarRenderPart.nativePointer);
        }

        public override bool AvatarSkinnedMeshRender_MaterialStateChanged(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_MaterialStateChanged(avatarRenderPart.nativePointer);
        }

        public override UInt64 AvatarSkinnedMeshRender_GetDirtyJoints(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetDirtyJoints(avatarRenderPart.nativePointer);
        }

        public override UInt64 AvatarSkinnedMeshRenderPBS_GetDirtyJoints(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(avatarRenderPart.nativePointer);
        }

        public override AvatarTransform AvatarSkinnedMeshRender_GetJointTransform(AvatarRenderPart avatarRenderPart, UInt32 jointIndex)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRender_GetJointTransform(avatarRenderPart.nativePointer, jointIndex);
        }

        public override AvatarTransform AvatarSkinnedMeshRenderPBS_GetJointTransform(AvatarRenderPart avatarRenderPart, UInt32 jointIndex)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(avatarRenderPart.nativePointer, jointIndex);
        }

        public override UInt64 AvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(AvatarRenderPart avatarRenderPart)
        {
            return SafeNativeMethods.ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(avatarRenderPart.nativePointer);
        }
        #endregion
    }
}
