using System;
using System.Collections.ObjectModel;
using Events.Models;

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
			for (int i = 0; i < 10; i++)
			{
				var model = new EventFeed
				{
					Id = i,
					Type = MemberType.EventInfo,
					UserName = "Carlos Campos",
					PublishDate = DateTime.Now.ToUniversalTime().AddDays(-1),
					Privacy = PrivacyType.Public
				};
			}
		}
	}
}
