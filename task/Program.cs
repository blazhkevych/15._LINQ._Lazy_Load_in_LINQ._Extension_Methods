namespace task;

/// <summary>
///     Lazy Load в LINQ. Расширяющие методы.
///     Есть коллекция пользовательских объектов типа Person.
///     public class Person
///     {
///     public string Name { get; set; }
///     public int Age { get; set; }
///     public string City { get; set; }
///     }
///     List
///     <Person>
///         person = new List
///         <Person>
///             ()
///             {
///             new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
///             new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
///             new Person(){ Name = "Oleg", Age = 15, City = "London" },
///             new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
///             new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
///             };
///             1) Выбрать людей, старших 25 лет.
///             2) Выбрать людей, проживающих не в Лондоне.
///             3) Выбрать имена людей, проживающих в Киеве.
///             4) Выбрать людей, старших 35 лет, с именем Sergey.
///             5) Выбрать людей, проживающих в Одессе.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var person = new List<Person>
        {
            new() { Name = "Andrey", Age = 24, City = "Kyiv" },
            new() { Name = "Liza", Age = 18, City = "Odesa" },
            new() { Name = "Oleg", Age = 15, City = "London" },
            new() { Name = "Sergey", Age = 55, City = "Kyiv" },
            new() { Name = "Sergey", Age = 32, City = "Lviv" }
        };

        // Выбрать людей, старших 25 лет.
        var query1 = person.Where(p => p.Age > 25);
        // Вывод в консоль.
        Console.WriteLine("1) Выбрать людей, старших 25 лет.");
        foreach (var item in query1) Console.WriteLine(item.Name);

        // Выбрать людей, проживающих не в Лондоне.
        var query2 = person.Where(p => p.City != "London");
        // Вывод в консоль.
        Console.WriteLine("2) Выбрать людей, проживающих не в Лондоне.");
        foreach (var item in query2) Console.WriteLine(item.Name);

        // Выбрать имена людей, проживающих в Киеве.
        var query3 = person.Where(p => p.City == "Kyiv").Select(p => p.Name);
        // Вывод в консоль.
        Console.WriteLine("3) Выбрать имена людей, проживающих в Киеве.");
        foreach (var item in query3) Console.WriteLine(item);

        // Выбрать людей, старших 35 лет, с именем Sergey.
        var query4 = person.Where(p => p.Age > 35 && p.Name == "Sergey");
        // Вывод в консоль.
        Console.WriteLine("4) Выбрать людей, старших 35 лет, с именем Sergey.");
        foreach (var item in query4) Console.WriteLine(item.Name);

        // Выбрать людей, проживающих в Одессе.
        var query5 = person.Where(p => p.City == "Odesa");
        // Вывод в консоль.
        Console.WriteLine("5) Выбрать людей, проживающих в Одессе.");
        foreach (var item in query5) Console.WriteLine(item.Name);
    }
}