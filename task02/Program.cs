// See https://aka.ms/new-console-template for more information
using System;
class Program {
    static void Main(string[] args) {
        Person Person1 = new Person();
        Person1.Name = "Aditi";
        Person1.Age = 20;
        Person1.Introduce();
        Console.WriteLine();
        
        Person Person2 = new Person();
        Person2.Name = "Srujana";
        Person2.Age = 21; 
        Person2.Introduce();
        Console.WriteLine();
    }
}
