// https://developer.apple.com/documentation/uikit/uiapplication/1623042-opensettingsurlstring/

/*
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

    char* cStringCopyA(const char* string)
    {
        if (string == NULL)
            return NULL;
        char* res = (char*)malloc(strlen(string) + 1);
        strcpy(res, string);
        return res;
    }

    void OpenAppLocationServicesSettings() {
        if (&UIApplicationOpenSettingsURLString != NULL) {
            NSURL *appSettings = [NSURL URLWithString:"App-Prefs:root=Privacy&path=LOCATION"];
            [[UIApplication sharedApplication] openURL:appSettings];
        }
    }
    
    void OpenSettingsMenuAt(const char * value) {
        NSString *url = [NSString stringWithUTF8String:value];
        if (&url != NULL) {
            NSURL *appSettings = [NSURL URLWithString:url];
            [[UIApplication sharedApplication] openURL:appSettings
                                               options:@{}
                                     completionHandler:^(BOOL success) {}];
        }
    }
    
    void OpenSettingsMenu() {
        if (&UIApplicationOpenSettingsURLString != NULL) {
            NSURL *appSettings = [NSURL URLWithString:UIApplicationOpenSettingsURLString];
            
            [[UIApplication sharedApplication] openURL:appSettings
                                               options:@{}
                                     completionHandler:^(BOOL success) {}];
        }
    }
    
    void OpenNotificationSettingsMenu() {
        if (@available(iOS 16.0, *)){
            if (&UIApplicationOpenSettingsURLString != NULL) {
                NSURL *appSettings = [NSURL URLWithString:UIApplicationOpenNotificationSettingsURLString];
                
                [[UIApplication sharedApplication] openURL:appSettings
                                                   options:@{}
                                         completionHandler:^(BOOL success) {}];
            }
        } else {
            NSURL *appSettings = [NSURL URLWithString:UIApplicationOpenSettingsURLString];
            
            [[UIApplication sharedApplication] openURL:appSettings
                                               options:@{}
                                     completionHandler:^(BOOL success) {}];
            
        }
    }

