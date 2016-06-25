using Bridge;
using System;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartStripLine
    {
        /// <summary>
        /// Sets the point where the stripLine has to be plotted or drawn along the axis 
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// stripLine is displayed on top of dataPoints when showOnTop is set to true.
        /// </summary>
        public bool ShowOnTop { get; set; }
        /// <summary>
        /// Sets the Dash Type for stripLine. 
        /// </summary>
        public ChartDashType LineDashType { get; set; }
        /// <summary>
        /// Sets opacity of stripLine.
        /// </summary>
        public double Opacity { get; set; }
        /// <summary>
        /// A custom formatter function that returns stripLine’s label.
        /// </summary>
        public Action<dynamic> LabelFormatter { get; set; }
        /// <summary>
        /// Sets the point where the stripLine’s shaded region begins on the axis. 
        /// </summary>
        public Any<double, int> StartValue { get; set; }
        /// <summary>
        /// Sets the point where the stripLine’s shaded region ends on the x-axis. 
        /// </summary>
        public Any<double, int> EndValue { get; set; }
        /// <summary>
        /// Sets the thickness of the stripLine in pixels. 
        /// </summary>
        public int Thickness { get; set; }
        /// <summary>
        /// Sets the color of the stripLine. 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Sets the label of the stripLine. These are shown on top of axis labels.
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// labelPlacement allows you to place stripline’s Label either inside or outside of plotArea.
        /// </summary>
        public LabelPlacement LabelPlacement { get; set; }
        /// <summary>
        /// labelAlign allows you to place the stripline’s Label far, center or near the axis.
        /// </summary>
        public LabelAlignment LabelAlign { get; set; }
        /// <summary>
        /// Sets the background color of stripLine’s label. 
        /// </summary>
        public string LabelBackgroundColor { get; set; }
        /// <summary>
        /// Setting labelWrap to true wraps the labels at labelMaxWidth. Clips the same when set to false.
        /// </summary>
        public bool LabelWrap { get; set; }
        /// <summary>
        /// labelMaxWidth defines the maximum width of labels after which they get wrapped or clipped depending on labelWrap’s value.
        /// </summary>
        public int LabelMaxWidth { get; set; }
        /// <summary>
        /// Sets the font-family of stripLine’s label. If the first font is not found in the system from the specified font-family list, it tries to use the next font in the list. 
        /// </summary>
        public string LabelFontFamily { get; set; }
        /// <summary>
        /// Sets the font color of label.
        /// </summary>
        public string LabelFontColor { get; set; }
        /// <summary>
        /// Sets the font size of the label in pixels.
        /// </summary>
        public int LabelFontSize { get; set; }
        /// <summary>
        /// Sets the font weight of stripLine’s label.
        /// </summary>
        public ChartFontWeight LabelFontWeight { get; set; }
        /// <summary>
        /// Sets the font style of stripLine’s label. 
        /// </summary>
        public ChartFontStyle LabelFontStyle { get; set; }
    }
}