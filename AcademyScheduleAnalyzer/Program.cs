using System.Text;
using AcademyScheduleAnalyzer.Benchmarks;
using BenchmarkDotNet.Running;

namespace AcademyScheduleAnalyzer;

class Program
{
    static void Main (string[] args)
    {
// // part 1
//         string[] sessionNames =
//         {
//             "C# Basics",
//             "Arrays",
//             "Functions",
//             "Date and Time",
//             "Exception Handling"
//         };

//         DateTime[] sessionDates =
//         {
//             new DateTime(2026, 9, 10, 18, 0, 0),
//         };

//         int[] sessionDurations =
//         {
//             180,
//             240,
//             180,
//             240,
//             180
//         };

//         // part 5.1
//         int total = GetTotalDuration(sessionDurations);
//         double average = GetAverageDuration(sessionDurations);
//         int shortest = GetShortestDuration(sessionDurations);
//         int longest = GetLongestDuration(sessionDurations);

//         Console.WriteLine($"Total Duration: {total} minutes");
//         Console.WriteLine($"Average Duration: {average} minutes");
//         Console.WriteLine($"Shortest Duration: {shortest} minutes");
//         Console.WriteLine($"Longest Duration: {longest} minutes");

//         // part 5.2
//         DisplaySortedDurations(sessionDurations);

//         // part 7.1
//         int number = 50;

//         Console.WriteLine($"Before: {number}");

//         ChangeValue(ref number);

//         Console.WriteLine($"After: {number}");
//         // part 7.2
//         Console.Write("Enter session: ");
//         string sessionName = Console.ReadLine();

//         if (GetSessionInfo(sessionName, sessionNames, sessionDurations, out int index, out int duration))
//         {
//             Console.WriteLine($"Index: {index}");
//             Console.WriteLine($"Duration: {duration} minutes");
//         }
//         else
//         {
//             Console.WriteLine("Session not found.");
//         }
//         // part 7.3
//         Console.WriteLine($"Before: {sessionDurations[0]}");

//         ChangeArray(sessionDurations);

//         Console.WriteLine($"After: {sessionDurations[0]}");

//         // part 13
//         DisplayDateFormats(sessionDates[0]);

        // while (true)
        // {
        //     Console.WriteLine("===================================");
        //     Console.WriteLine("1. Display all sessions");
        //     Console.WriteLine("2. Search for a session");
        //     Console.WriteLine("3. Sort session names");
        //     Console.WriteLine("4. Reverse session names");
        //     Console.WriteLine("5. Find session index");
        //     Console.WriteLine("6. Check if session exists");
        //     Console.WriteLine("7. Show duration statistics");
        //     Console.WriteLine("8. Show session date details");
        //     Console.WriteLine("9. Show past and upcoming sessions");
        //     Console.WriteLine("10. Find next session");
        //     Console.WriteLine("11. Compare two session dates");
        //     Console.WriteLine("12. Read and validate a custom date");
        //     Console.WriteLine("13. Select session by index");
        //     Console.WriteLine("14. Validate session duration");
        //     Console.WriteLine("15. Generate report using string");
        //     Console.WriteLine("16. Generate report using StringBuilder");
        //     Console.WriteLine("0. Exit");
        //     Console.WriteLine("===================================");

        //     int option = ReadMenuOption();

        //     switch (option)
        //     {
        //         case 1:
        //             DisplaySessions(sessionNames, sessionDates, sessionDurations);
        //             break;


        //         case 2:
        //             SearchSession(sessionNames, sessionDates, sessionDurations);
        //             break;


        //         case 3:
        //             SortSessionNames(sessionNames);
        //             break;


        //         case 4:
        //             ReverseSessionNames(sessionNames);
        //             break;


        //         case 5:
        //             FindSessionIndex(sessionNames);
        //             break;


        //         case 6:
        //             CheckSessionExists(sessionNames);
        //             break;


        //         case 7:

        //             int total = GetTotalDuration(sessionDurations);

        //             double average = GetAverageDuration(sessionDurations);

        //             int shortest = GetShortestDuration(sessionDurations);

        //             int longest = GetLongestDuration(sessionDurations);

        //             Console.WriteLine($"Total Duration: {total} minutes");

        //             Console.WriteLine($"Average Duration: {average} minutes");

        //             Console.WriteLine($"Shortest Duration: {shortest} minutes");

        //             Console.WriteLine($"Longest Duration: {longest} minutes");

        //             Console.WriteLine();
        //             Console.WriteLine("Sorted Durations:");

        //             DisplaySortedDurations(sessionDurations);
        //             break;


        //         case 8:

        //             Console.Write("Enter session name: ");

        //             string detailsName = Console.ReadLine();

        //             int detailsIndex = Array.IndexOf(sessionNames, detailsName);

        //             if (detailsIndex == -1)
        //             {
        //                 Console.WriteLine("Session not found.");
        //                 break;
        //             }

        //             DisplaySessionDetails(sessionNames[detailsIndex], sessionDates[detailsIndex], sessionDurations[detailsIndex]);
        //             break;


        //         case 9:

        //             DisplaySessionStatuses(sessionNames, sessionDates);
        //             break;


        //         case 10:

        //             FindNextSession(sessionNames, sessionDates, sessionDurations);
        //             break;


        //         case 11:

        //             CompareSessionDates(sessionNames, sessionDates);
        //             break;


        //         case 12:

        //             DateTime customDate = ReadSessionDate();

        //             Console.WriteLine($"Valid Date: {customDate:dd/MM/yyyy hh:mm tt}");

        //             break;


        //         case 13:

        //             SelectSessionByIndex(sessionNames);

        //             break;


        //         case 14:

        //             Console.Write("Enter duration: ");

        //             int duration = int.Parse(Console.ReadLine());

        //             try
        //             {
        //                 ValidateDuration(duration);
        //             }
        //             catch (ArgumentException ex)
        //             {
        //                 Console.WriteLine(ex.Message);
        //             }

        //             break;


        //         case 15:

        //             string stringReport = BuildReportUsingString(sessionNames, sessionDates, sessionDurations);

        //             Console.WriteLine(stringReport);

        //             break;


        //         case 16:

        //             string stringBuilderReport = BuildReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);

        //             Console.WriteLine(stringBuilderReport);

        //             break;


        //         case 0:

        //             Console.WriteLine("Exiting Academy Schedule Analyzer...");
        //             return;


        //         default:

        //             Console.WriteLine("Invalid option. Please choose a valid option.");

        //             break;
        //     }
        // }
// 

        BenchmarkRunner.Run<StringBenchmark>();

// --------------
    }

// part 2

