using Syncfusion.Maui.Gauges;

namespace Thermometer
{
    public class FahrenheitThermometer : SfLinearGauge
    {
        public override List<GaugeLabelInfo> GenerateVisibleLabels()
        {
            List<GaugeLabelInfo> customLabels = new();

            customLabels.Add(new GaugeLabelInfo { Value = -20, Text = "0" });
            customLabels.Add(new GaugeLabelInfo { Value = -8.5, Text = "20" });
            customLabels.Add(new GaugeLabelInfo { Value = 3, Text = "40" });
            customLabels.Add(new GaugeLabelInfo { Value = 14.5, Text = "60" });
            customLabels.Add(new GaugeLabelInfo { Value = 26, Text = "80" });
            customLabels.Add(new GaugeLabelInfo { Value = 37.5, Text = "100" });
            customLabels.Add(new GaugeLabelInfo { Value = 50, Text = "120" });

            return customLabels;
        }
    }
}