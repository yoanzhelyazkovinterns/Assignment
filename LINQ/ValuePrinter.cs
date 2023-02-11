
namespace LINQ;

public static class ValuePrinter
{
    public static void PrintFilteredData()
    {
        Console.WriteLine($"Students from USA count is: {DataFilter.GetUsaStudentsCount()}{Environment.NewLine}");
        Console.WriteLine($"Students between age of 20 and 28 are: {DataFilter.GetStudentsBetween20And28Count()}{Environment.NewLine}");

        Console.WriteLine("Student names which are learning History:");
        foreach (var student in DataFilter.GetStudentsLearningHistory())
        {
            Console.WriteLine($"{student.Name}");
        }

        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Student names which are learning Music but on Mr Drums class:");
        foreach (var student in DataFilter.GetStudentsLearningMusicNotInDrumsClass())
        {
            Console.WriteLine($"{student.Name}");
        }
    }
}