    static void DisplaySessions(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        for (int i = 0; i < sessionNames.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sessionNames[i]}");
            Console.WriteLine($"Date: {sessionDates[i]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {sessionDates[i]:hh:mm tt}");
            Console.WriteLine($"Duration: {sessionDurations[i]} minutes");
            Console.WriteLine();
        }
    }

// part 3 

    static void SearchSession(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        Console.Write("Enter session name: ");
        string searchName = Console.ReadLine();

        int index = Array.IndexOf(sessionNames, searchName);

        if (index == -1)
        {
            Console.WriteLine("Session not found.");
            return;
        }

        Console.WriteLine($"Name: {sessionNames[index]}");
        Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
        Console.WriteLine($"Start Time: {sessionDates[index]:hh:mm tt}");
        Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
    }

// part 4.1

    static void SortSessionNames(string[] sessionNames)
    {
        string[] copiedNames = new string[sessionNames.Length];

        Array.Copy(sessionNames, copiedNames, sessionNames.Length);

        Array.Sort(copiedNames);

        foreach (string name in copiedNames)
        {
            Console.WriteLine(name);
        }
    }

// part 4.2

    static void ReverseSessionNames(string[] sessionNames)
    {
        string[] copiedNames = new string[sessionNames.Length];

        Array.Copy(sessionNames, copiedNames, sessionNames.Length);

        Array.Reverse(copiedNames);

        foreach (string name in copiedNames)
        {
            Console.WriteLine(name);
        }
    }

// part 4.3

    static void FindSessionIndex(string[] sessionNames)
    {
        Console.Write("Enter session name: ");
        string searchName = Console.ReadLine();

        int index = Array.IndexOf(sessionNames, searchName);

        Console.WriteLine($"Index: {index}");
    }

