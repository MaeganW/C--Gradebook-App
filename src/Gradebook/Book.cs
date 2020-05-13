using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades; // this is a field on the class/type - cannot be implicitly typed
    }
}