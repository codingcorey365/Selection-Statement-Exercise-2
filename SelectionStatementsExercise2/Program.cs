namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math": 
                    Console.WriteLine("I love math");
                    break;
                
                case "science":
                    Console.WriteLine("I love science");
                    break;

                case "history":
                    Console.WriteLine("I love history");
                    break;

                case "english":
                    Console.WriteLine("I love english");
                    break;
                    default: Console.WriteLine($"learning is fun, I have not heard of the subject {userInput} before.");
                        break;
            }
        }
    }
}