// part 4.4

    static void CheckSessionExists(string[] sessionNames)
    {
        Console.Write("Enter session name: ");
        string searchName = Console.ReadLine();

        bool exists = Array.Exists(sessionNames, name => name == searchName);

        if (exists)
        {
            Console.WriteLine("Session exists.");
        }
        else
        {
            Console.WriteLine("Session does not exist.");
        }
    }

// part 4.5

    static void FindSession(string[] sessionNames)
    {
        string result = Array.Find( sessionNames, name => name == "Functions");

        Console.WriteLine(result);
    }

// part 4.6

    static void FindSessionIndexUsingCondition(string[] sessionNames)
    {
        int index = Array.FindIndex(sessionNames, name => name == "Functions");

        Console.WriteLine($"Index: {index}");
    }

// part 4.7

    static void CopyArray(string[] sessionNames)
    {
        string[] copiedNames = new string[sessionNames.Length];

        Array.Copy(sessionNames, copiedNames, sessionNames.Length);

        copiedNames[0] = "Changed Session";

        Console.WriteLine("Original array:");

        foreach (string name in sessionNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nCopied array:");

        foreach (string name in copiedNames)
        {
            Console.WriteLine(name);
        }
    }

// part 5.1

    static int GetTotalDuration(int[] durations)
    {
        int total = 0;

        for (int i = 0; i < durations.Length; i++)
        {
            total += durations[i];
        }

        return total;
    }

// 5.2

    static double GetAverageDuration(int[] durations)
    {
        int total = GetTotalDuration(durations);

        return (double)total / durations.Length;
    }

// 5.3

    static int GetShortestDuration(int[] durations)
    {
        int shortest = durations[0];

        for (int i = 1; i < durations.Length; i++)
        {
            if (durations[i] < shortest)
            {
                shortest = durations[i];
            }
        }

        return shortest;
    }

// 5.4

    static int GetLongestDuration(int[] durations)
    {
        int longest = durations[0];

        for (int i = 1; i < durations.Length; i++)
        {
            if (durations[i] > longest)
            {
                longest = durations[i];
            }
        }

        return longest;
    }

// 5.5

    static void DisplaySortedDurations(int[] durations)
    {
        int[] copiedDurations = new int[durations.Length];

        Array.Copy(durations, copiedDurations, durations.Length);

        Array.Sort(copiedDurations);

        foreach (int duration in copiedDurations)
        {
            Console.WriteLine($"{duration} minutes");
        }
    }


// part 6.8

    static DateTime GetSessionEndTime(DateTime startTime, int duration)
    {
        return startTime.AddMinutes(duration);
    }

// part 6.10

    static string BuildReportUsingString(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        string result = "";

        for (int i = 0; i < sessionNames.Length; i++)
        {
            result += $"{sessionNames[i]} - " + $"{sessionDates[i]:dd/MM/yyyy hh:mm tt} - " + $"{sessionDurations[i]} minutes\n";
        }

        return result;
    }

// part 6.11

static string BuildReportUsingStringBuilder(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sessionNames.Length; i++)
        {
            result.AppendLine( $"{sessionNames[i]} - " + $"{sessionDates[i]:dd/MM/yyyy hh:mm tt} - " + $"{sessionDurations[i]} minutes");
        }

        return result.ToString();
    }

// part 7.1

    static void ChangeValue(ref int number)
    {
        number = 100;
    }

// part 7.2

    static bool GetSessionInfo(string sessionName, string[] sessionNames, int[] sessionDurations, out int index, out int duration)
    {
        index = Array.IndexOf(sessionNames, sessionName);

        if (index == -1)
        {
            duration = 0;
            return false;
        }

        duration = sessionDurations[index];

        return true;
    }

// part 7.3

    static void ChangeArray(int[] values)
    {
        values[0] = 999;
    }

// part 8

    static int CalculateTotalDuration(params int[] durations)
    {
        int total = 0;

        foreach (int duration in durations)
        {
            total += duration;
        }

        return total;
    }

// part 9

    static void DisplaySessionDetails(
        string name,
        DateTime date,
        int duration)
    {
        DateTime endTime = date.AddMinutes(duration);

        Console.WriteLine($"Session: {name}");
        Console.WriteLine($"Date: {date:dd MMMM yyyy}");
        Console.WriteLine($"Day: {date.DayOfWeek}");
        Console.WriteLine($"Year: {date.Year}");
        Console.WriteLine($"Month: {date.Month}");
        Console.WriteLine($"Day Number: {date.Day}");
        Console.WriteLine($"Start Time: {date:hh:mm tt}");
        Console.WriteLine($"Duration: {duration} minutes");
        Console.WriteLine($"End Time: {endTime:hh:mm tt}");
    }

