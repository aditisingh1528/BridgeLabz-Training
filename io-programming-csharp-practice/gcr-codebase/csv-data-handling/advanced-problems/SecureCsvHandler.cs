using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public string Email;
    public string Department;
    public double Salary;
}

class SecureCsvHandler
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Email = "amit@gmail.com", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Priya", Email = "priya@gmail.com", Department = "HR", Salary = 40000 }
        };

        WriteEncryptedCsv("employees_secure.csv", employees);
        ReadDecryptedCsv("employees_secure.csv");
    }

    static void WriteEncryptedCsv(string path, List<Employee> employees)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Id,Name,Email,Department,Salary");

            foreach (Employee e in employees)
            {
                string encryptedEmail = Encrypt(e.Email);
                string encryptedSalary = Encrypt(e.Salary.ToString());

                sw.WriteLine($"{e.Id},{e.Name},{encryptedEmail},{e.Department},{encryptedSalary}");
            }
        }
    }

    static void ReadDecryptedCsv(string path)
    {
        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] d = lines[i].Split(',');

            Employee e = new Employee
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Email = Decrypt(d[2]),
                Department = d[3],
                Salary = double.Parse(Decrypt(d[4]))
            };

            Console.WriteLine(
                e.Id + " | " +
                e.Name + " | " +
                e.Email + " | " +
                e.Department + " | " +
                e.Salary
            );
        }
    }

    static string Encrypt(string value)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
    }

    static string Decrypt(string value)
    {
        return Encoding.UTF8.GetString(Convert.FromBase64String(value));
    }
}