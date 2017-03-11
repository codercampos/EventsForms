using System;
using Xamarin.Forms;
namespace Events
{
	public class MainTabbedPage : TabbedPage
	{
		public MainTabbedPage()
		{
			Children.Add(new NavigationPage(new HomePage())
			{
				BarTextColor = Color.Black,
				BarBackgroundColor = AppConfig.TabBarColor,
				Icon = "ic_home.png"
			});
			Children.Add(new NavigationPage(new SearchPage())
			{
				BarTextColor = Color.Black,
				BarBackgroundColor = AppConfig.TabBarColor,
				Icon = "ic_search.png"
			});
			Children.Add(new NavigationPage(new CalendarPage())
			{
				BarTextColor = Color.Black,
				BarBackgroundColor = AppConfig.TabBarColor,
				Icon = "ic_calendar.png"
			});
			Children.Add(new NavigationPage(new ProfilePage())
			{
				BarBackgroundColor = AppConfig.TabBarColor,
				Icon = "ic_profile.png"
			});
		}
	}
}
