using System;
using System.Collections.Generic;
using System.IO;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double num);

        public abstract Statistics GetStatistics();
    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
            Name = name;
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double num)
        {
            using (var writeStream = File.AppendText($"./{Name}.txt"))
            {
                writeStream.WriteLine(num);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            using (var readStream = File.OpenText($"./{Name}.txt"))
            {
                var line = readStream.ReadLine();
                while (line != null)
                {
                    var grade = double.Parse(line);
                    statistics.Add(grade);
                    line = readStream.ReadLine();
                    Console.WriteLine($"Line: {line}");
                }
            }
            return statistics;
        }
    }

    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade > 0)
            {
                grades.Add(grade); // "this" in this.grades is implicit
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(50);
                    break;
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.Add(grade);
            }

            return statistics;
        }

        // public string Name // now inheriting from the NamedObject class
        // {
        //     get
        //     {
        //         return name;
        //     }
        //     set
        //     {
        //         if (!String.IsNullOrEmpty(value))
        //         {
        //             name = value;
        //         }
        //         else
        //         {
        //             throw new ArgumentException("Invalid name field value");
        //         }
        //     }
        // }

        // also valid getter setter
        // public string Name
        // {
        //     get;
        //     private set; // this renders Name readonly
        // }

        // private string name; // now inheriting from the NamedObject class

        private List<double> grades; // this is a field on the class/type - cannot be implicitly typed

        // readonly string category = "History";
        public const string CATEGORY = "History";
    }
}