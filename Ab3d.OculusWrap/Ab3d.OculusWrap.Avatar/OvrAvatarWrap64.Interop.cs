using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Ab3d.OculusWrap.Avatar
{
    public sealed partial class OvrAvatarWrap64
    {
        [SuppressUnmanagedCodeSecurity]
        internal static class SafeNativeMethods
        {
            #region ovrAvatar

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_Initialize", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_Initialize([MarshalAs(UnmanagedType.LPWStr)] string appId);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_RequestAvatarSpecification", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_RequestAvatarSpecification(UInt64 userId);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_Create", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, AvatarCapabilities capabilities);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetLeftControllerVisibility", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool visible);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetRightControllerVisibility", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool visible);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetLeftHandGesture", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, AvatarHandGesture gesture);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetRightHandGesture", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, AvatarHandGesture gesture);

            //TODO: Add support for custom gestures

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetActiveCapabilities", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetActiveCapabilities(IntPtr avatar, AvatarCapabilities capabilities);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_ClearCustomBasePosition", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_ClearCustomBasePosition(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_SetCustomBasePosition", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_SetCustomBasePosition(IntPtr avatar, AvatarVector3f position);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_GetReferencedAssetCount", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt32 ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_GetReferencedAsset", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovrAvatar_GetReferencedAsset(IntPtr avatar, UInt32 index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatar_Destroy", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatar_Destroy(IntPtr avatar);

            #endregion

            #region ovrAvtarMessage

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarMessage_Pop", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarMessage_Pop();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarMessage_GetType", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarMessageType ovrAvatarMessage_GetType(IntPtr avatarMessage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarMessage_GetAvatarSpecification", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarMessage_GetAvatarSpecification(IntPtr avatarMessage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarMessage_GetAssetLoaded", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarMessage_GetAssetLoaded(IntPtr avatarMessage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarMessage_Free", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatarMessage_Free(IntPtr avatarMessage);

            #endregion

            #region ovrAvatarAsset

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarAsset_BeginLoading", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatarAsset_BeginLoading(UInt64 assetId);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarAsset_GetType", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarAssetType ovrAvatarAsset_GetType(IntPtr asset);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarAsset_GetMeshData", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarAsset_GetMeshData(IntPtr asset);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarAsset_GetTextureData", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarAsset_GetTextureData(IntPtr asset);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarAsset_GetMaterialData", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarAsset_GetMaterialData(IntPtr asset);

            #endregion

            #region ovrAvatarPose

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetBodyComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetBodyComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetBaseComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetBaseComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetLeftControllerComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetRightControllerComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetRightControllerComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetLeftHandComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetLeftHandComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_GetRightHandComponent", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_GetRightHandComponent(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_UpdateBody", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarPose_UpdateBody(IntPtr avatar, AvatarTransform headPose);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_UpdateHands", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, AvatarHandInputState inputStateLeft, AvatarHandInputState inputStateRight);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarPose_Finalize", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovrAvatarPose_Finalize(IntPtr avatar, float deltaSeconds);

            #endregion

            #region ovrAvatarComponent
            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarComponent_Count", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt32 ovrAvatarComponent_Count(IntPtr avatar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarComponent_Get", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarComponent_Get(IntPtr avatar, UInt32 index);
            #endregion

            #region ovrAvatarRenderPart
            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarRenderPart_GetType", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarRenderPart_GetSkinnedMeshRender", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarRenderPart_GetSkinnedMeshRenderPBS", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarRenderPart_GetProjectorRender", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr ovrAvatarRenderPart_GetProjectorRender(IntPtr avatarRenderPart);
            #endregion

            #region ovrAvatarSkinnedMeshRender
            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_GetTransform", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetTransform", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_GetVisibilityMask", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt32 ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt32 ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_MaterialStateChanged", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_GetMaterialState", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_GetDirtyJoints", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRender_GetJointTransform", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr avatarRenderPart, UInt32 jointIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetJointTransform", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern AvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr avatarRenderPart, UInt32 jointIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr avatarRenderPart);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr avatarRenderPart);
            #endregion
        }
    }
}
