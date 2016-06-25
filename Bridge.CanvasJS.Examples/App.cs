using Bridge;
using Bridge.Html5;
using System;
using Bridge.CanvasJS;
using System.Collections.Generic;

namespace Bridge.CanvasJS.Examples
{
    public class App
    {
        // Helper functions
        private static ChartDataPoint Point(string label, float y, float x)
        {
            return new ChartDataPoint { Label = label, Y = y, X = x };
        }
        private static ChartDataPoint Point(string label, float y)
        {
            return new ChartDataPoint { Label = label, Y = y,};
        }
        private static ChartDataPoint Point(double x, double y)
        {
            return new ChartDataPoint { X = x, Y = y };
        }


        public static void Main()
        {
            // adding new color set for the pie chart
            CanvasJS.AddColorSet("greenish", new string[] {
                "green",
                "darkgreen",
                "lightgreen"
            });


            ColumnChart("columnChart").Render();

            PieChart("pieChart").Render(); // the color set is applied here

            SinCurve("sinCurve").Render();
        }

        private static CanvasJS.Chart ColumnChart(string elementId)
        {
            return new CanvasJS.Chart(elementId, new ChartOptions
            {
                Title = new ChartTitle { Text = "Fruit Sales" },
                InteractivityEnabled = false,
                Data = new ChartDataSeries[]
                {
                    new ChartDataSeries
                    {
                        Type = ChartType.Column,
                        DataPoints = new ChartDataPoint[]
                        {
                            Point("Apple", 10),
                            Point("Orange", 15),
                            Point("Banana", 25),
                            Point("Mango", 30),
                            Point("Grape", 28)
                        }
                    }
                }
            });
        }

        private static CanvasJS.Chart PieChart(string elementId)
        {
            
            return new CanvasJS.Chart(elementId, new ChartOptions
            {
                Title = new ChartTitle { Text = "Favorite languages" },
                ColorSet = "greenish", // the "greenish" color set applied to this chart
                InteractivityEnabled = false,
                Data = new ChartDataSeries[]
                {
                    new ChartDataSeries
                    {
                        Type = ChartType.Pie,
                        DataPoints = new ChartDataPoint[]
                        {
                            Point("C#", 40),
                            Point("F#", 40),
                            Point("Javascript", 20),
                        }
                    }
                }
            });
        }

        private static CanvasJS.Chart SinCurve(string elementId)
        {
            // generate points for the curve
            var points = new List<ChartDataPoint>();
            for (var i = 0.0; i < 2.0 * Math.PI; i += 0.1)
                points.Add(Point(i, Math.Sin(i)));

            return new CanvasJS.Chart(elementId, new ChartOptions
            {
                Title = new ChartTitle { Text = "Sin curve" },
                InteractivityEnabled = false,
                Data = new ChartDataSeries[]
                {
                    new ChartDataSeries
                    {
                        Type = ChartType.Spline,
                        DataPoints = points.ToArray()
                    }
                },
                AxisY = new ChartAxis { GridDashType = ChartDashType.ShortDash }
            });
        }

    }
}