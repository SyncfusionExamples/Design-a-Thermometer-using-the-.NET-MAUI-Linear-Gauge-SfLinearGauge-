using Syncfusion.Maui.Gauges;

namespace Thermometer
{
    public class CelsiusThermometer : SfLinearGauge
    {
        public override List<GaugeLabelInfo> GenerateVisibleLabels()
        {
            List<GaugeLabelInfo> customLabels = new();

            customLabels.Add(new GaugeLabelInfo { Value = -20, Text = "-20" });
            customLabels.Add(new GaugeLabelInfo { Value = -10, Text = "-10" });
            customLabels.Add(new GaugeLabelInfo { Value = 0, Text = "0" });
            customLabels.Add(new GaugeLabelInfo { Value = 10, Text = "10" });
            customLabels.Add(new GaugeLabelInfo { Value = 20, Text = "20" });
            customLabels.Add(new GaugeLabelInfo { Value = 30, Text = "30" });
            customLabels.Add(new GaugeLabelInfo { Value = 40, Text = "40" });
            customLabels.Add(new GaugeLabelInfo { Value = 50, Text = "50" });

            return customLabels;
        }
    }
}