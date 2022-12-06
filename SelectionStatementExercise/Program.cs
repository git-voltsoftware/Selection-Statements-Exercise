namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
    
            var r = new Random();
            var favoriteNumber = r.Next(1,1000);

            Console.WriteLine("Guess my favorite number.");
            var userInput = Convert.ToInt32((Console.ReadLine()));

            if ( userInput < favoriteNumber ){
                Console.WriteLine("Too low.");
            }else if (userInput > favoriteNumber){
                Console.WriteLine("Too high.");
            }else{
                Console.WriteLine("You guessed it!");
            }


        }
    }
}
