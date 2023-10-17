using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Інтерфейс IPerson, который содержит два метода: GetName, возвращающий строку (имя), и GetAge, возвращающий целое число (возраст).
    /// </summary>
    public interface IPerson
    {
        string GetName();
        int GetAge();
    }
}

