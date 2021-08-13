using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunaProje
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Student()
        {

        }

        public Student(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public override string ToString()
        {
            return $"{Id}  {FullName}";
        }

    }
}
