/// <summary>
/// Класс Employee реализует абстрактные методы GetName и GetAge из класса Person, предоставляя конкретную реализацию, 
/// возвращая соответственно имя и возраст сотрудника.
/// </summary>
public class Employee : Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(string id, string name, int age) : base(id)
    {
        Name = name;
        Age = age;
    }

    public override string GetName()
    {
        return Name;
    }

    public override int GetAge()
    {
        return Age;
    }
}


