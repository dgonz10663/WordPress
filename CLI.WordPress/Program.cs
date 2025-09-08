using System;
using Library.WordPress.Models;

namespace CLI.WordPress
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WordPress!");
            List<string?> blogPosts = new List<string?>();

            do
            {
                Console.WriteLine("C. Create a Blog Post");
                Console.WriteLine("R. List a Blog Post");
                Console.WriteLine("U. Update a Blog Post");
                Console.WriteLine("D. Delete a Blog Post");
                Console.WriteLine("Q. Quit");

                string? userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "C":
                    case "c":
                        blogPosts.Add(Console.ReadLine() ?? string.Empty);
                        break;
                    case "R":
                    case "r":
                        foreach(var b in blogPosts)
                        {
                            Console.WriteLine($"({b?.Length}) {b}");
                        }
                        break;
                    case "U":
                    case "u":
                        break;
                    case "D":
                    case "d":
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;

                }


            } while (true);
        }
    }
}
