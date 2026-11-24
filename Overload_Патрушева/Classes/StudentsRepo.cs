using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Патрушева.Classes
{
    public class StudentsRepo
    {
        private List<string> AllStudent()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Патрушева", "Наталья", "Сергеевна"));
            allStudent.Add(new Student("Соснина", "Диана", "Дмитриевна"));
            allStudent.Add(new Student("Кандакова", "Ангелина", "Игоревна"));
            allStudent.Add(new Student("Неизвестная", "Дарья", "Олеговна"));
            allStudent.Add(new Student("Павлов", "Алексей", "Михайлович"));
        }

        public string PrintNames()
        {
            
        }
        public string PrintNames(string separator)
        {

        }
        public string PrintNames(char separator)
        {

        }
        public string PrintNames(string separator, bool sort)
        {

        }
        public string PrintNames(string separator, bool sort, bool reverse)
        {

        }
        public string PrintNames(string separator, int maxCount)
        {

        }

    }
}
