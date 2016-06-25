using Bridge;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartTooltip
    {
        /// <summary>
        /// Enables or Disables the toolTip for the chart. 
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Sets the Font Color of toolTipContent. The value of fontColor can be a “HTML Color Name” or “hex” code.
        /// </summary>
        public string FontColor { get; set; }
        /// <summary>
        /// Sets the Font Style of ToolTip Content. It can be set to one of the below options. 
        /// </summary>
        public ChartFontStyle FontStyle { get; set; }
        /// <summary>
        /// Sets the font Size of ToolTip Content in pixels.
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// Sets the Font Family of ToolTip Content.
        /// </summary>
        public string FontFamily { get; set; }
        /// <summary>
        /// Set the font Weight of ToolTip Content. 
        /// </summary>
        public ChartFontWeight FontWeight { get; set; }
        /// <summary>
        /// Sets the thickness of border around the toolTip in pixels. To display border around toolTip, set the borderThickness to a number greater than zero. Setting it to zero removes the border.
        /// </summary>
        public int BorderThickness { get; set; }
        /// <summary>
        /// Setting a value higher than 0 makes the corners of toolTip rounded. Higher the value, more rounded the corners are.
        /// </summary>
        public int CornerRadius { get; set; }
        /// <summary>
        /// Reverses the order in which items inside toolTip are shown.
        /// </summary>
        public bool Reversed { get; set; }
        /// <summary>
        /// A custom formatter function that returns the content (text/html) to be displayed inside the toolTip.
        /// </summary>
        public Action<dynamic> ContentFormatter { get; set; }
        /// <summary>
        /// Sets the background color of toolTip. Values can be “HTML Color Name” or “hex” code. 
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// In a Multi-Series or a Combination Chart, it is often required to display all values common to x value in a single bubble. Setting shared to true will show in a common bubble all the values of y from each series next to their name. 
        /// </summary>
        public bool Shared { get; set; }
        /// <summary>
        /// toolTip for entire chart can be set by adding content at toolTip object. content can either be HTML or text string. 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// While mouse hovers from one dataPoint to another there is a smooth transition in toolTip. This effect can be controlled by animationEnabled Property. Setting it to false, will disable the animation and toolTip will directly switch from one dataPoint to the other.
        /// </summary>
        public bool AnimationEnabled { get; set; }
        /// <summary>
        /// Sets the border color around Tool Tip. When not set it takes the color of corresponding dataSeries or dataPoint. 
        /// </summary>
        public string BorderColor { get; set; }

    }
}