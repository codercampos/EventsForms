using System;
namespace Events.Models
{
	public class Event
	{
		public long Id { get; set; }
		public string CoverImage { get; set; }
		public DateTime EventDate { get; set; }
		public string Title { get; set; }
		public string Venue { get; set; }
		public string City { get; set; }
		public int UsersInterested { get; set; }

		//Custom properties
		public string FullVenue
		{
			get
			{
				return $"{Venue} • {City}";
			}
		}
		public string InterestedPeople
		{
			get
			{
				return UsersInterested >= 1000 ? $"{(UsersInterested / 1000m):0.#}K people are interested" : InterestedPeople + " people are interested";
			}
		}
	}
}
