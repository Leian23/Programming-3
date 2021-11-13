using System;

namespace TiimeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Time Keeping System");
            Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");

            Console.Write("To log your time-in enter your employee id:");
            string employeeId = Console.ReadLine();

            TimeSpan timeIn = new TimeSpan(8,40,0);
            Console.WriteLine($"Your login time is recorded: {timeIn}");

             //Date and Time --> DateTime
            //Time only --> TimeSpan

            Console.WriteLine("*********************************");
            Console.Write("To log your time-out enter your employee id:");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(17, 30, 0);
            Console.WriteLine($"Your logout time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;

            Console.WriteLine($"Yout total hours worked is: {totalHours}");

            //-------------------------------------------------------------------

            TimeSpan regularHoursStart = new TimeSpan(8, 30, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0,0,0);
            TimeSpan earlyOut = new TimeSpan(0,0,0);

            if (timeIn > regularHoursStart) 
            {
                lateIn = timeIn - regularHoursStart;
            }

            if (timeOut < regularHoursEnd)
            {
                 earlyOut = timeOut - regularHoursEnd;
            }

            TimeSpan totalRegularHours = totalHours - (lateIn - earlyOut);

            Console.WriteLine($"Your total regular hours worked is: {totalRegularHours}");

            Console.WriteLine("*********************************");

            TimeSpan lunchduration = new TimeSpan(1,0,0);
            TimeSpan EmployeeLunch = new TimeSpan(1,20,0);
            TimeSpan MorningLate = new TimeSpan(0,0,0);
            TimeSpan AfternoonLate = new TimeSpan(0,0,0);
            TimeSpan TotalLate = new TimeSpan(0,0,0);

            if (timeIn > regularHoursStart || EmployeeLunch > lunchduration) {
                 Console.WriteLine("You are late");
                  MorningLate = timeIn - regularHoursStart;
                  Console.WriteLine($"Amount of late in morning time_in: {MorningLate}");    
                  
                  if (EmployeeLunch > lunchduration) {
                      AfternoonLate = EmployeeLunch - lunchduration;
                      Console.WriteLine($"Amount of Late in afternoon time_in: {AfternoonLate}");
             }  
              TotalLate = MorningLate + AfternoonLate;
              Console.WriteLine($"Your total amount of late: {TotalLate}");
            } else {
                Console.WriteLine("You Are not Late");
            }
           
        }
    }
}
