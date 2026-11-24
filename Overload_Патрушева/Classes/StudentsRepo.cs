using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Патрушева.Classes
{
    public class StudentsRepo
    {
        private List<string> allStudents;
        public StudentsRepo()
        {
            allStudents = new List<string>
            {
                "Патрушева Наталья Сергееван",
                "Соснина Диана Дмитриевна",
                "Кандакова Ангелина Игаревна",
                "Незвестная Дарья Олеговна",
                "Воробьев Леонид Дмитриевич"
            };
        }

        public void AddName(string name)
        {
            allStudents.Add(name);
        }
        public void RemoveName (string name)
        {
            allStudents.Remove(name);
        }

        public void Clear()
        {
            allStudents.Clear();
        }

        public List<string> GetNames()
        {
            return new List<string>(allStudents);
        }

    }
}
