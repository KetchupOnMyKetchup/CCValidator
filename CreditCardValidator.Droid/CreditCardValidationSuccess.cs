using Android.App;
using Android.OS;
using Android;

namespace CreditCardValidator.Droid
{
    [Activity(Label = "@string/activity_success", Theme = "@android:style/Theme.Holo.Light")]
    public class CreditCardValidationSuccess : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CreditCardValidationSuccess);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Microsoft.AppCenter.Analytics.Analytics.TrackEvent(
                "Credit Card Validation Loaded",
                new System.Collections.Generic.Dictionary<string, string> { { "Load Duration", elapsedMs.ToString() } }
            );
        }
    }
}
