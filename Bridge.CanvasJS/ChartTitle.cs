using Bridge;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartTitle
    {
        /// <summary>
        /// Sets the Title’s text.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Wrap specifies whether to wrap the title once its width crosses maxWidth or not. If it is set to false, title gets clipped after reaching maxWidth
        /// </summary>
        public bool Wrap { get; set; }
        /// <summary>
        /// Sets the maximum width of title after which it gets wrapped or clipped depending on whether wrap is set to true (default) or false. 
        /// </summary>
        public int MaxWidth { get; set; }
        /// <summary>
        /// When dockInsidePlotArea is set to true, title renders inside the plot area there by giving more space to plot area. 
        /// </summary>
        public bool DockInsidePlotArea { get; set; }
        /// <summary>
        /// This property lets you align the Chart Title vertically. 
        /// </summary>
        public ChartAlignment VerticalAlign { get; set; }
        /// <summary>
        /// This property lets you align the Chart Title horizontally. 
        /// </summary>
        public ChartAlignment HorizontalAlign { get; set; }
        /// <summary>
        /// Sets the font Size of Chart Title in pixels. 
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// Sets the Font Family of Chart Title. 
        /// </summary>
        public string FontFamily { get; set; }
        /// <summary>
        /// Sets the Font Weight used in the Chart Title.
        /// </summary>
        public ChartFontWeight FontWeight { get; set; }
        /// <summary>
        /// Sets the font color of Chart Title. The value of fontColor can be an HTMLColor Name or a hex code .
        /// </summary>
        public string FontColor { get; set; }
        /// <summary>
        /// Sets the fontStyle of Chart Title. fontStyle can be set to one of the below options.
        /// </summary>
        public ChartFontStyle FontStyle { get; set; }
        /// <summary>
        /// Sets the thickness of border around the Title in pixels. To display border around title, set the borderThickness to a number greater than zero.
        /// </summary>
        public int BorderThickness { get; set; }
        /// <summary>
        /// To display rounded borders around the title, set the cornerRadius of title. Higher the value, more rounded are the corners.
        /// </summary>
        public int CornerRadius { get; set; }
        /// <summary>
        /// Sets the color of border around Chart Title. Values of borderColor can be an HTMLColor Name or code . 
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// Sets the background color of Chart Title. Values can be “HTML Color Name” or “hex” code. 
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// This property lets you set margin between Title & PlotArea.
        /// </summary>
        public int Margin { get; set; }
        /// <summary>
        /// This property allows you to set the padding for Chart Title 
        /// </summary>
        public int Padding { get; set; }
    }
}
