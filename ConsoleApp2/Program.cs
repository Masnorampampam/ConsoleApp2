
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 10;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("zgadnil liczbe pomiędzy " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" zgadnij: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " za duza!");

                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " za mala!");
                }
                guesses++;
            }
            Console.WriteLine("Numer: " + number);
            Console.WriteLine("WYGRANA!");
            Console.WriteLine("Proby: " + guesses);

            Console.WriteLine("Chcesz zagrac jeszcze raz? (T/N)");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "T")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }


        Console.WriteLine("Dzieki za gre!");

        Console.ReadKey();
    }
}