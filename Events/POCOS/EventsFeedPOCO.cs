using System;
using System.Collections.Generic;
using Events.Models;

namespace Events.POCOS
{
	public class EventsFeedPOCO
	{
		public List<EventFeed> EventsInFeed { get; set; }
		public EventsFeedPOCO()
		{
			//TODO randomize this
			var events = new EventsPOCO();
			EventsInFeed = new List<EventFeed>{
				new EventFeed
				{
					Id = 1001,
					Type = MemberType.EventInfo,
					User = new User
					{
						FullName = "Carlos Campos",
						ProfilePicture = "img_test_profile.jpg"
					},
					PublishDate = DateTime.Now.ToUniversalTime().AddDays(-1),
					Privacy = PrivacyType.Public,
					Event = events.Events[0]
				},
				new EventFeed
				{
					Id = 1002,
					Type = MemberType.EventInfo,
					User = new User
					{
						FullName = "Audrey J. Stemberg",
						ProfilePicture = "img_test_profile.jpg"
					},
					PublishDate = DateTime.Now.ToUniversalTime().AddMinutes(-35),
					Privacy = PrivacyType.Public,
					Event = events.Events[0]
				},
				new EventFeed
				{
					Id = 1003,
					Type = MemberType.EventInfo,
					User = new User
					{
						FullName = "Jeremy Le Van",
						ProfilePicture = "img_test_profile.jpg"
					},
					PublishDate = DateTime.Now.ToUniversalTime().AddHours(-4),
					Privacy = PrivacyType.Public,
					Event = events.Events[0]
				}
			};
		}
	}
}
