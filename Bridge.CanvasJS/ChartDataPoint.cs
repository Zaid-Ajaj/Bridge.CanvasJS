using Bridge;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartDataPoint
    {
        /// <summary>
        /// Sets the x value. It determines the position of the dataPoint on X Axis, It can be numeric or a dateTime value. Values can be positive or Negative. 
        /// </summary>
        public Any<Date, double, float, int> X { get; set; }
        /// <summary>
        /// Sets the y value of dataPoint. It determines the position of dataPoint on Y Axis. Values can be positive or Negative 
        /// </summary>
        public Any<int, float, double> Y { get; set; }
        /// <summary>
        /// Sets the z value of dataPoint. It is only applicable in case of Bubble chart. This value determines the size of the bubble. 
        /// </summary>
        public int Z { get; set; }
        /// <summary>
        /// Sets the dataPoint Name. dataPoint name is shown in various places like toolTip & legend unless overridden. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Sets the cursor type for dataPoint. 
        /// </summary>
        public string Cursor { get; set; }
        /// <summary>
        /// Sets label value of a dataPoint. The value appears next to the dataPoint on axisX Line. If not provided, it takes x value for label.
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// Enables or Disables highlighting of dataPoint on mouse hover.
        /// </summary>
        public bool HighlightEnabled { get; set; }
        /// <summary>
        /// Sets the Dash Type for indexLabel’s line. It is applicable only for pie and doughnut charts when indexLabelPlacement is set to “outside”. For other chart-types, indexLabelLineThickness should be set greater than zero.
        /// </summary>
        public ChartDashType IndexLabelLineDashType { get; set; }
        /// <summary>
        /// A custom formatter function which returns the text to be displayed as indexLabel on dataPoints.
        /// </summary>
        public Action<dynamic> IndexLabelFormatter { get; set; }
        /// <summary>
        /// Sets the indexLabel of individual dataPoint. indexLabel set here overrides indexLabel set from dataSeries level(if any). “indexLabel” can either be string literal or keyword. keywords are property names mentioned inside curly braces.
        /// </summary>
        public string IndexLabel { get; set; }
        /// <summary>
        /// Using this property you can define whether to render indexLabel “inside” or “outside” the dataPoint.
        /// </summary>
        public LabelPlacement IndexLabelPlacement { get; set; }
        /// <summary>
        /// Using this property you can define whether to render indexLabel “inside” or “outside” the dataPoint
        /// </summary>
        public LabelOrientation IndexLabelOrientation { get; set; }
        /// <summary>
        /// Sets the Background color of Index Labels. The value of indexLabelBackgroundColor can be a “HTML Color Name” or “hex” code. 
        /// </summary>
        public string IndexLabelBackgroundColor { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font color. The value of IndexLabelFontColor can be a “HTML Color Name” or “hex” code . 
        /// </summary>
        public string IndexLabelFontColor { get; set; }
        /// <summary>
        /// indexLabelWrap specifies whether to wrap or clip indexLabel once its width crosses indexLabelMaxWidth. 
        /// </summary>
        public bool IndexLabelWrap { get; set; }
        /// <summary>
        /// indexLabelMaxWidth defines the maximum width of labels after which they get clipped or wrapped depending on indexLabelWrap’s value. 
        /// </summary>
        public int IndexLabelMaxWidth { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Size in pixels. 
        /// </summary>
        public int IndexLabelFontSize { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Style. It can be set to one of the below options. 
        /// </summary>
        public ChartFontStyle IndexLabelFontStyle { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Family. 
        /// </summary>
        public string IndexLabelFontFamily { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Weight. It can be set to one of the below options. 
        /// </summary>
        public ChartFontWeight IndexLabelFontWeight { get; set; }
        /// <summary>
        /// Sets the color of line connecting index labels with their dataPoint. It is only applicable for pie and doughnut chart when indexLabelPlacement is outside. For other chart-types, indexLabelLineThickness should be set greater than zero. The value of indexLineColor can be a “HTML Color Name” or “hex code” or “rgba values” . 
        /// </summary>
        public string IndexLabelLineColor { get; set; }
        /// <summary>
        /// Sets the thickness of line connecting indexLabel with its corresponding dataPoint. It is only applicable when indexLabelPlacement is set to “outside”.
        /// </summary>
        public int IndexLabelLineThickness { get; set; }
        /// <summary>
        /// Default Tooltip can be modified at dataSeries or dataPoint level. You can add content to be displayed in toolTip using toolTipContent. toolTipContent set at dataPoint will override toolTipContent set at dataSeries level.
        /// </summary>
        public string TooltipContent { get; set; }
        /// <summary>
        /// Sets the exploded value of dataPoint. It is applicable only in case of Pie and Doughnut Charts. This property causes the Pie/Doughnut slice to separate out. 
        /// </summary>
        public bool Exploded { get; set; }
        /// <summary>
        /// Sets the color of dataPoint. It overrides the color set at dataSeries level or the one chosen from theme. Value of color can be “HTML Color Name” or “hex” code. 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Sets the color of line for the entire series. This can be overridden at dataPoint level in order to customize the color of line connecting any two dataPoints. The value of lineColor can be a “HTML Color Name” or “hex” code.
        /// </summary>
        public string LineColor { get; set; }
        /// <summary>
        /// Sets the Line Dash Type for all Line Charts
        /// </summary>
        public ChartDashType LineDashType { get; set; }
        /// <summary>
        /// Setting this property to true makes dataPoints to appear in legend.
        /// </summary>
        public bool ShowInLegend { get; set; }
        /// <summary>
        /// Legend text is a textual description of what is represented by each of the dataPoints. The name of dataPoint is taken as a default value, which could be overwritten by custom text by setting this property.
        ///        legendText can also contain keywords inside the string. Keywords are property names mentioned inside curly braces like “{name
        ///    }”, “{x
        ///}: {y}”, etc.legendText can either be string or keywords.keywords are property names mentioned inside curly braces.
        /// </summary>
        public string LegendText { get; set; }
        /// <summary>
        /// Sets the Legend Marker to one of the options below. At dataPoint level, this property works only with Pie and Doughnut charts. 
        /// </summary>
        public MarkerType LegendMarkerType { get; set; }
        /// <summary>
        /// Sets the color of marker that is displayed on legend. This property works only with Pie and Doughnut charts. Value of legendMarkerColor can be “HTML Color Name” or “hex” code. 
        /// </summary>
        public string LegendMarkerColor { get; set; }
        /// <summary>
        /// Sets the border color around legend marker. Value of legendMarkerBorderColor can be “color names” or “hex code” . This property works only with Pie and Doughnut charts. If not set, takes the value from dataSeries’ legendMarkerBorderColor if present. 
        /// </summary>
        public string LegendMarkerBorderColor { get; set; }
        /// <summary>
        /// Sets the thickness of the Legend’s Marker Border in pixels. This property works only with Pie and Doughnut charts. If not set, takes the value from dataSeries’ legendMarkerBorderThickness if present.
        /// </summary>
        public int LegendMarkerBorderThickness { get; set; }
        /// <summary>
        /// Sets marker type to be rendered at each dataPoint. If mentioned at dataSeries, markers set here will take precedence. 
        /// </summary>
        public MarkerType MarkerType { get; set; }

        public string MarkerColor { get; set; }
        /// <summary>
        /// Sets the Size of the marker that is drawn. To display marker in area Chart, set markerSize to a value greater than zero. For line, scatter chart, size it is automatically set unless overridden. 
        /// </summary>
        public int MarkerSize { get; set; }
        /// <summary>
        /// Sets the border color around marker. Value of markerBorderColor can be “HTML Color Name” or “hex” code.
        /// </summary>
        public string MarkerBorderColor { get; set; }
        /// <summary>
        /// Sets the thickness of the Marker’s Border in pixels. 
        /// </summary>
        public int MarkerBorderThickness { get; set; }
        /// <summary>
        /// Sets the click event handler for dataPoint which is triggered when user clicks on a dataPoint . Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Click { get; set; }
        /// <summary>
        /// Sets the mouseover event handler for dataPoint which is triggered when user Mouse Overs on a dataPoint . Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mouseover { get; set; }
        /// <summary>
        /// Sets the mousemove event handler for dataPoint which is triggered when user Moves Mouse on a dataPoint . Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mousemove { get; set; }
        /// <summary>
        /// Sets the mouseout event handler for dataPoint which is triggered when user moves mouse out of a dataPoint . Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mouseout { get; set; }
    }
}