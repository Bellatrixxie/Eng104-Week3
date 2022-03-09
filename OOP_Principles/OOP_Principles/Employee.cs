using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person
{
    private string _department;
    public Employee(string FName, string LName, string Dept) : base(FName, LName)
    {
        _department = Dept;
    }
    public string Department { get => _department; set => _department = value; }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Department: {_department}");
    }

}
