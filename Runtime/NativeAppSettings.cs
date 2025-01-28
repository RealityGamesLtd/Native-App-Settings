using System.Runtime.InteropServices;
using UnityEngine;

/*
Available paths for iOS (keep in mind that some of them)
 App-Prefs:root=WIFI    Open Wi-Fi settings.
 App-Prefs:root=Bluetooth    Open Bluetooth settings.
 App-Prefs:root=General    Open General settings.
 App-Prefs:root=NOTIFICATIONS_ID    Open Notifications settings.
 App-Prefs:root=Privacy    Open Privacy settings.
 App-Prefs:root=Privacy&path=LOCATION    Open Location Services settings.
 App-Prefs:root=Privacy&path=CAMERA    Open Camera privacy settings.
 App-Prefs:root=Privacy&path=PHOTOS    Open Photos privacy settings.
 App-Prefs:root=Privacy&path=MICROPHONE    Open Microphone privacy settings.
 App-Prefs:root=Privacy&path=CONTACTS    Open Contacts privacy settings.
 App-Prefs:root=Privacy&path=CALENDARS    Open Calendars privacy settings.
 App-Prefs:root=Privacy&path=REMINDERS    Open Reminders privacy settings.
 App-Prefs:root=Privacy&path=MEDIA_LIBRARY    Open Media Library privacy settings.
 App-Prefs:root=Privacy&path=HEALTH    Open Health privacy settings.
 App-Prefs:root=Privacy&path=HOMEKIT    Open HomeKit privacy settings.
 App-Prefs:root=Sounds    Open Sounds settings.
 App-Prefs:root=DISPLAY    Open Display & Brightness settings.
 App-Prefs:root=Wallpaper    Open Wallpaper settings.
 App-Prefs:root=BATTERY_USAGE    Open Battery settings.
 App-Prefs:root=Storage    Open Storage settings.
 App-Prefs:root=Accessibility    Open Accessibility settings.
 App-Prefs:root=Keyboard    Open Keyboard settings.
 App-Prefs:root=DATE_AND_TIME    Open Date & Time settings.
 App-Prefs:root=RESET    Open Reset options.
 App-Prefs:root=SAFARI    Open Safari settings.
 App-Prefs:root=Music    Open Music settings.
 App-Prefs:root=Photos    Open Photos settings.
 App-Prefs:root=FaceTime    Open FaceTime settings.
 App-Prefs:root=Phone    Open Phone settings.
 App-Prefs:root=Messages    Open Messages settings.
 App-Prefs:root=App_Store    Open App Store settings.
 App-Prefs:root=GameCenter    Open Game Center settings.
 */