// part 10

    static void CompareSessionDates(string[] sessionNames, DateTime[] sessionDates)
    {
        Console.Write("Enter first session: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter second session: ");
        string secondName = Console.ReadLine();

        int firstIndex = Array.IndexOf(sessionNames, firstName);
        int secondIndex = Array.IndexOf(sessionNames, secondName);

        if (firstIndex == -1 || secondIndex == -1)
        {
            Console.WriteLine("Session not found.");
            return;
        }

        DateTime firstDate = sessionDates[firstIndex];
        DateTime secondDate = sessionDates[secondIndex];

        TimeSpan difference = secondDate - firstDate;

        Console.WriteLine($"Difference:");
        Console.WriteLine($"{difference.TotalDays} days");
        Console.WriteLine($"{difference.TotalHours} hours");
    }

// part 11

    static void DisplaySessionStatuses(
    string[] sessionNames,
    DateTime[] sessionDates)
    {
        for (int i = 0; i < sessionNames.Length; i++)
        {
            if (sessionDates[i] < DateTime.Now)
            {
                Console.WriteLine($"{sessionNames[i]} Past");
            }
            else
            {
                Console.WriteLine($"{sessionNames[i]} Upcoming");
            }
        }
    }

// part 12

    static void FindNextSession(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        DateTime nearestDate = DateTime.MaxValue;
        int nearestIndex = -1;

        for (int i = 0; i < sessionDates.Length; i++)
        {
            if (sessionDates[i] > DateTime.Now && sessionDates[i] < nearestDate)
            {
                nearestDate = sessionDates[i];
                nearestIndex = i;
            }
        }

        if (nearestIndex == -1)
        {
            Console.WriteLine("No upcoming sessions.");
            return;
        }

        TimeSpan remainingTime = nearestDate - DateTime.Now;

        Console.WriteLine("Next Session:");
        Console.WriteLine(sessionNames[nearestIndex]);
        Console.WriteLine($"Date: {nearestDate:dd MMMM yyyy}");
        Console.WriteLine($"Start Time: {nearestDate:hh:mm tt}");
        Console.WriteLine($"Remaining Days: {remainingTime.Days}");
        Console.WriteLine($"Remaining Hours: {remainingTime.Hours}");
    }

// part 13

    static void DisplayDateFormats(DateTime date)
    {
        Console.WriteLine(date.ToString("yyyy-MM-dd"));
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("dd MMMM yyyy"));
        Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine(date.ToString("hh:mm tt"));
    }

// part 14

    static DateTime ReadSessionDate()
    {
        while (true)
        {
            Console.Write("Enter date (yyyy-MM-dd HH:mm): ");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                return result;
            }

            Console.WriteLine("Invalid date. Try again.");
        }
    }

// part 15

    // static int ReadMenuOption()
    // {
    //     while (true)
    //     {
    //         Console.Write("Choose an option: ");

    //         try
    //         {
    //             int option = int.Parse(Console.ReadLine());

    //             return option;
    //         }
    //         catch (FormatException)
    //         {
    //             Console.WriteLine("Invalid menu option. Enter a number.");
    //         }
    //     }
    // }

// part 16

    static void SelectSessionByIndex(string[] sessionNames)
    {
        Console.Write("Enter session index: ");

        int index = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine($"Session: {sessionNames[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine(
                "The selected session index is out of range."
            );
        }
    }

// part 17

    static void ValidateDuration(int duration)
    {
        if (duration <= 0)
        {
            throw new ArgumentException("Duration must be greater than zero.");
        }

        Console.WriteLine("Duration accepted.");
    }

// part 18

    static int ReadMenuOption()
    {
        while (true)
        {
            Console.Write("Choose an option: ");

            try
            {
                int option = int.Parse(Console.ReadLine());
                return option;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid menu option. Enter a number.");
            }
            finally
            {
                Console.WriteLine("Input operation finished.");
            }
        }
    }  
    
}