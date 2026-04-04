using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Employee
{
    public int id;
    public string name;
    public string department;
    public double salary;
}

class EmployeeSerialization
{
    static void Main(string[] args)
    {
        string filePath = "employees.dat";
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Employee emp = new Employee();

            Console.Write("Enter id: ");
            emp.id = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            emp.name = Console.ReadLine();

            Console.Write("Enter department: ");
            emp.department = Console.ReadLine();

            Console.Write("Enter salary: ");
            emp.salary = double.Parse(Console.ReadLine());

            employees.Add(emp);
        }

        SerializeEmployees(employees, filePath);
        DeserializeEmployees(filePath);
    }

    static void SerializeEmployees(List<Employee> employees, string path)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, employees);
            fs.Close();

            Console.WriteLine("Employees serialized successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
    }

    static void DeserializeEmployees(string path)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            List<Employee> employees = (List<Employee>)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("Deserialized Employees:");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.department + " " + e.salary);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Deserialization error: " + ex.Message);
        }
    }
}
