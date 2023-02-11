using LINQ.Models;

namespace LINQ;

public static class College
{
    public static List<Student> Students { get; } = new()
    {
        new Student {Name = "John Smith", Age = 21, Country = "USA", Class = "Math", Teacher = "Mr Nerd"},
        new Student {Name = "Ian Gillan", Age = 28, Country = "UK", Class = "History", Teacher = "Mr Zeus"},
        new Student {Name = "Lisa Simpson", Age = 17, Country = "Usa", Class = "Music", Teacher = "Mrs Melody"},
        new Student {Name = "Marian Popovich", Age = 24, Country = "Poland", Class = "Economics", Teacher = "MrWolf"},
        new Student {Name = "John Doe", Age = 20, Country = "Brazil", Class = "Dance", Teacher = "Mr Awesome"},
        new Student {Name = "Billie Jin", Age = 21, Country = "Ireland", Class = "Music", Teacher = "Mrs Melody"},
        new Student {Name = "Will Smith", Age = 22, Country = "USA", Class = "Drama", Teacher = "Mr Spilberg"},
        new Student {Name = "Alex Ivanov", Age = 21, Country = "Ukraine", Class = "Math", Teacher = "Mr Nerd"},
        new Student {Name = "Lily Chan", Age = 21, Country = "China", Class = "Chemistry", Teacher = "Mrs Acid"},
        new Student {Name = "Bibi Nat", Age = 29, Country = "Israel", Class = "History", Teacher = "Mr Zeus"},
        new Student {Name = "Bobby Brown", Age = 21, Country = "UsA", Class = "Music", Teacher = "Mr Drum"},
        new Student {Name = "Angie Richards", Age = 20, Country = "USa", Class = "Music", Teacher = "Mr Drum"}
    };
}