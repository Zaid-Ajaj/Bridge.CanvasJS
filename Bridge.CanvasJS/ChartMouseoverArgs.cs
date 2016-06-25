using Bridge;

namespace Bridge.CanvasJS
{
    public class ChartMouseEventArgs
    {
        public dynamic X { get; set; }
        public dynamic Y { get; set; }
        public dynamic Chart { get; set; }
        public dynamic DatePoint { get; set; }
        public dynamic DateSeries { get; set; }
        public dynamic DatePointIndex { get; set; }
        public dynamic DateSeriesIndex { get; set; }
    }
}