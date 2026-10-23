
//using System;
//using System.Collections.Generic;
//using System.Runtime.ConstrainedExecution;


//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("TAPSIRIQ 1 - KITABXANA SISTEMI");

//        List<Book> books = new List<Book>
//        {
//            new Book("Xemse", "Nizami Gencevi", "101"),
//            new Book("Dan ulduzu", "Mir Celal", "102"),
//            new Book("1984", "George Orwell", "103"),
//            new Book("Balaca Prins", "Antoine de Saint-Exupery", "104"),
//            new Book("Cinayet ve Ceza", "Dostoyevski", "105")
//        };

//        books[0].BorrowBook();
//        books[1].BorrowBook();

//        foreach (Book book in books)
//        {
//            book.ShowInfo();
//        }

//        Console.WriteLine("\nTAPSIRIQ 2 - FIqURLAR SISTEMI");

//        List<IShape> shapes = new List<IShape>
//        {
//            new Circle(5),
//            new Rectangle(4, 6),
//            new Triangle(3, 4, 5)
//        };

//        foreach (IShape shape in shapes)
//        {
//            Console.WriteLine("Sahe: " + shape.CalculateArea().ToString("F2"));
//            Console.WriteLine("Perimetr: " + shape.CalculatePerimeter().ToString("F2"));
//        }

//        Console.WriteLine("Daire sahesi: " + ShapeHelper.CalculateArea(5).ToString("F2"));
//        Console.WriteLine("Duzbucaqli sahesi: " + ShapeHelper.CalculateArea(4, 6));

//        Console.WriteLine("\nTAPSIRIQ 3 - NEQLIYYAT VASITELERI");

//        List<Vehicle> vehicles = new List<Vehicle>
//        {
//            new Car("BMW", 180),
//            new Motorcycle("Yamaha", 120),
//            new Bicycle("Trek", 25)
//        };

//        foreach (Vehicle vehicle in vehicles)
//        {
//            Console.WriteLine("Marka: " + vehicle.Brand);
//            Console.WriteLine("Suret: " + vehicle.Speed);
//            vehicle.MakeSound();
//        }

//        Console.WriteLine("\nTAPSIRIQ 4 - ISCI MAAS SISTEMI");

//        List<Employee> employees = new List<Employee>
//        {
//            new Manager(2000),
//            new Intern(500),
//            new Manager(3000),
//            new Intern(600)
//        };

//        foreach (Employee employee in employees)
//        {
//            Console.WriteLine("Esas maas: " + employee.GetSalary() + " AZN");
//            Console.WriteLine("Bonus: " + employee.CalculateBonus() + " AZN");
//            Console.WriteLine("Umumi maas: " + employee.CalculateTotalSalary() + " AZN");
//            Console.WriteLine();
//        }
//    }
//}
