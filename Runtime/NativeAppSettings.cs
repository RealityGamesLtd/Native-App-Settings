using System.Runtime.InteropServices;
using UnityEngine;

namespace NativeAppSettingsPlugin
{
    public enum SettingsDirectory
    {
        MAIN,
        LOCATION,
        NOTIFICATION
    }

    public class NativeAppSettings
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void OpenSettingsMenu();

        [DllImport("__Internal")]
        private static extern void OpenNotificationSettingsMenu();
#endif

#if UNITY_ANDROID
        private static AndroidJavaObject GetContext => new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        private static AndroidJavaObject GetPlugin => new("co.reality.nativeappsettings.NativeAppSettings");
#endif

        public static void OpenAppSettingsMenu(SettingsDirectory settingsDirectory)
        {
#if UNITY_ANDROID
            using (var plugin = GetPlugin)
            {
                using (GetContext)
                {
                    var directoryString = settingsDirectory switch
                    {
                        SettingsDirectory.MAIN => "openAppSettings",
                        SettingsDirectory.LOCATION => "openAppLocationSettings",
                        SettingsDirectory.NOTIFICATION => "openAppNotificationSettings",
                        _ => "openAppSettings"
                    };
                    plugin.CallStatic(directoryString, GetContext);
                }
            }
#elif UNITY_IOS
            // On iOS there's only Main app settings page and Notification page available
            switch (settingsDirectory)
            {
                case SettingsDirectory.NOTIFICATION:
                    OpenNotificationSettingsMenu();
                    break;
                default:
                    OpenSettingsMenu();
                    break;
            }
#else
            UnityEngine.Debug.LogWarning("Platform not supported!");
#endif

        }
    }
}