using System;

public class MeetingRoom
{
	public enum MeetingRoomName
	{ 
		Alfa,
		Beta,
		Gamma
	}

	public MeetingRoomName Name { get; set; }
	
	public MeetingRoom (MeetingRoomName name)
	{ 		
		Name = name;
	}