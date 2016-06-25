using Bridge;
namespace Bridge.CanvasJS
{
    [Enum(Emit.StringNameLowerCase)]
    public enum ChartIntervalType
    {
        Number,
        Millisecond,
        Second,
        Minute,
        Hour,
        Day, 
        Month, 
        Year
    }
}