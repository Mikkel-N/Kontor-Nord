using System;

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