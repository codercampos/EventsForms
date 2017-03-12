using System;
namespace Events.Models
{
	public class Event
	{
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
	}
}
