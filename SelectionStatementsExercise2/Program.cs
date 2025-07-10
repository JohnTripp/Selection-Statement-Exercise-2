using System.Runtime.CompilerServices;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Im not big fan of math");
                    break;
                case "science":
                    Console.WriteLine("big fan of science");
                    break;
                case "sports":
                case "pe":
                case "p.e":
                case "physical education":
                    Console.WriteLine("Big fan of physical education");
                    break;
                case"history":
                    Console.WriteLine("not a bad choice history");
                    break;
                    case"geography":
                        Console.WriteLine("great love for geography");
                        break;
                    default:
                    Console.WriteLine("I like that too");
                    break;
            }
        }
    }
    
}
