using System;

namespace DotNetLab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee arhitect = new Arhitect();


            Employee manager = new Manager();
            //Employee employee = new Employee(); pentru abstract e comentata pt ca nu putem instantia.
            Employee employee = new Employee();

            Console.WriteLine(arhitect.Salutation);
            Console.WriteLine(manager.Salutation);
            Console.WriteLine(employee.Salutation);
            //Console.WriteLine(employee.Salutation);  pentru abstract e comentata pt ca nu putem instantia.

            manager.StartDate = DateTime.Now;
            manager.EndDate = DateTime.Now.AddDays(+1);

            Console.WriteLine(manager.IsActive);


            arhitect.StartDate = DateTime.Now;
            arhitect.EndDate = DateTime.Now.AddDays(-111);

            Console.WriteLine(arhitect.IsActive);

            string testString = "    salut ce'   mai\nzici\rmane?\r\nsomething      else";
            //string testString = @"            !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

            Console.WriteLine(testString.ComputeWordsFromSentence().Count);

            Console.WriteLine(string.Join(" ", testString.ComputeWordsFromSentence()));
        }
    }
}
