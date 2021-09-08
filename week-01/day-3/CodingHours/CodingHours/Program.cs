using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            double dailyCodingHours = 6;

            // The semester is 17 weeks long
            double semesterWeeks = 17;

            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            double weeklyCodingDays = 5;
            double semesterCodingHoursPerAttendee = (dailyCodingHours * weeklyCodingDays) * semesterWeeks;

            Console.WriteLine(semesterCodingHoursPerAttendee);

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double weeklyWorkingHours = 52;


            double percentageOfCodingHoursInSemester = (100 / weeklyWorkingHours) * (dailyCodingHours * weeklyCodingDays);

            Console.WriteLine(percentageOfCodingHoursInSemester);
        }
    }
}
