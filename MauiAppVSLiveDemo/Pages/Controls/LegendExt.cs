using Syncfusion.Maui.Toolkit.Charts;

namespace MauiAppVSLiveDemo.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
