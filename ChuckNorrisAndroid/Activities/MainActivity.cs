using Android.App;
using Android.OS;
using Android.Widget;

namespace ChuckNorrisAndroid.Activities {

    [Activity(Label = "Chuck Norris Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity 
    {
        protected override void OnCreate(Bundle bundle) 
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var quotesButton = FindViewById<Button>(Resource.Id.Quotes);
            quotesButton.Click += delegate { StartActivity(typeof(QuotesActivity)); };

            var graphButton = FindViewById<Button>(Resource.Id.Graph);
            graphButton.Click += delegate { StartActivity(typeof(GraphActivity)); };

        }
    }
}