/*
Available strings for Android (keep in mind that some of them)
ACTION_ACCESSIBILITY_SETTINGS = "android.settings.ACCESSIBILITY_SETTINGS";
ACTION_ADD_ACCOUNT = "android.settings.ADD_ACCOUNT_SETTINGS";
ACTION_AIRPLANE_MODE_SETTINGS = "android.settings.AIRPLANE_MODE_SETTINGS";
ACTION_ALL_APPS_NOTIFICATION_SETTINGS = "android.settings.ALL_APPS_NOTIFICATION_SETTINGS";
ACTION_APN_SETTINGS = "android.settings.APN_SETTINGS";
ACTION_APPLICATION_DETAILS_SETTINGS = "android.settings.APPLICATION_DETAILS_SETTINGS";
ACTION_APPLICATION_DEVELOPMENT_SETTINGS = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
ACTION_APPLICATION_SETTINGS = "android.settings.APPLICATION_SETTINGS";
ACTION_APP_LOCALE_SETTINGS = "android.settings.APP_LOCALE_SETTINGS";
ACTION_APP_NOTIFICATION_BUBBLE_SETTINGS = "android.settings.APP_NOTIFICATION_BUBBLE_SETTINGS";
ACTION_APP_NOTIFICATION_SETTINGS = "android.settings.APP_NOTIFICATION_SETTINGS";
ACTION_APP_OPEN_BY_DEFAULT_SETTINGS = "android.settings.APP_OPEN_BY_DEFAULT_SETTINGS";
ACTION_APP_SEARCH_SETTINGS = "android.settings.APP_SEARCH_SETTINGS";
ACTION_APP_USAGE_SETTINGS = "android.settings.action.APP_USAGE_SETTINGS";
ACTION_AUTO_ROTATE_SETTINGS = "android.settings.AUTO_ROTATE_SETTINGS";
ACTION_BATTERY_SAVER_SETTINGS = "android.settings.BATTERY_SAVER_SETTINGS";
ACTION_BIOMETRIC_ENROLL = "android.settings.BIOMETRIC_ENROLL";
ACTION_BLUETOOTH_SETTINGS = "android.settings.BLUETOOTH_SETTINGS";
ACTION_CAPTIONING_SETTINGS = "android.settings.CAPTIONING_SETTINGS";
ACTION_CAST_SETTINGS = "android.settings.CAST_SETTINGS";
ACTION_CHANNEL_NOTIFICATION_SETTINGS = "android.settings.CHANNEL_NOTIFICATION_SETTINGS";
ACTION_CONDITION_PROVIDER_SETTINGS = "android.settings.ACTION_CONDITION_PROVIDER_SETTINGS";
ACTION_DATA_ROAMING_SETTINGS = "android.settings.DATA_ROAMING_SETTINGS";
ACTION_DATA_USAGE_SETTINGS = "android.settings.DATA_USAGE_SETTINGS";
ACTION_DATE_SETTINGS = "android.settings.DATE_SETTINGS";
ACTION_DEVICE_INFO_SETTINGS = "android.settings.DEVICE_INFO_SETTINGS";
ACTION_DISPLAY_SETTINGS = "android.settings.DISPLAY_SETTINGS";
ACTION_DREAM_SETTINGS = "android.settings.DREAM_SETTINGS";
ing ACTION_HARD_KEYBOARD_SETTINGS = "android.settings.HARD_KEYBOARD_SETTINGS";
ACTION_HOME_SETTINGS = "android.settings.HOME_SETTINGS";
ACTION_IGNORE_BACKGROUND_DATA_RESTRICTIONS_SETTINGS = "android.settings.IGNORE_BACKGROUND_DATA_RESTRICTIONS_SETTINGS";
ACTION_IGNORE_BATTERY_OPTIMIZATION_SETTINGS = "android.settings.IGNORE_BATTERY_OPTIMIZATION_SETTINGS";
ACTION_INPUT_METHOD_SETTINGS = "android.settings.INPUT_METHOD_SETTINGS";
ACTION_INPUT_METHOD_SUBTYPE_SETTINGS = "android.settings.INPUT_METHOD_SUBTYPE_SETTINGS";
ACTION_INTERNAL_STORAGE_SETTINGS = "android.settings.INTERNAL_STORAGE_SETTINGS";
ACTION_LOCALE_SETTINGS = "android.settings.LOCALE_SETTINGS";
ACTION_LOCATION_SOURCE_SETTINGS = "android.settings.LOCATION_SOURCE_SETTINGS";
ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS = "android.settings.MANAGE_ALL_APPLICATIONS_SETTINGS";
ACTION_MANAGE_ALL_FILES_ACCESS_PERMISSION = "android.settings.MANAGE_ALL_FILES_ACCESS_PERMISSION";
ACTION_MANAGE_ALL_SIM_PROFILES_SETTINGS = "android.settings.MANAGE_ALL_SIM_PROFILES_SETTINGS";
ACTION_MANAGE_APPLICATIONS_SETTINGS = "android.settings.MANAGE_APPLICATIONS_SETTINGS";
ACTION_MANAGE_APP_ALL_FILES_ACCESS_PERMISSION = "android.settings.MANAGE_APP_ALL_FILES_ACCESS_PERMISSION";
ACTION_MANAGE_DEFAULT_APPS_SETTINGS = "android.settings.MANAGE_DEFAULT_APPS_SETTINGS";
ACTION_MANAGE_OVERLAY_PERMISSION = "android.settings.action.MANAGE_OVERLAY_PERMISSION";
ACTION_MANAGE_SUPERVISOR_RESTRICTED_SETTING = "android.settings.MANAGE_SUPERVISOR_RESTRICTED_SETTING";
ACTION_MANAGE_UNKNOWN_APP_SOURCES = "android.settings.MANAGE_UNKNOWN_APP_SOURCES";
ACTION_MANAGE_WRITE_SETTINGS = "android.settings.action.MANAGE_WRITE_SETTINGS";
ACTION_MEMORY_CARD_SETTINGS = "android.settings.MEMORY_CARD_SETTINGS";
ACTION_NETWORK_OPERATOR_SETTINGS = "android.settings.NETWORK_OPERATOR_SETTINGS";
ACTION_NFCSHARING_SETTINGS = "android.settings.NFCSHARING_SETTINGS";
ACTION_NFC_PAYMENT_SETTINGS = "android.settings.NFC_PAYMENT_SETTINGS";
ACTION_NFC_SETTINGS = "android.settings.NFC_SETTINGS";
ACTION_NIGHT_DISPLAY_SETTINGS = "android.settings.NIGHT_DISPLAY_SETTINGS";
ACTION_NOTIFICATION_ASSISTANT_SETTINGS = "android.settings.NOTIFICATION_ASSISTANT_SETTINGS";
ACTION_NOTIFICATION_LISTENER_DETAIL_SETTINGS = "android.settings.NOTIFICATION_LISTENER_DETAIL_SETTINGS";
ACTION_NOTIFICATION_LISTENER_SETTINGS = "android.settings.ACTION_NOTIFICATION_LISTENER_SETTINGS";
ACTION_NOTIFICATION_POLICY_ACCESS_SETTINGS = "android.settings.NOTIFICATION_POLICY_ACCESS_SETTINGS";
ACTION_PRINT_SETTINGS = "android.settings.ACTION_PRINT_SETTINGS";
ACTION_PRIVACY_SETTINGS = "android.settings.PRIVACY_SETTINGS";
ACTION_PROCESS_WIFI_EASY_CONNECT_URI = "android.settings.PROCESS_WIFI_EASY_CONNECT_URI";
ACTION_QUICK_ACCESS_WALLET_SETTINGS = "android.settings.QUICK_ACCESS_WALLET_SETTINGS";
ACTION_QUICK_LAUNCH_SETTINGS = "android.settings.QUICK_LAUNCH_SETTINGS";
ACTION_REQUEST_IGNORE_BATTERY_OPTIMIZATIONS = "android.settings.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS";
ACTION_REQUEST_MANAGE_MEDIA = "android.settings.REQUEST_MANAGE_MEDIA";
ACTION_REQUEST_SCHEDULE_EXACT_ALARM = "android.settings.REQUEST_SCHEDULE_EXACT_ALARM";
ACTION_REQUEST_SET_AUTOFILL_SERVICE = "android.settings.REQUEST_SET_AUTOFILL_SERVICE";
ACTION_SEARCH_SETTINGS = "android.search.action.SEARCH_SETTINGS";
ACTION_SECURITY_SETTINGS = "android.settings.SECURITY_SETTINGS";
ACTION_SETTINGS = "android.settings.SETTINGS";
ACTION_SETTINGS_EMBED_DEEP_LINK_ACTIVITY = "android.settings.SETTINGS_EMBED_DEEP_LINK_ACTIVITY";
ACTION_SHOW_REGULATORY_INFO = "android.settings.SHOW_REGULATORY_INFO";
ACTION_SHOW_WORK_POLICY_INFO = "android.settings.SHOW_WORK_POLICY_INFO";
ACTION_SOUND_SETTINGS = "android.settings.SOUND_SETTINGS";
ACTION_SYNC_SETTINGS = "android.settings.SYNC_SETTINGS";
ACTION_USAGE_ACCESS_SETTINGS = "android.settings.USAGE_ACCESS_SETTINGS";
ACTION_USER_DICTIONARY_SETTINGS = "android.settings.USER_DICTIONARY_SETTINGS";
ACTION_VOICE_CONTROL_AIRPLANE_MODE = "android.settings.VOICE_CONTROL_AIRPLANE_MODE";
ACTION_VOICE_CONTROL_BATTERY_SAVER_MODE = "android.settings.VOICE_CONTROL_BATTERY_SAVER_MODE";
ACTION_VOICE_CONTROL_DO_NOT_DISTURB_MODE = "android.settings.VOICE_CONTROL_DO_NOT_DISTURB_MODE";
ACTION_VOICE_INPUT_SETTINGS = "android.settings.VOICE_INPUT_SETTINGS";
ACTION_VPN_SETTINGS = "android.settings.VPN_SETTINGS";
ACTION_VR_LISTENER_SETTINGS = "android.settings.VR_LISTENER_SETTINGS";
ACTION_WEBVIEW_SETTINGS = "android.settings.WEBVIEW_SETTINGS";
ACTION_WIFI_ADD_NETWORKS = "android.settings.WIFI_ADD_NETWORKS";
ACTION_WIFI_IP_SETTINGS = "android.settings.WIFI_IP_SETTINGS";
ACTION_WIFI_SETTINGS = "android.settings.WIFI_SETTINGS";
ACTION_WIRELESS_SETTINGS = "android.settings.WIRELESS_SETTINGS";
ACTION_ZEN_MODE_PRIORITY_SETTINGS = "android.settings.ZEN_MODE_PRIORITY_SETTINGS";
*/

