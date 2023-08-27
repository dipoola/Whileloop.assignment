namespace Whileloop.assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random random = new Random();
            //int randomNumber = random.Next(1, 3);
            //int numberofAttempts = 4;
            //int playerGuess;



            //            int i = 1;
            //            while (i <= numberofAttempts)

            //            {
            //                Console.Write("Enter a guess: ");
            //                playerGuess = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine($"This is the looping part {i}");
            //                i++;
            //                if (playerGuess == randomNumber)
            //                {
            //                    Console.WriteLine("You are correct");
            //                    break;
            //                }
            //                else if (playerGuess < randomNumber)
            //                {
            //                    Console.WriteLine("Too low! Try again.");
            //                }
            //                else if (playerGuess > randomNumber)
            //                {
            //                    Console.WriteLine("Too high! Try again.");
            //                }
            //                else if (numberofAttempts == 4)
            //                {
            //                    Console.WriteLine("Numbers of attempt has been reached");
            //                    break;
            //                }
            //                Console.ReadLine();

            //            }

            Random random = new Random();
            int randomNumber = random.Next(1, 3);
            int numberofAttempts = 4;
            int playerGuess;


            int i = 1;
            do
            {


                Console.Write("Enter a guess: ");
                playerGuess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"This is the looping part {i}");
                if (playerGuess == randomNumber)
                {
                    Console.WriteLine("You are correct");
                    break;
                }
                else if (playerGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (playerGuess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (numberofAttempts == 4)
                {
                    Console.WriteLine("Numbers of attempt has been reached");
                    break;
                }
                i++;
                Console.ReadLine();


            }
                   while (i <= numberofAttempts);











        }

    }
}

        

  
    
