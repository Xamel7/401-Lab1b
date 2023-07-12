namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {
            int[] numberArray = new int[4];// Declare array of four zeros
            int[] popluateResult = Popluate(numberArray);//Call Popluate method
            int sum = GetSum(popluateResult);
            Console.WriteLine(sum);

            for (int i = 0; i < popluateResult.Length; i++)//Loop through array and console.write elements
            {
                Console.WriteLine(popluateResult[i] + " ");
            }
            int product = GetProduct(popluateResult, sum);
            GetQuotient(product);
        }
        static int[] Popluate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)// Loop through array and propmt user for values
            {
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Convert.ToInt32(userInput);
                array[i] = number;
            }
            return array;
        }
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (sum < 20)
            {
                throw new Exception("Sum is too low. ");
            }
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a random number between 1 & {0}",
                array.Length);
            string userInput = Console.ReadLine();
            int randomIndex = Int32.Parse(userInput);
            randomIndex = randomIndex - 1;
            int randomNumber = array[randomIndex];
            Console.WriteLine("Random number is: {0}", randomNumber);
            //multiply the sum and the random number.
            int product = randomNumber * sum;
            Console.WriteLine("This is the product: {0}", product);

            return product;
        }
        static decimal GetQuotient(int product)
        {
            //Prompt user for nummber to divide product by
            Console.WriteLine("Give me a number to divide the product by");
            string userInput = Console.ReadLine();
            int divisor = Int32.Parse(userInput);
            decimal quotient = product / divisor;

            Console.WriteLine("This is the Quotient: {0}", quotient);
            return quotient;
        }
    }
}