namespace NativeAppSettingsPlugin
{
    public enum SettingsDirectory
    {
        MAIN,
        LOCATION_PERMISSIONS,
        NOTIFICATION,
        LOCATION_SERVICES
    }

    public class NativeAppSettings
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void OpenSettingsMenu();
        
        [DllImport("__Internal")]
        private static extern void OpenSettingsMenuAt(string value);

        [DllImport("__Internal")]
        private static extern void OpenNotificationSettingsMenu();

        [DllImport("__Internal")]
        private static extern void OpenAppLocationServicesSettings();
#endif

#if UNITY_ANDROID
        private const string OPEN_APP_SETTINGS_METHOD_NAME = "openAppSettings";
        private const string OPEN_LOCATION_SETTINGS_METHOD_NAME = "openAppLocationSettings";
        private const string OPEN_NOTIFICATION_SETTINGS_METHOD_NAME = "openAppNotificationSettings";
        private const string OPEN_LOCATION_SERVICES_SETTINGS_METHOD_NAME = "openAppLocationServicesSettings";
        private static AndroidJavaObject GetContext => new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        private static AndroidJavaObject GetPlugin => new("co.reality.nativeappsettings.NativeAppSettings");
#endif

        public static void OpenAppSettingsMenu(string path)
        {
#if UNITY_ANDROID
            using var plugin = GetPlugin;
            using (GetContext)
            {
                plugin.CallStatic(OPEN_APP_SETTINGS_METHOD_NAME, GetContext, path);
            }
#elif UNITY_IOS
            OpenSettingsMenuAt(path);
#else
            UnityEngine.Debug.LogWarning("Platform not supported!");
#endif
        }

