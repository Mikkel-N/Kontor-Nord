using System;
namespace Kontor_Nord
{
	public class Reservation
	{
		public Employee Employee { get; }
		public MeetingRoom MeetingRoom { get; }
		public DateTime StartTime {  get; set; }
		public DateTime EndTime { get; set; }
		public double Duration { get; set; }

		public Reservation(Employee employee, MeetingRoom meetingRoom, DateTime startTime, DateTime endTime)
		{
			Employee = employee;
			MeetingRoom = meetingRoom;
			StartTime = startTime;
			EndTime = endTime;
			Duration = (EndTime - StartTime).TotalHours;
		}




	}
}