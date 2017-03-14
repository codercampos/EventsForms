namespace Events.Models
{
	public class WeatherGreeting : IFeedMember
	{
		public long Id { get; set; }
		public MemberType Type { get; set; }
		public string CurrentCity { get; set; }
		public string Description { get; set; }
		public string Temperature { get; set; }
		public string Icon { get; set; }
	}
}
