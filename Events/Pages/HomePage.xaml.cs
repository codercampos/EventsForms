using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Events
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			(sender as ListView).SelectedItem = null;
		}
	}
}
