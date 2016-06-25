using Bridge;
using System;

namespace Bridge.CanvasJS
{
    /// <summary>
    /// Whenever the chart contains multiple dataSeries, it is recommended to represent each dataSeries in a legend. This way it becomes easier for the user to know what exactly is represented by each of the dataSeries. In case of Pie and Doughnut charts, an entry is created for each dataPoint and in rest of the chart types entries are created for each dataSeries. 
    /// </summary>
    [ObjectLiteral]
    public class ChartLegend
    {
        /// <summary>
        /// Sets the cursor type for legend items.
        /// </summary>
        public string Cursor { get; set; }
        /// <summary>
        /// Setting reversed property to true shows legend items in reverse order.
        /// </summary>
        public bool Reversed { get; set; }
        /// <summary>
        /// Sets the maximum width of legend. If any item is longer than the maxWidth, it gets wrapped or clipped depending on the itemWrap property. itemWrap is true by default. Whenever items are stacked horizontally, new items are moved to the next row once maxWidth is reached.
        /// </summary>
        public int MaxWidth { get; set; }
        /// <summary>
        /// Sets the maximum height of legend. Once the maximum height is reached, remaining legend items are not shown when horizontally stacked (while on top or bottom or plotArea) and a new column is created when items are vertically stacked (when displayed to the left or right of plotArea).
        /// </summary>
        public int MaxHeight { get; set; }
        /// <summary>
        /// itemWrap specifies whether to wrap or clip legendText once its width crosses itemMaxWidth / maxWidth.
        /// </summary>
        public bool ItemWrap { get; set; }
        /// <summary>
        /// Sets the maximum width of individual legend items after which they get wrapped or clipped depending on whether itemWrap is set to true (default) or false. itemMaxWidth can’t be greater than maxWidth of legend.
        /// </summary>
        public int ItemMaxWidth { get; set; }
        /// <summary>
        /// Sets the width of individual legend items after which the it gets wrapped or clipped depending on whether itemWrap is set to true (default) or false. itemWidth can’t be greater than itemMaxWidth and maxWidth of legend. 
        /// </summary>
        public int ItemWidth { get; set; }
        /// <summary>
        /// A custom formatter function that returns text to be displayed inside individual legend items.
        /// </summary>
        public Action<dynamic> ItemTextFormatter { get; set; }
        /// <summary>
        /// Sets the margin between marker and text of each item inside legend
        /// </summary>
        public int MarkerMargin { get; set; }
        /// <summary>
        /// When dockInsidePlotArea is set to true, legend renders inside the plot area there by giving more space to plot area.
        /// </summary>
        public bool DockInsidePlotArea { get; set; }
        /// <summary>
        /// Sets the font Size of Legend Text in pixels.
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// Sets the Font Family of Legend Text.
        /// </summary>
        public string FontFamily { get; set; }
        /// <summary>
        /// Sets the font color of Legend Text . The value of fontColor can be a “HTML Color Name” or “hex” code .
        /// </summary>
        public string FontColor { get; set; }
        /// <summary>
        /// Sets the Font Weight of Legend Text
        /// </summary>
        public ChartFontWeight FontWeight { get; set; }
        /// <summary>
        /// Sets the fontStyle of Legend Text.
        /// </summary>
        public ChartFontStyle FontStyle { get; set; }
        /// <summary>
        /// This property lets you align the Legend Position vertically. 
        /// </summary>
        public ChartAlignment VerticalAlign { get; set; }
        /// <summary>
        /// This property lets you align the Legend Position horizontally.
        /// </summary>
        public ChartAlignment HorizontalAlign { get; set; }
        /// <summary>
        /// Sets the mouseover event handler for the legend, which is triggered when the user moves the mouse(input device) over a legend item. After the event is triggered, the event related data is passed as a parameter to the assigned event handler.
        /// </summary>
        [Name("itemmouseover")]
        public Action<dynamic> ItemMouseOver { get; set; }
        /// <summary>
        /// Sets the mousemove event handler for the legend, which is triggered when the user moves the mouse(input device) within a legend item. When the event is triggered, the event related data is passed as a parameter to the assigned event handler.
        /// </summary>
        [Name("itemmousemove")]
        public Action<dynamic> ItemMouseMove { get; set; }
        /// <summary>
        /// Sets the mouseout event handler for the legend, which is triggered when the user moves the mouse pointer outside a legend item. After the event is triggered, the event related data is passed as a parameter to the assigned event handler. 
        /// </summary>
        [Name("itemmouseout")]
        public Action<dynamic> ItemMouseOut { get; set; }
        /// <summary>
        /// Sets the click event handler for the legend, which is triggered when the user clicks on a legend item. After the event is triggered, the event related data is passed as a parameter to the assigned event handler. 
        /// </summary>
        [Name("itemclick")]
        public Action<dynamic> ItemClick { get; set; }

    }
}