namespace task
{
    /// <summary>
    /// Lazy Load в LINQ. Расширяющие методы.
    /// 
    /// Есть коллекция пользовательских объектов типа Person.
    /// 
    /// public class Person
    /// {
    ///     public string Name { get; set; }
    ///     public int Age { get; set; }
    ///     public string City { get; set; }
    /// }
    /// List&lt;Person&gt; person = new List&lt;Person&gt;()
    /// {
    ///     new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
    ///     new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
    ///     new Person(){ Name = "Oleg", Age = 15, City = "London" },
    ///     new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
    ///     new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
    /// };
    /// 
    ///         1) Выбрать людей, старших 25 лет.
    ///         2) Выбрать людей, проживающих не в Лондоне.
    ///         3) Выбрать имена людей, проживающих в Киеве.
    ///         4) Выбрать людей, старших 35 лет, с именем Sergey.
    ///         5) Выбрать людей, проживающих в Одессе. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}