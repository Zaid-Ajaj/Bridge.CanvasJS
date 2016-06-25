using Bridge;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartOptions
    {
        /// <summary>
        /// Enables / Disables Chart interactivity like toolTip, mouse and touch events
        /// </summary>
        public bool InteractivityEnabled { get; set; }
        /// <summary>
        /// Sets the duration of animation in milliseconds. 
        /// </summary>
        public int AnimationDuration { get; set; }
        /// <summary>
        /// Enables Animation while rendering the Chart.
        /// </summary>
        public bool AnimationEnabled { get; set; }
        /// <summary>
        /// While exporting any chart, “Chart” is used as the default fine name with corresponding extension “jpg” or “png”. You can override this name using exportFileName property. 
        /// </summary>
        public string ExportFileName { get; set; }
        /// <summary>
        /// Setting exportEnabled to true enables the export feature. As of now JPEG & PNG formats are supported. Export feature is available in all Chart Types. 
        /// </summary>
        public bool ExportEnabled { get; set; }
        /// <summary>
        /// Setting zoomEnabled to true enables zooming and panning feature of Chart. This way you can zoom into an area of interest when there is a large amount of data. This will also allow you to pan through the chart. If not set, the property is automatically enabled for large number of dataPoints. You can switch between zooming & panning using the toolbar that appears on the chart. After Zooming in, you can reset the chart by clicking the reset button.
        /// </summary>
        public bool ZoomEnabled { get; set; }
        /// <summary>
        /// zoomType allows you to control the axis for which zooming and panning are enabled. Default is “x” which enables zooming across xAxis. You can customize this to allow zooming/panning on yAxis or both xAxis and yAxis by setting zoomType to “y” or “xy”. 
        /// </summary>
        public ChartZoomType ZoomType { get; set; }
        /// <summary>
        /// Sets the theme of the Chart. Various predefined themes are bundled along with the library. User can easily switch these themes by changing theme property to the below mentioned options. 
        /// </summary>
        public string Theme { get; set; }
        /// <summary>
        /// Sets the background color of entire Chart Area. Values can be “HTML Color Name”, “hex code” or “rgba values”
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// Sets the colorSet of the Chart. Color Set is an array of colors that are used to render data. Various predefined Color Sets are bundled along with the library. You can either choose from the pre-defined Color Sets or define your own Color Set. 
        /// </summary>
        public string ColorSet { get; set; }
        /// <summary>
        /// CanvasJS allows you to localize various culture / language / country specific elements in the Chart like number formatting style – where you can choose which character to use as a decimal separator and as a digit group separator (also referred to as a thousand separator). By default CanvasJS is set to Neutral English Culture – “en”.
        /// </summary>
        public string Culture { get; set; }
        /// <summary>
        /// Sets the rangeChanging event handler for Chart which is triggered before viewportMinimum or viewPortMaximum are updated while zooming, panning, or reset. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes trigger, type and axes viewportMinimum and viewportMaximum corresponding to the event.
        /// </summary>
        public Action<ChartRangeChangedEventArgs> RangeChanging { get; set; }
        /// <summary>
        /// Sets the rangeChanged event handler for Chart which is triggered after viewportMinimum or viewPortMaximum are updated while zooming, panning, or reset. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes trigger, type and axes viewportMinimum and viewportMaximum corresponding to the event. 
        /// </summary>
        public Action<ChartRangeChangedEventArgs> RangeChanged { get; set; }
        /// <summary>
        /// Sets the width of the Chart. Default: Takes chart container’s width by default. If the width is not set for the chart container, defaults to 500.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Sets the height of the Chart,  Takes chart container’s height by default. If the height is not set for the chart container, defaults to 400.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// dataPointMaxWidth sets the maximum width of dataPoints in column / bar, ohlc and candlestick, charts. This allows you to limit the width of dataPoints when there are very few of them in the chart. At the same time, when the number of dataPoints increase, chart reduces their width so that they don’t overlap, Default : Automatically calculated based on the chart size.
        /// </summary>
        public int DataPointMaxWidth { get; set; }
        /// <summary>
        /// dataPointMinWidth sets the minimum width of dataPoints in column / bar, ohlc and candlestick, charts. This allows you to set a minimum limit on the width of dataPoints so that they don’t become very thin when there are too many dataPoints. At the same time, when the number of dataPoints decrease, chart increase their width automatically.
        /// </summary>
        public int DataPointMinWidht { get; set; }
        /// <summary>
        /// dataPointWidth sets the width of dataPoints in column / bar, ohlc and candlestick, charts. This allows you to fix the width of dataPoints such that their width doesn’t change when the total number of dataPoints varies. At the same time, when the number of dataPoints increase, it can lead to overlap if dataPointWidth is not set properly.Default : Automatically calculated based on the chart size.
        /// </summary>
        public int DataPointWidth { get; set; }
        /// <summary>
        /// axisX object lets you set various parameters of X Axis like interval, grid lines, etc. It is mostly horizontal, except when we are working with Bar Charts, where axisX is vertical. 
        /// </summary>
        public ChartAxis AxisX { get; set; }
        /// <summary>
        /// axisY object lets you set various parameters of Y Axis like interval, grid lines, etc. It is mostly vertical, except when we are working with Bar Charts, where axisY is horizontal
        /// </summary>
        public ChartAxis AxisY { get; set; }
        /// <summary>
        /// axisY2 is the secondary axis which renders on the opposite of primary axis (axisY). It is mostly vertical, except when we are working with Bar Charts, where axisY2 is horizontal. 
        /// </summary>
        public ChartAxis AxisY2 { get; set; }
        /// <summary>
        /// subtitles is a collection of subtitle elements. This allows you to have as many subtitles as you want in a chart.
        /// subtitle allows you to set content, appearance and position of Chart’s subtitle. subtitle is very much like title except that its font size is lesser than title by default. subtitle is rendered below the main title object whenever its vertical and horizontal align properties are same as title. 
        /// Subtitle has exactly the same properties as title object and hence all links below will redirect to corresponding pages in Title.
        /// </summary>
        public ChartTitle[] Subtitles { get; set; }
        /// <summary>
        /// Whenever the chart contains multiple dataSeries, it is recommended to represent each dataSeries in a legend. This way it becomes easier for the user to know what exactly is represented by each of the dataSeries. In case of Pie and Doughnut charts, an entry is created for each dataPoint and in rest of the chart types entries are created for each dataSeries. 
        /// </summary>
        public ChartLegend Legend { get; set; }
        /// <summary>
        /// toolTip object lets user set behaviour of toolTip at global level like enabling/disabling animation, setting Border Color, sharing toolTip between multiple dataSeries, etc. You can also disable the toolTip by setting enabled property to false.
        /// </summary>
        public ChartTooltip Tooltip { get; set; }
        /// <summary>
        /// Title allows you to set content, appearance and position of Chart’s Title.
        /// Chart can have only one Title element.But you can have multiple subtitles if required.Subtitles have exactly the same properties as title but with smaller font size by default.
        /// </summary>
        public ChartTitle Title { get; set; }
        /// <summary>
        /// Each element in the data array is a dataSeries object. dataSeries is the object where user can define all the dataPoints to be plotted and also control various properties related to rendering – like chart type, color, labels, events, etc.
        ///Certain properties like tooltipText, color, etc can be set at both dataSeries and dataPoint level.In those cases, the value set at dataPoint overrides the one provided at the dataSeries level.
        ///You can add more than one dataSeries element to data Array in order to create Multi-Series/Combination charts.Using “type” property of dataSeries, you can define how it should be rendered – column, line, pie, etc.
        /// Whenever you have more than one dataSeries, they all can have same or different chart types, making it a Multi-Series or a Combinational Chart.
        /// </summary>
        public ChartDataSeries[] Data { get; set; }

    }
}