using Bridge;

namespace Bridge.CanvasJS
{
    [Enum(Emit.StringName)]
    public enum ChartValueType
    {
        [Name("number")]
        Number,
        [Name("dateTime")]
        DateTime
    }
}