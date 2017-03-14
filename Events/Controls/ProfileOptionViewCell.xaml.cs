using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Events.Controls
{
	public partial class ProfileOptionViewCell : ViewCell
	{
		public static BindableProperty IconProperty =
			BindableProperty.Create(nameof(Icon), typeof(string), typeof(ProfileOptionViewCell), string.Empty);
		public string Icon 
		{ 
			get { return (string)GetValue(IconProperty); }
			set { SetValue(IconProperty, value); }
		}

		public static BindableProperty TitleProperty =
			BindableProperty.Create(nameof(Title), typeof(string), typeof(ProfileOptionViewCell), string.Empty);
		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public static BindableProperty SubtitleProperty =
			BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(ProfileOptionViewCell), string.Empty);
		public string Subtitle
		{
			get { return (string)GetValue(SubtitleProperty); }
			set { SetValue(SubtitleProperty, value); }
		}

		public ProfileOptionViewCell()
		{
			InitializeComponent();
		}

		protected override void OnPropertyChanged(string propertyName = null)
		{
			base.OnPropertyChanged(propertyName);
			if (propertyName == IconProperty.PropertyName)
			{
				iconControl.Source = Icon;
			}
			else if (propertyName == TitleProperty.PropertyName)
			{
				titleControl.Text = Title;
			}
			else if (propertyName == SubtitleProperty.PropertyName)
			{
				subtitleControl.Text = Subtitle;
			}
		}
	}
}
