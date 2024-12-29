namespace Assignment2_strings
{
    public class Program
    {

        //Count no. of characters in the sentence


        public static void Main(string[] args)
        {
            Console.WriteLine("Give the sentence");
            String sentence = Console.ReadLine();
            StringMethods sm = new StringMethods();
            int choice;
            do
            {
                Console.WriteLine("\n*** Menu ***");
                Console.WriteLine("1.Count no. of characters in the sentence ");
                Console.WriteLine("2. Count no. of words in a sentence");
                Console.WriteLine("3. Reverse a sentence");
                Console.WriteLine("4. Check whether the sentence is palindrome or not");
                Console.WriteLine("5. Count number of vowels, consonants , integers and special characters in the sentence");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You chose Option 1.");

                            sm.Countcharacters(sentence);
                            break;
                        case 2:
                            Console.WriteLine("You chose Option 2.");
                            sm.Countwords(sentence);
                            break;
                        case 3:
                            Console.WriteLine("You chose Option 3");
                            sm.Reverse(sentence);
                            break;
                        case 4:
                            Console.WriteLine("You chose Option 4.");
                            sm.Palindrome(sentence);
                            break;
                        case 5:
                            Console.WriteLine("You chose Option 5");
                            sm.CountSentence(sentence);
                            break;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    choice = 0; // Reset to continue loop
                }


            }
            while (choice != 6);

        }
    }
}
