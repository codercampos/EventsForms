namespace Events.Models
{
	public interface IFeedMember
	{
		long Id { get; set; }
		MemberType Type { get; set; }
	}
}
