using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Simple_M10
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
            //{
            //    Window?.SetDecorFitsSystemWindows(true);
            //}
            //else if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            //{
            //    // Clear any fullscreen flags for API 29 and below
            //    Window?.ClearFlags(WindowManagerFlags.LayoutNoLimits);
            //    Window?.ClearFlags(WindowManagerFlags.Fullscreen);

            //    // Ensure system UI is visible
            //    var decorView = Window?.DecorView;
            //    if (decorView != null)
            //    {
            //        var uiOptions = (int)decorView.SystemUiVisibility;
            //        uiOptions &= ~(int)SystemUiFlags.Fullscreen;
            //        uiOptions &= ~(int)SystemUiFlags.HideNavigation;
            //        uiOptions &= ~(int)SystemUiFlags.ImmersiveSticky;
            //        decorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
            //    }
            //}
            //// Opt out of edge-to-edge - revert to MAUI 9 behavior
            //if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
            //{
            //    Window?.SetDecorFitsSystemWindows(true);
            //}

            //            // Enable edge-to-edge display
            //            if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
            //            {
            //                Window?.SetDecorFitsSystemWindows(false);
            //            }
            //            else
            //            {
            //#pragma warning disable CA1416
            //                Window?.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);
            //#pragma warning restore CA1416
            //            }
        }
    }
}
