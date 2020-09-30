using JobToApp.UWP.Utility.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ImageButton), typeof(CustomImageButtonRenderer))]
namespace JobToApp.UWP.Utility.Controls
{
    public class CustomImageButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var style = Windows.UI.Xaml.Application.Current.Resources["ImageButtonStyle"] as Windows.UI.Xaml.Style;
                Control.Style = style;
            }
        }
    }
}
