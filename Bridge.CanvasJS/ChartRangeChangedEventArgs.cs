using Bridge;

namespace Bridge.CanvasJS
{
    [ObjectLiteral]
    public class ChartRangeChangedEventArgs
    {
        public string Type { get; set; }
        public ZoomEventType Zoom { get; set; } 
        public dynamic Chart { get; set; }

        [Name("axisX.viewportMinimum")]
        public dynamic XAxisViewportMinimum { get; set; }
        [Name("axisX.viewportMaximum")]
        public dynamic XAxisViewportMaximum { get; set; }

        [Name("axisY.viewportMinimum")]
        public dynamic YAxisViewportMinimum { get; set; }
        [Name("axisY.viewportMaximum")]
        public dynamic YAxisViewportMaximum { get; set; }

        [Name("axisY2.viewportMaximum")]
        public dynamic Y2AxisViewportMinimum { get; set; }
        [Name("axisY2.viewportMinimum")]
        public dynamic Y2AxisViewportMaximum { get; set; }
    }
}
