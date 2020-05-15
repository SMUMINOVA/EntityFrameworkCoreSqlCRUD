using System;
using System.Linq;
using SQL.Models;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD use = new CRUD();
            System.Console.WriteLine("Hello to the world of Games!");
            start :
            System.Console.WriteLine("Menu:\n1.Add new game to list\n2.Update some game\n3.Get information list\n4.Delete game\n5.Exit");
            switch(int.Parse(Console.ReadLine())){
                case 1: use.Create(); goto start;
                case 2: use.Update(); goto start;
                case 3: use.Read(); goto start;
                case 4: use.Delete(); goto start;
                default: System.Console.WriteLine("Bye"); break;
            }
            System.Console.ReadLine();
        }
    }
}
