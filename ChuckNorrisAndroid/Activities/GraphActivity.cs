using System;
using Android.App;
using Android.OS;
using Android.Views;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Android;

namespace ChuckNorrisAndroid.Activities {

    [Activity(Label = "Graph")]
    public class GraphActivity : Activity 
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var plotView = new PlotView(this) {Model = CreatePlotModel()};
            AddContentView(plotView, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent));
        }

        private static PlotModel CreatePlotModel() 
        {
            var plotModel = new PlotModel {
                Title = "Chuck Norris Performance",
                Subtitle = "",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White,

            };

            plotModel.Series.Add(new FunctionSeries(Math.Log, -10, 10, 0.1) { Color = OxyColors.Green });

            var xAxis = new LinearAxis {
                Position = AxisPosition.Bottom,
                Title = "Years",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
            };

            plotModel.Axes.Add(xAxis);

            var yAxis = new LinearAxis {
                Position = AxisPosition.Left,
                Title = "Kicks per Second",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
            };

            plotModel.Axes.Add(yAxis);
            
            return plotModel;
        }
    }
}