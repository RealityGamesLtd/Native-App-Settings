package co.reality.nativeappsettings

import android.content.ActivityNotFoundException
import android.content.Context
import android.content.Intent
import android.provider.Settings.*
import android.util.Log
import androidx.core.content.ContextCompat.startActivity

class NativeAppSettings {
    companion object {
        private const val TAG = "native_app_settings"

        @JvmStatic
        fun openAppLocationSettings(context: Context) {
            try {
                startActivity(context, Intent(ACTION_LOCATION_SOURCE_SETTINGS), null)
            } catch (e: ActivityNotFoundException) {
                Log.e(TAG, "Open settings exception", e)
            }
        }

        @JvmStatic
        fun openAppSettings(context: Context) {
            try {
                startActivity(context, Intent(ACTION_APPLICATION_DETAILS_SETTINGS), null)
            } catch (e: ActivityNotFoundException) {
                Log.e(TAG, "Open settings exception", e)
            }
        }

        @JvmStatic
        fun openAppNotificationSettings(context: Context) {
            try {
                startActivity(context, Intent(ACTION_APP_NOTIFICATION_SETTINGS), null)
            } catch (e: ActivityNotFoundException) {
                Log.e(TAG, "Open settings exception", e)
            }
        }
    }
}