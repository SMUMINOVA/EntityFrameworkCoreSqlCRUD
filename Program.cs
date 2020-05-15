using System;
using System.Linq;
using SQL.Path;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using(masterContext db = new masterContext()){
                Users u1 = new Users{Name = "Tom", Age = 23};
                Users u2 = new Users{Name = "Alice", Age = 20};
                db.Users.Add(u1);
                db.Users.Add(u2);
                db.SaveChanges();
                System.Console.WriteLine("good job");
                var u = db.Users.ToList();
                foreach(var n in u){
                    System.Console.WriteLine($"{n.Id}.{n.Name} - {n.Age}");
                }
            }
            System.Console.ReadLine();
        }
    }
}
