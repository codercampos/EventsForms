using System;

using CoreGraphics;
using Foundation;
using UIKit;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Events.iOS.Renderers;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(iOSCustomTabbedPage))]

namespace Events.iOS.Renderers
{
	public class iOSCustomTabbedPage : TabbedRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var page = (TabbedPage)Element;

			TabBar.TintColor = AppConfig.AccentColor.ToUIColor();
			TabBar.BarTintColor = AppConfig.TabBarColor.ToUIColor(); 
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			foreach (UIViewController vc in ViewControllers)
			{
				//vc.TabBarItem.SelectedImage = vc.TabBarItem.SelectedImage.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
				vc.TabBarItem.Title = string.Empty;
				vc.TabBarItem.ImageInsets = new UIEdgeInsets(6, 0, -6, 0);
			}
		}
	}
}