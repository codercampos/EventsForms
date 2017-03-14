using System;
using System.Globalization;
using Xamarin.Forms;

namespace Events.Helpers
{
	public class FormattedName : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var formattedString = new FormattedString();
			formattedString.Spans.Add(new Span { Text = value.ToString(), FontSize=Device.GetNamedSize(NamedSize.Small, typeof(Label)), FontAttributes = FontAttributes.Bold });
			formattedString.Spans.Add(new Span { Text = " is going to an event", FontSize=Device.GetNamedSize(NamedSize.Small, typeof(Label)) });
			return formattedString;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
