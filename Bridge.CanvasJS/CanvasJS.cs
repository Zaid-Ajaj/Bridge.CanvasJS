using Bridge;

namespace Bridge.CanvasJS
{
    [External]
    [Namespace(false)]
    public static class CanvasJS
    {
        [External]
        public class Chart
        {
            public Chart(string elementId, ChartOptions options)
            {
                return;
            }

            public virtual void Render()
            {
                return;
            }
        }

        public static extern void AddColorSet(string colorSetName, string[] colors);

        public static extern string FormatNumber(float number);

        public static extern string FormatNumber(int number);

        public static extern string FormatNumber(double number);

        public static extern string FormatNumber(decimal number);

        public static extern string FormatNumber(float number, string format);

        public static extern string FormatNumber(int number, string format);

        public static extern string FormatNumber(double number, string format);

        public static extern string FormatNumber(decimal number, string format);

        public static extern string FormatNumber(float number, string format, string culture);

        public static extern string FormatNumber(int number, string format, string culture);

        public static extern string FormatNumber(double number, string format, string culture);

        public static extern string FormatNumber(decimal number, string format, string culture);

        public static extern string FormatDate(Date date);

        public static extern string FormatDate(Date date, string format);

        public static extern string FormatDate(Date date, string format, string culture);
    }
}