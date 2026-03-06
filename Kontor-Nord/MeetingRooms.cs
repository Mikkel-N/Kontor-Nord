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
		public string Name { get; set; }

		public MeetingRoom(string name)
		{
			Name = name;
		}

        public static List<MeetingRoom> GetMeetingRooms()
        {
			return new List<MeetingRoom>()
			{
				new MeetingRoom("Lokale A"),
				new MeetingRoom("Lokale B"),
				new MeetingRoom("Lokale C")
			};
        }
    }
}