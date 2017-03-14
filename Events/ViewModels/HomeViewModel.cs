using System;
using System.Collections.ObjectModel;
using Events.Models;
using Events.POCOS;

namespace Events.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		private ObservableCollection<IFeedMember> _feed;
		public ObservableCollection<IFeedMember> Feed
		{
			get
			{
				return _feed;
			}
			set
			{
				_feed = value;
				OnPropertyChanged(nameof(Feed));
			}
		}

		public HomeViewModel()
		{
			Feed = new ObservableCollection<IFeedMember>();
			LoadData();
		}

		private void LoadData()
		{
			//First add the greeting
			//TODO greeting member here
			//Second add the Events feed from your friends
			var poco = new EventsFeedPOCO();
			foreach (var item in poco.EventsInFeed)
			{
				Feed.Add(item);
			}
		}
	}
}
