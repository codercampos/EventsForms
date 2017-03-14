namespace Events.Models
{
	public class WeatherGreeting : IFeedMember
	{
		public long Id { get; set; }
		public MemberType Type { get; set; }
		public string CurrentCity { get; set; }
		public string Description { get; set; }
		public double Temperature { get; set; }
		//TODO Make this one work
		public string Icon { get; set; }
	}
}
