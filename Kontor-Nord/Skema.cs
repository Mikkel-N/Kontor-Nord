using System;
using System.Collections.Generic;
using System.Text;

namespace Kontor_Nord
{
    internal class Skema
    {
        // Creates an empty list of reservations to hold the reservations that will be made by the user
        public List<Reservation> reservations = new List<Reservation>();

        // Array for the possible times and dates.
        int[] times = { 9, 10, 11, 12, 13, 14, 15 };
        DayOfWeek[] days =
        {
            DayOfWeek.Monday, 
            DayOfWeek.Tuesday, 
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday, 
            DayOfWeek.Friday
        };

        // Used to make "fake" reservations for demonstration purposes.
        public void AlreadyOccupiedTimes(List<EmployeeName> EmployeeNames, List)
        {

        }
        public void ShowCalendar()
        {
        }
    };

}
