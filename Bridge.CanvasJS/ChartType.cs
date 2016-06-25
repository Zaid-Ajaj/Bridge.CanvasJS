using Bridge;

namespace Bridge.CanvasJS
{
    [Enum(Emit.StringName)]
    public enum ChartType
    {
        [Name("line")]
        Line,
        [Name("column")]
        Column,
        [Name("bar")]
        Bar,
        [Name("spline")]
        Spline,
        [Name("splineArea")]
        SplineArea,
        [Name("stepLine")]
        StepLine,
        [Name("scatter")]
        Scatter,
        [Name("bubble")]
        Bubble,
        [Name("pie")]
        Pie,
        [Name("doughnut")]
        Doughnut,
        [Name("stackedColumn")]
        StackedColumn,
        [Name("stackedBar")]
        StackedBar,
        [Name("stackedArea")]
        StackedArea,
        [Name("stackedColumn100")]
        StackedColumn100,
        [Name("stackedBar100")]
        StackedBar100,
        [Name("stackedArea100")]
        StackedArea100,
    }
}