        public static void OpenAppSettingsMenu(SettingsDirectory settingsDirectory)
        {
#if UNITY_ANDROID
            using var plugin = GetPlugin;
            using (GetContext)
            {
                var directoryString = settingsDirectory switch
                {
                    SettingsDirectory.MAIN => OPEN_APP_SETTINGS_METHOD_NAME,
                    SettingsDirectory.LOCATION_PERMISSIONS => OPEN_LOCATION_SETTINGS_METHOD_NAME,
                    SettingsDirectory.NOTIFICATION => OPEN_NOTIFICATION_SETTINGS_METHOD_NAME,
                    SettingsDirectory.LOCATION_SERVICES => OPEN_LOCATION_SERVICES_SETTINGS_METHOD_NAME,
                    _ => OPEN_APP_SETTINGS_METHOD_NAME
                };
                plugin.CallStatic(directoryString, GetContext);
            }
#elif UNITY_IOS
            // On iOS there's only Main app settings page and Notification page available
            switch (settingsDirectory)
            {
                case SettingsDirectory.NOTIFICATION:
                    OpenNotificationSettingsMenu();
                    break;
                case SettingsDirectory.LOCATION_PERMISSIONS:
                    OpenSettingsMenu();
                    break;
                case SettingsDirectory.LOCATION_SERVICES:
                    OpenAppLocationServicesSettings();
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