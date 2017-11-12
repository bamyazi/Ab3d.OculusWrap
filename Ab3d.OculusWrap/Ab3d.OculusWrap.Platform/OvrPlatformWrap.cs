using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ab3d.OculusWrap.Platform
{
    public abstract class OvrPlatformWrap
    {
        private static IntPtr _oculusPlatformPtr;

        public abstract string OvrPlatformDllName { get; }

        public static OvrPlatformWrap Create()
        {
            if (Environment.Is64BitProcess)
                return new OvrPlatformWrap64();

            return new OvrPlatformWrap32();
        }

        #region static LoadLibrary, UnloadLibrary
        /// <summary>
        /// Manually loads the Oculus runtime dll into memory. This allows unloading the dll when it is not used any more with <see cref="UnloadLibrary"/> method.
        /// </summary>
        public static void LoadLibrary()
        {
            if (_oculusPlatformPtr != IntPtr.Zero)
                return;

            string oculusDllName = Environment.Is64BitProcess ? OvrPlatformWrap64._ovrPlatformDllName : OvrPlatformWrap32._ovrPlatformDllName;

            _oculusPlatformPtr = NativeMethods.LoadLibrary(oculusDllName);
            if (_oculusPlatformPtr == IntPtr.Zero)
            {
                int win32Error = Marshal.GetLastWin32Error();
                throw new Win32Exception(win32Error, "Unable to load Oculus runtime library \"" + oculusDllName + "\". LoadLibrary reported error code: " + win32Error + ".");
            }
        }

        /// <summary>
        /// Unloads the Oculus runtime library that was loaded before with <see cref="LoadLibrary"/> method.
        /// </summary>
        public static void UnloadLibrary()
        {
            if (_oculusPlatformPtr == IntPtr.Zero)
                return;

            bool success = NativeMethods.FreeLibrary(_oculusPlatformPtr);
            if (success)
                _oculusPlatformPtr = IntPtr.Zero;
        }
        #endregion

        #region Kernel32 Platform invoke methods

        internal class NativeMethods
        {
            /// <summary>
            /// Loads a dll into process memory.
            /// </summary>
            /// <param name="lpFileName">Filename to load.</param>
            /// <returns>Pointer to the loaded library.</returns>
            /// <remarks>
            /// This method is used to load the DllOVR.dll into memory, before calling any of it's DllImported methods.
            /// </remarks>
            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi, BestFitMapping = false)]
            public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

            /// <summary>
            /// Frees a previously loaded dll, from process memory.
            /// </summary>
            /// <param name="hModule">Pointer to the previously loaded library (This pointer comes from a call to LoadLibrary).</param>
            /// <returns>Returns true if the library was successfully freed.</returns>
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FreeLibrary(IntPtr hModule);
        }

        #endregion

        #region SDK
        public abstract void InitializeWindows(string appID);
        public abstract bool IsPlatformInitialized();
        public abstract UInt64 GetLoggedInUserID();
        #endregion
    }
}
