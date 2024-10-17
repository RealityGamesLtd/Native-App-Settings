# NativeAppSettings

A plugin that provides easy access to system settings page.
Note, that on iOS deep linking is limited to main or notification page.

## Build the library in Android Studio

There are 2 gradle tasks that need to be run in order to build the .aar of the library:

1. `build`
1. `bundleReleaseAar`

Next, the build .aar that is in `Native-App-Settings\Plugins\Android\src~\NativeAppSettings\NativeAppSettings\build\outputs\aar\NativeAppSettings-release.aar` should be copied to directory `Native-App-Settings\Plugins\Android` to make sure it is accessible by Unity when building the game.

## Usage

Create instance of OngoingOperations

```csharp
NativeAppSettings.OpenAppSettingsMenu(SettingsDirectory.MAIN);
 ```

 Options:

 ```csharp
MAIN, LOCATION, NOTIFICATION
 ```
