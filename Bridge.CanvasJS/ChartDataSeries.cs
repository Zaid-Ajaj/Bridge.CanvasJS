using Bridge;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartDataSeries
    {
        /// <summary>
        /// Sets the dataSeries name. dataSeries name is shown in various places like toolTip & legend unless overridden.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Sets the cursor type for dataSeries.
        /// </summary>
        public string Cursor { get; set; }
        /// <summary>
        /// Sets the visibility of dataSeries. Data Series is visible by default and you can hide the same by setting visible property to false.
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// Sets the type of chart to be rendered for corresponding dataSeries. One can choose from the following options. 
        /// </summary>
        public ChartType Type { get; set; }
        /// <summary>
        /// Setting axisYType lets you choose between primary and secondary Y Axis for a dataSeries to plot against. By choosing “secondary” Axis you can plot the series against axisY2.
        /// In case of Multi-Series or Combinational Charts, one can assign primary axis to some series and secondary axis to other series.
        /// This is helpful when dataSeries objects use different unit of measurement or range of data.By default, all series are plotted against primary Y axis.
        /// </summary>
        public ChartAxisType AxisYType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ChartValueType XValueType { get; set; }
        /// <summary>
        /// Defines how y axis values must be formatted before they appear on the indexLabel or toolTip. You can format numbers and date time values using this property.
        /// </summary>
        public string YValueFormatString { get; set; }
        /// <summary>
        /// Defines how z values is formatted before they appear on the indexLabel or toolTip. You can format numbers using this property.
        /// </summary>
        public string ZValueFormatString { get; set; }
        /// <summary>
        /// Defines how percent values are formatted before they appear on the indexLabel or toolTip. You can format percent values using this property.
        /// </summary>
        public string PercentFormatString { get; set; }
        /// <summary>
        /// Defines how x values must be formatted before they appear on the indexLabel or toolTip. You can format numbers and date time values using this property.
        /// </summary>
        public string XValueFormatString { get; set; }
        /// <summary>
        /// Enables or Disables highlighting of dataPoints on mouse hover.
        /// </summary>
        public bool HighlightEnabled { get; set; }
        /// <summary>
        /// By default, a line breaks wherever a null dataPoint (y = null) is present. You can change this behaviour to draw a line between adjacent non-null dataPoints by setting connectNullData to true.
        /// </summary>
        public bool ConnectNullData { get; set; }
        /// <summary>
        /// Sets the Line Dash Type for all Line and Area Charts.
        /// </summary>
        public ChartDashType LineDashType { get; set; }
        /// <summary>
        /// Sets the Line Dash Type of line wherever null data is present. 
        /// </summary>
        public ChartDashType NullDataLineDashType { get; set; }
        /// <summary>
        /// Sets the Dash Type for indexLabel’s line. It is applicable only for pie and doughnut charts when indexLabelPlacement is set to “outside”. For other chart-types, indexLabelLineThickness should be set greater than zero.
        /// </summary>
        public ChartDashType IndexLabelLineDashType { get; set; }
        /// <summary>
        /// A custom formatter function which returns the text to be displayed as indexLabel on dataPoints.
        /// </summary>
        public Action<dynamic> IndexLabelFormatter { get; set; }
        /// <summary>
        /// Sets the color of dataSeries. The value of tickColor can be a “HTML Color Name” or “Hex Code”. 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Sets the color of line for the entire series. This can be overridden at dataPoint level in order to customize the color of line connecting any two dataPoints. The value of lineColor can be a “HTML Color Name” or “hex” code.
        /// </summary>
        public string LineColor { get; set; }
        /// <summary>
        /// Sets the bevel property, which creates a chiselled effect at the corners of a Column Charts and Bar Charts. 
        /// </summary>
        public bool BevelEnabled { get; set; }
        /// <summary>
        /// Sets opacity of the filled color. 
        /// </summary>
        public float FillOpacity { get; set; }
        /// <summary>
        /// Sets the starting Angle of the Pie or Doughnut Chart in degrees. 
        /// </summary>
        public int StartAngle { get; set; }
        /// <summary>
        /// Sets the default indexLabel for all the dataPoints. This can be overridden by individual dataPoints wherever required. Index Labels are used to show additional information about a dataPoint.
        /// indexLabel can either be string literal or keywords.keywords are property names mentioned inside curly braces.
        /// </summary>
        public string IndexLabel { get; set; }
        /// <summary>
        /// innerRadius property allows you to set a Doughnut chart’s inner radius. Value can either be in pixels (number – ex: 100) or percent (string – ex: “80%”). Percent values are relative to the outer radius of doughnut chart. 
        /// </summary>
        public int InnerRadius { get; set; }
        /// <summary>
        /// radius property allows you to set the Pie/Doughnut chart’s (outer) radius. Value can either be in pixels (number – ex: 100) or percent (string – ex: “80%”). Percent values are relative to the plot area’s size. By default, a pie/doughnut chart’s size(radius) changes in order to best fit the indexLabels. This can lead to charts of different sizes in the same page. In order to override this behavior and set equal sizes to all pie/doughnut charts in a page, you can use radius property. 
        /// </summary>
        public int Radius { get; set; }
        /// <summary>
        /// Using this property you can define whether to render indexLabel “inside” or “outside” the dataPoint. 
        /// </summary>
        public LabelPlacement IndexLabelPlacement { get; set; }
        /// <summary>
        /// Sets the maximum width of indexLabel after which the label gets wrapped or clipped depending on whether indexLabelWrap is set to true (default) or false. 
        /// </summary>
        public int IndexLabelMaxWidth { get; set; }
        /// <summary>
        /// indexLabelWrap specifies whether to wrap or clip indexLabel once its width crosses indexLabelMaxWidth.    
        /// </summary>
        public bool IndexLabelWrap { get; set; }
        /// <summary>
        /// Sets the Orientation of indexLabel to horizontal or vertical. 
        /// </summary>
        public LabelOrientation IndexLabelOrientation { get; set; }
        /// <summary>
        /// Sets the Background color of Index Labels. The value of indexLabelBackgroundColor can be a “HTML Color Name” or “Hex Code”.
        /// </summary>
        public string IndexLabelBackgroundColor { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Style. It can be set to one of the below options. 
        /// </summary>
        public ChartFontStyle IndexLabelFontStyle { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font color. The value of IndexLabelFontColor can be a “HTML Color Name” or “Hex Code”.
        /// </summary>
        public string IndexLabelFontColor { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Size in pixels. 
        /// </summary>
        public int IndexLabelFontSize { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Family.
        /// </summary>
        public string IndexLabelFontFamily { get; set; }
        /// <summary>
        /// Sets the Index Label’s Font Weight.
        /// </summary>
        public ChartFontWeight IndexLabelFontWeight { get; set; }
        /// <summary>
        /// Sets the color of line connecting index labels with their dataPoint. The value of indexLineColor can be a “HTML Color Name” or “hex Code” or “rgba values”.
        /// </summary>
        public string IndexLabelLineColor { get; set; }
        /// <summary>
        /// Sets the thickness of line connecting indexLabel with its corresponding dataPoint. It is only applicable when indexLabelPlacement is “outside”. 
        /// </summary>
        public int IndexLabelLineThickness { get; set; }
        /// <summary>
        /// Default Tooltip can be modified at dataSeries or dataPoint level. You can add content to be displayed in toolTip using toolTipContent. toolTipContent set at dataPoint will override toolTipContent set at dataSeries level.toolTipContent can either be literal string or keywords. You can also use HTML tags. toolTipContent mentioned at dataSeries applies to all dataPoints unless overwritten by toolTipContent at dataPoint level. 
        /// </summary>
        public string TooltipContent { get; set; }
        /// <summary>
        /// Sets the thickness of line in line charts and area charts.
        /// </summary>
        public int LineThickness { get; set; }
        /// <summary>
        /// Sets marker type to be rendered at each dataPoint. While markers are helpful in highlighting individual dataPoints, they do not help much when the dataPoints are crowded. In case of large number of dataPoints it is recommended to disable markers in order to improve the appearance and performance of chart.
        /// Same marker type is also used in legend unless overridden by legendMarkerType property.
        /// </summary>
        public MarkerType MarkerType { get; set; }
        /// <summary>
        /// Sets the color of marker that is displayed on the Chart. Legend Marker for the series uses the same Color as set here unless overridden using legendMarkerColor property. 
        /// </summary>
        public string MarkerColor { get; set; }
        /// <summary>
        /// Sets the Size of the marker that is drawn. To display marker in area Chart, set markerSize to a value greater than zero. For line, scatter chart, size it is automatically set unless overridden. 
        /// </summary>
        public int MarkerSize { get; set; }
        /// <summary>
        /// Sets the border color around marker. Value of markerBorderColor can be “HTML Color Name” or “hex code”. 
        /// </summary>
        public string MarkerBorderColor { get; set; }
        /// <summary>
        /// Sets the thickness of the Marker’s Border in pixels. 
        /// </summary>
        public int MarkerBorderThickness { get; set; }
        /// <summary>
        /// Setting this property to true makes the dataSeries to appear in legend. In case of pie/ doughnut chart, dataPoints of the single series chart appear in legend.
        /// </summary>
        public bool ShowInLegend { get; set; }
        /// <summary>
        /// Sets the text that describes the dataSeries in legend.
        ///        legendText can also contain keywords inside the string. Keywords are property names mentioned inside curly braces like “{name
        ///    }”, “{x
        ///}: {y}”, etc.
        /// </summary>
        public string LegendText { get; set; }
        /// <summary>
        /// Sets the border color around the legend marker. Value of legendMarkerBorderColor can be “color names” or “hex code”. 
        /// </summary>
        public string LegendMarkerBorderColor { get; set; }
        /// <summary>
        /// Sets the thickness of the legend’s Marker Border in pixels. 
        /// </summary>
        public int LegendMarkerBorderThickness { get; set; }
        /// <summary>
        /// Sets the Legend Marker to one of the options below. This property is used to override the default marker in legend, which is same as dataSeries Marker Type. 
        /// </summary>
        public MarkerType LegendMarkerType { get; set; }
        /// <summary>
        /// Enables or disables exploding of Pie/Doughnut segment on click.
        /// </summary>
        public bool ExplodeOnClick { get; set; }
        /// <summary>
        /// Sets the click event handler for dataSeries which is triggered when user clicks on a dataSeries. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Click { get; set; }
        /// <summary>
        /// Sets the color of marker that is displayed on legend. This property overrides default Marker’s Color in Legend, which is same as dataSeries Marker Color. Value of legendMarkerColor can be “HTML Color Name” or “hex code”. 
        /// </summary>
        public string LegendMarkerColor { get; set; }
        /// <summary>
        /// Sets the mouseover event handler for dataSeries which is triggered when user moves Mouse Over a dataSeries. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mouseover { get; set; }
        /// <summary>
        /// Sets the mousemove event handler for dataSeries which is triggered when user Moves mouse on a dataSeries. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mousemove { get; set; }
        /// <summary>
        /// Sets the mouseout event handler for dataSeries which is triggered when user moves mouse out of a dataSeries. Upon event, a parameter that contains event related data is sent to the assigned event handler. Parameter includes dataPoint and dataSeries corresponding to the event. 
        /// </summary>
        public Action<ChartMouseEventArgs> Mouseout { get; set; }
        /// <summary>
        /// In candle Stick chart, when Closing Price is greater than Opening price, the body is filled with white by default and it can be overridden by risingColor property.
        /// </summary>
        public string RisingColor { get; set; }
        public ChartDataPoint[] DataPoints { get; set; }
    }
}