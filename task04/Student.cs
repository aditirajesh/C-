using System;

public class Student {
    public string Name {get; set;}
    public char Grade {get; set;}

    public int Age {get; set;}

    public Student(string name, char grade, int age) {
        Name = name;
        Grade = grade;
        Age = age;

    }

    public void StudentInfo() {
        Console.WriteLine($"Name:{Name}, Grade:{Grade}, Age:{Age}");

    }
}