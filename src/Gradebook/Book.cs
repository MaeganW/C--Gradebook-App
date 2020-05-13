using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // normally "this" is implicit, but because "name" is a param, we need to be explicit
        }
        public void addGrade(double grade)
        {
            grades.Add(grade); // "this" in this.grades is implicit
        }

        private List<double> grades; // this is a field on the class/type - cannot be implicitly typed
        private string name; // make fields private for better encapsulation
    }
}