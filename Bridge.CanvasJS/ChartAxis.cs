using Bridge;
using Bridge.Html5;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartAxis
    {
        public string Title { get; set; }
        /// <summary>
        /// titleWrap specifies whether to wrap or clip axis title once its width crosses titleMaxWidth.
        /// </summary>
        public bool TitleWrap { get; set; }
        /// <summary>
        /// Sets the maximum width of title after which it gets wrapped or clipped depending on whether titleWrap is set to true (default) or false. 
        /// </summary>
        public int TitleMaxWidth { get; set; }
        /// <summary>
        /// Sets the Font Color of Axis Title. The value of titleFontColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string TitleFontColor { get; set; }
        /// <summary>
        /// Sets the Font Size of Axis Title in pixels. 
        /// </summary>
        public int TitleFontSize { get; set; }
        /// <summary>
        /// Sets the Font Family of Axis Title.
        /// </summary>
        public string TitleFontFamily { get; set; }
        /// <summary>
        /// Sets the Font Weight used in the Axis Title. It can be set to one of the options below. 
        /// </summary>
        public ChartFontWeight TitleFontWeight { get; set; }
        /// <summary>
        /// Sets the Font Style of Axis Title. It can be set to one of the below options.
        /// </summary>
        public ChartFontStyle TitleFontStyle { get; set; }
        /// <summary>
        /// This property lets you set margin between chart’s boundary and Axis.
        /// </summary>
        public int Margin { get; set; }
        /// <summary>
        /// Sets the maximum width of label after which it gets wrapped or clipped depending on whether labelWrap is set to true (default) or false. 
        /// </summary>
        public int LabelMaxWidth { get; set; }
        /// <summary>
        /// labelWrap specifies whether to wrap or clip label once its width crosses labelMaxWidth.
        /// </summary>
        public bool LabelWrap { get; set; }
        /// <summary>
        /// Setting labelAutoFit to true automatically wraps and/or rotates and/or reduces font size of label when they are too long and overlaps, finds the best-fit and automatically manages label overlapping
        /// </summary>
        public bool LabelAutoFit { get; set; }
        /// <summary>
        /// Sets the angle for Axis Labels.
        /// </summary>
        public int LabelAngle { get; set; }
        /// <summary>
        /// Sets the Font Family of Axis labels. 
        /// </summary>
        public string LabelFontFamily { get; set; }
        /// <summary>
        /// Sets the Axis Label color. The value of labelFontColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string LabelFontColor { get; set; }
        /// <summary>
        /// Sets the Axis Label Font Size in pixels. 
        /// </summary>
        public int LabelFontSize { get; set; }
        /// <summary>
        /// Set the font Weight used in Axis Labels.
        /// </summary>
        public ChartFontWeight LabelFontWeight { get; set; }
        /// <summary>
        /// A custom formatter function that returns label to be displayed on the axis.
        /// </summary>
        public Action<dynamic> LabelFormatter { get; set; }
        /// <summary>
        /// Sets the Font Style of Axis Labels. It can be set to one of the below options. 
        /// </summary>
        public ChartFontStyle LabelFontStyle { get; set; }
        /// <summary>
        /// A string that prepends all the labels on the axis.
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// A string that appends all the labels on axis.
        /// </summary>
        public string Suffix { get; set; }
        /// <summary>
        /// Defines how values must be formatted before they appear on Axis X. You can format numbers and date time values using this property. Below you will find descriptive table explaining various specifiers with example.
        /// </summary>
        public string ValueFormatString { get; set; }
        /// <summary>
        /// Sets the minimum value of Axis. Values smaller than minimum are clipped. minimum also sets the lower limit while panning chart. 
        /// </summary>
        public Any<Date, double, float, int> Minimum { get; set; }
        /// <summary>
        /// Sets the maximum value permitted on Axis. Values greater than maximum are clipped. maximum also sets the upper limit while panning chart. 
        /// </summary>
        public Any<Date, double, float, int> Maximum { get; set; }
        /// <summary>
        /// Viewport is the visible range of the axis and viewportMaximum allows you to set its maximum value. This can be used in combination with viewportMinimum in order to zoom into a certain region programmatically.
        /// </summary>
        public Any<Date, double, float, int> ViewportMaximum { get; set; }
        /// <summary>
        /// Viewport is the visible range of the axis and viewportMinimum allows you to set its minimum value. This can be used in combination with viewportMaximum in order to zoom into a certain region programmatically. 
        /// </summary>
        public Any<Date, double, float, int> ViewportMimimum { get; set; }
        /// <summary>
        /// Sets the distance between Tick Marks, Grid Lines and Interlaced Colors. 
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// intervalType is the unit of interval property. intervalType is by default set to “number” and hence you need to specify the interval type (eg “week”, “month”, etc) depending on the type of interval you intend to set. If required interval is 3 months, you need to provide interval as 3 and intervalType as “month”
        /// </summary>
        public ChartIntervalType IntervalType { get; set; }
        /// <summary>
        /// Sets the length of Tick Marks that are drawn on the Axis. 
        /// </summary>
        public int TickLength { get; set; }
        /// <summary>
        /// Sets the color of Tick Marks drawn on the axis. The value of tickColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string TickColor { get; set; }
        /// <summary>
        /// Sets the thickness of the Tick Marks in pixels. 
        /// </summary>
        public int TickThickness { get; set; }
        /// <summary>
        /// Sets the color of Axis line. Axis line color can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string LineColor { get; set; }
        /// <summary>
        /// Sets the Thickness of Axis line in pixels.
        /// </summary>
        public int LineThickness { get; set; }
        /// <summary>
        /// Sets the Dash Type of axis line. 
        /// </summary>
        public ChartDashType LineDashType { get; set; }
        /// <summary>
        /// Sets the Dash Type for grid lines on axis.
        /// </summary>
        public ChartDashType GridDashType { get; set; }
        /// <summary>
        /// Sets the Interlacing Color that alternates between the set interval. If the interval is not set explicitly, then the auto calculated interval is considered. The value of interlacedColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string InterlacedColor { get; set; }
        /// <summary>
        /// Sets the Thickness of Grid Lines. To display grid on Axis, set the Grid Thickness to a number greater than zero. 
        /// </summary>
        public int GridThickness { get; set; }
        /// <summary>
        /// Sets the Color of Grid Lines. Value of gridColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string GridColor { get; set; }
        /// <summary>
        /// Strip Lines are vertical or horizontal lines used to highlight/mark a certain region on the plot area. You can choose whether to draw a line at a specific position or shade a region on the plot area. Strip Lines are sometimes referred to as trend lines. 
        /// </summary>
        public ChartStripLine[] StripLines { get; set; }
    }
}