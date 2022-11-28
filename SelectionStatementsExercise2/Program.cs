namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What is your favorite school subject?");
            var response = Console.ReadLine();

            switch(response)
            {
                case "Math":
                    Console.WriteLine("I used to like Math when I was younger.");
                break;
                case "English":
                    Console.WriteLine("I would like to think I speak a little bit of English.");
                    break;
                case "History":
                    Console.WriteLine("I love some History Channel!");
                    break;
                case "Geography":
                    Console.WriteLine("It is always good to know Geography.");
                        break;
                case "Literature":
                    Console.WriteLine("Nerd!");
                        break;
                default:
                    Console.WriteLine("I guess it says a lot about you.");
                    break;
                   
            }
            Console.ReadLine();
        }
    }
}