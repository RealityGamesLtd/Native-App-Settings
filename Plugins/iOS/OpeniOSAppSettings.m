// https://developer.apple.com/documentation/uikit/uiapplication/1623042-opensettingsurlstring/

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