using CassavaRoots.Effects;

namespace CassavaRoots.Hosting
{
    public static class AppBuilderExtensions
    {
        public static MauiAppBuilder UseMauiTouchEffect(this MauiAppBuilder builder)
        {
            builder.ConfigureEffects(effects =>
            {
                // Implemented only on iOS & Android
                // Partial touch effect really did not want to work.... a partial behavior did work
#if IOS
                effects.Add<TouchEffect, Platforms.iOS.PlatformTouchEffect>();
#endif
#if ANDROID
                effects.Add<TouchEffect, Platforms.Android.PlatformTouchEffect>();
#endif

            });

            return builder;
        }
    }
}
