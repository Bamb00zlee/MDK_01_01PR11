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

        // вывод имен с разделителем по умолчанию
        public string PrintNames()
        {
            return string.Join(", ", allStudents);
        }

        // вывод имен с указанным разделителем (тип строка)
        public string PrintNames(string separator)
        {
            return PrintNames(separator, false, false);
        }

        // вывод имен с указанным разделителем (тип символ)
        public string PrintNames(char separator)
        {
            return PrintNames(separator.ToString(), false, false);
        }

        // вывод имен с сортировкой
        public string PrintNames(string separator, bool sort)
        {
            return PrintNames(separator, sort, false);
        }

        // с сортировкой и в обратном порядке
        public string PrintNames(string separator, bool sort, bool reverse)
        {
            // проверка что список не пуст
            if (allStudents.Count == 0)
            {
                return "Список пуст";
            }

            // при пустом разделителе
            if (string.IsNullOrEmpty(separator))
            {
                return string.Join(", ", allStudents);
            }

            // получаем список без лишних пробелов
            var students = allStudents.Select(s => s.Trim());

            if (sort)
            {
                students = students.OrderBy(s => s).ToList();
            }

            if (reverse)
            {
                students = students.Reverse();
            }

            return string.Join(separator, students);
        }

        // макс количество
        public string PrintNames(string separator, int maxCount)
        {
            if (maxCount > allStudents.Count)
            {
                return "срез не может быть больше кол-ва студентов ув списке";
            }
            else
            {
                var student = allStudents.Take(maxCount).ToList();
                return string.Join(separator, student);
            }
            
        }


    }
}
