using System;
namespace Kontor_Nord
{
	public enum MeetingRoomName
	{
		Alfa,
		Beta,
		Gamma
	}

	public class MeetingRoom
	{
		public MeetingRoomName Name { get; set; }

		public MeetingRoom(MeetingRoomName name)
		{
			Name = name;
		}

	}
}