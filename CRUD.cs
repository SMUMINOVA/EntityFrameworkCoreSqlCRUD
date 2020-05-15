using System;
using System.Collections.Generic;
using System.Linq;
using SQL.Models;

namespace SQL
{
    public static class CRUD
    {
        public static void Create(){
            using(masterContext con = new masterContext()){
                Games game = new Games();
                System.Console.Write("Enter name of game: ");
                game.Name = Console.ReadLine();
                System.Console.Write("Enter amount of players: ");
                game.Players = long.Parse(Console.ReadLine());
                System.Console.Write("Enter mark of this game: ");
                game.Mark = double.Parse(Console.ReadLine());
                if (con.SaveChanges() > 0){
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"{game.Name} was successfully added");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else{                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Error");                    
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public static void Update(){
            using(masterContext con = new masterContext()){
                System.Console.Write("Enter Id: ");
                int gameId = int.Parse(Console.ReadLine());
                var game = con.Games.Find(gameId);
                if( game != null){
                    System.Console.WriteLine("Enter new Players amount: ");
                    game.Players = long.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter new game's mark: ");
                    game.Mark = double.Parse(Console.ReadLine());
                    if(con.SaveChanges() == 0){
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Error! Game wasn't update");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Game was successfully updated");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}