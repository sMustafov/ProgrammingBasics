using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Sevgin";
            string lastName = "Mustafov";
            byte age = 20;
            char gender = 'm';
            ulong pIDnum = 8306112507;
            uint UnEmpNum = 27566666;
            Console.WriteLine("First name : {0}",firstName);
            Console.WriteLine("Last name : {0}", lastName);
            Console.WriteLine("Age : {0}",age);
            Console.WriteLine("Gender : {0}",gender );
            Console.WriteLine("Personal ID number : {0}", pIDnum);
            Console.WriteLine("Unique Employee number : {0}", UnEmpNum);
            Console.ReadKey();
            }
    }
}