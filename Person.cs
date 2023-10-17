using Lab6;
/// <summary>
/// Абстрактный класс Person, который реализует интерфейс IPerson. 
/// Класс имеет поле Id, которое является только для чтения (readonly) и конструктор, который принимает id и инициализирует поле Id. 
/// Кроме того, класс содержит абстрактные методы GetName и GetAge
/// </summary>
public abstract class Person : IPerson
{
    public readonly string Id;

    public Person(string id)
    {
        Id = id;
    }

    public abstract string GetName();
    public abstract int GetAge();

    public override string ToString()
    {
        return $"ID: {Id}, Name: {GetName()}, Age: {GetAge()}";
    }
}
