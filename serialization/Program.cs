using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MALLUGOR\source\repos\console app1\ConsoleApp2\ConsoleApp2.txt";
            Employee emp = new Employee(201, "Raghav", 80000);
           FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("File Created Successfully");
            Console.ReadKey();



        
            stream = new FileStream(path, FileMode.OpenOrCreate);
             bf = new BinaryFormatter();
            Employee emp1 = (Employee)bf.Deserialize(stream);
            Console.WriteLine(emp1.empSalary);
            stream.Close();
        }
    }
}