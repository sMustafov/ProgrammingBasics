using System;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            string softUni = "Software University";
            string address = "26 V. Kanchev, Sofia";
            long num = 359899555592;
            int? fax = null;
            string web = "http://softuni.bg";
            string fName = "Svetlin";
            string lName = "Nakov";
            int age = 25;
            uint tel = 3592981981;
            Console.WriteLine("{0}",softUni);
            Console.WriteLine("Address : {0}", address);
            Console.WriteLine("Tel. +{0}",num);
            Console.WriteLine("Fax : {0}",fax);
            Console.WriteLine("Web site : {0}", web);
            Console.WriteLine("Manager : {0} {1} (age:\n{2}, tel. +{3})", fName, lName, age, tel);
            Console.ReadKey();

        }
    }
}
