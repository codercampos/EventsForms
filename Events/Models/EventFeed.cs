using System;
namespace Events.Models
{
	public class EventFeed : IFeedMember
	{
		public long Id { get; set; }
		public MemberType Type { get; set; }
		public User User { get; set; }
		public DateTime PublishDate { get; set; }
		public PrivacyType Privacy { get; set; }
		public Event Event { get; set; }

		//Custom properties as helpers

		/// <summary>
		/// Gets the publish date with custom title depending when the user have accepted or shown interest on a event
		/// </summary>
		/// <value>The publish date with a custom title</value>
		public string PublishDateString
		{
			get
			{
				var daysPassed = DateTime.UtcNow - PublishDate.ToUniversalTime();
				if (daysPassed.Days < 1)
				{
					return $"Today at {PublishDate.ToLocalTime().ToString("hh:mm tt")}";
				}
				else if (daysPassed.Days >= 1 && daysPassed.Days < 2)
				{
					return $"Yesterday at {PublishDate.ToLocalTime().ToString("hh:mm tt")}";
				}
				else
				{
					return PublishDate.ToLocalTime().ToString("MMM dd, yyyy");
				}
			}
		}
	}
}
