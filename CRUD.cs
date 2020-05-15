using System;
using System.Collections.Generic;
using System.Linq;
using SQL.Models;

namespace SQL
{
    public class CRUD
    {
        public void Create(){
            using(masterContext con = new masterContext()){
                Games game = new Games();
                System.Console.Write("Enter name of game: ");
                game.Name = Console.ReadLine();
                System.Console.Write("Enter amount of players: ");
                game.Players = long.Parse(Console.ReadLine());
                System.Console.Write("Enter mark of this game: ");
                game.Mark = double.Parse(Console.ReadLine());
                con.Add(game);
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
        public void Read(){
            using(masterContext con = new masterContext()){
                List<Games> games = con.Games.ToList();
                foreach(var g in games){
                    System.Console.Write($"{g.Id}.{g.Name}    Players:{g.Players}    ");
                    if(g.Mark < 4){
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Mark: {g.Mark}");                    
                    Console.ForegroundColor = ConsoleColor.White;                        
                    }
                    else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"Mark: {g.Mark}");                    
                    Console.ForegroundColor = ConsoleColor.White;                         
                    }
                }
            }
        }
        public void Update(){
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
        public void Delete(){
            using(masterContext con = new masterContext()){
                System.Console.Write("Enter Id: ");
                int gameId = int.Parse(Console.ReadLine());
                var game = con.Games.Find(gameId);
                if( game != null){
                    con.Games.Remove(game);
                    if(con.SaveChanges() == 0){
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Error! Game wasn't delete");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Game was successfully delete");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}