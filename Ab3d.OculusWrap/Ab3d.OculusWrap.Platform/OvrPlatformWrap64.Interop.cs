using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Platform
{
    public partial class OvrPlatformWrap64
    {
        [SuppressUnmanagedCodeSecurity]
        internal static class SafeNativeMethods
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovr_PlatformInitializeWindows", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ovr_PlatformInitializeWindows([MarshalAs(UnmanagedType.LPWStr)] string appId);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovr_GetLoggedInUserID", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern UInt64 ovr_GetLoggedInUserID();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(_ovrPlatformDllName, EntryPoint = "ovr_IsPlatformInitialized", SetLastError = false, CallingConvention = CallingConvention.Cdecl)]
            internal static extern bool ovr_IsPlatforminitialized();
        }
    }
}
