using Android.App;
using Android.Content.PM;
using Android.OS;
using Prism;
using Prism.Ioc;

namespace PrismEpub.Droid
{
    [Activity(Label = "PrismEpub", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
           LoadApplication(new App(new AndroidInitializer()));
            /*LoadApplication(UXDivers.Gorilla.Droid.Player.UseApplication(new App(new AndroidInitializer()), this,
                
                 
                 new UXDivers.Gorilla.Config("Good Gorilla")
                   // Register UXDivers Effects assembly
                   .RegisterAssembly(typeof(UXDivers.Effects.Effects).Assembly)
                   // FFImageLoading.Transformations
                   .RegisterAssemblyFromType<FFImageLoading.Transformations.BlurredTransformation>()
                   // FFImageLoading.Forms
                   .RegisterAssemblyFromType<FFImageLoading.Forms.CachedImage>()
                 ));*/
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}

