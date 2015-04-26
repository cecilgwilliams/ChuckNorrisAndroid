using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ChuckNorris;

namespace ChuckNorrisAndroid.Activities 
{

    [Activity(Label = "Quotes")]
    public class QuotesActivity : Activity
    {

        readonly ChuckNorrisQuotes _chuckNorrisQuotes = new ChuckNorrisQuotes();

        protected override void OnCreate(Bundle bundle) 
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Quotes);

            var nextButton = FindViewById<Button>(Resource.Id.NextQuote);
            var quoteText = FindViewById<TextView>(Resource.Id.QuoteText);
            nextButton.Click += delegate { quoteText.Text = _chuckNorrisQuotes.GetNextQuote(); };

        }
    }
}