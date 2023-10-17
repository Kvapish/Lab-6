using Lab6;
using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Создаем массив объектов различных классов, осуществляем добавление, редактирование и удаление элементов, а затем выводим информацию о людях в массиве на экран. 
    /// </summary>
    static void Main()
    {
        List<IPerson> people = new List<IPerson>();

        // Добавление объектов в массив
        people.Add(new Employee("1", "Александр", 30));
        people.Add(new Employee("2", "Дмитрий", 25));

        // Вывод содержимого массива
        Console.WriteLine("Люди в массиве:");
        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }

        // Редактирование элемента массива
        Employee employeeToUpdate = (Employee)people[0];
        employeeToUpdate.Name = "Обновленный Александр";
        employeeToUpdate.Age = 31;

        // Вывод обновленного содержимого массива
        Console.WriteLine("\nОбновленные люди в массиве:");
        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }

        // Удаление элемента из массива
        people.RemoveAt(1);

        // Вывод обновленного содержимого массива после удаления
        Console.WriteLine("\nЛюди в массиве после удаления:");
        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }
        Console.ReadLine();
    }
}
