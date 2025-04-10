using System;
using System.Collections.Immutable;


namespace Student_Management{

    class Program {

        static void Main(string[] args) {
            Student Student1 = new Student("Aditi",'A',20);
            Student Student2 = new Student("Srujana",'B',21);
            Student Student3 = new Student("Aakarsh",'F',23);
            Student Student4 = new Student("Arjun",'D',22);
            Student Student5 = new Student("Jessica",'C',20);

            List<Student> students = new List<Student> {Student1,Student2,Student3,Student4,Student5};
            Console.Write("Enter grade to filter students by: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (input.Length>1) {
                Console.WriteLine("Please enter one character for grade - from A to F");
            } else{
                char grade = input[0];
                List<Student> FilteredStudents = FilterStudents(students,grade);
                Console.WriteLine($"Students having grade greater than or equal to {grade}: ");
                DisplayStudents(FilteredStudents);
                Console.WriteLine();

                List<Student> SortedStudents = FilteredStudents.OrderBy(s => s.Name).ToList();
                Console.WriteLine("Sorting Filtered Students according to name: ");
                DisplayStudents(SortedStudents);

            }



        }

        static List<Student> FilterStudents(List<Student> students, char grade) {
            List<Student> FilteredStudents = new List<Student>();
            foreach (Student student in students) {
                if (student.Grade <= grade) {
                    FilteredStudents.Add(student);
                };

            };

            return FilteredStudents;
        }

        static void DisplayStudents(List<Student> students) {
            foreach(Student student in students) {
                student.StudentInfo();
            }
        }
    }
}
