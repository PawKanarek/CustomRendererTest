using CustomRendererTest;
using CustomRendererTest.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer))]
namespace CustomRendererTest.iOS
{
    public class CustomRenderer : ViewRenderer<CustomView, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            //Pattern taken from: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/custom-renderer/view
            if (this.Control == null)
            {
                // Instantiate the native control and assign it to the Control property with
                // the SetNativeControl method
                UIView myView = new UIView();
                this.SetNativeControl(myView);
            }

            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null)
            {
                // Configure the control and subscribe to event handlers
            }
        }
    }
}
