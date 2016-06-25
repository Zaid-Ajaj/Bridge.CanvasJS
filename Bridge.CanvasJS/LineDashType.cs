using Bridge;

namespace Bridge.CanvasJS
{
    [Enum(Emit.StringName)]
    public enum ChartDashType
    {
        [Name("solid")]
        Solid,
        [Name("shortDash")]
        ShortDash,
        [Name("shortDot")]
        ShortDot,
        [Name("shortDashDot")]
        ShortDashDot,
        [Name("shortDashDotDot")]
        ShortDashDotDot,
        [Name("dot")]
        Dot,
        [Name("dash")]
        Dash,
        [Name("dashDot")]
        DashDot,
        [Name("longDash")]
        LongDash,
        [Name("longDashDot")]
        LongDashDot,
        [Name("longDashDotDot")]
        LongDashDotDot
    }
}