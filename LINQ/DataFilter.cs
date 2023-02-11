using LINQ.Models;

namespace LINQ;

public static class DataFilter
{
    public static int GetUsaStudentsCount()
    {
        var studentsFromUsaCount = College.Students.Where(
            student => student.Country.Equals("USA", StringComparison.OrdinalIgnoreCase));

        return studentsFromUsaCount.Count();
    }

    public static int GetStudentsBetween20And28Count()
    {
        var studentsBetween20And28 = College.Students.Where(student => student.Age is > 20 and < 28);

        return studentsBetween20And28.Count();
    }

    public static List<Student> GetStudentsLearningHistory()
    {
        return College.Students.Where(student => student.Class is "History").ToList();
    }

    public static List<Student> GetStudentsLearningMusicNotInDrumsClass()
    {
        return College.Students.Where(student => student.Class is "Music").Where(student => student.Teacher is not "Mr Drum").ToList();
    }
}