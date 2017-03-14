using System;
using System.Collections.Generic;
using Events.Models;

namespace Events.POCOS
{
	public class EventsPOCO
	{
		public List<Event> Events { get; set; }

		public EventsPOCO()
		{
			Events = new List<Event>
			{
				new Event { Id = 1, Title = "The Magician at Output", City = "Brooklyn, New York", CoverImage = "img_test_md.png", UsersInterested = 2210, EventDate = new DateTime(2017, 4, 25), Venue = "Output" }
			};
		}
	}
}
