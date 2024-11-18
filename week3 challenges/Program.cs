namespace week3_challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input1 = "eye";
            string input2 = "hannah";
            Console.WriteLine("enter a word to check if its a palinderome: ");
            string input3 = Console.ReadLine();

            Console.WriteLine($"is {input1}, a palindrome? {IsPalindrome(input1)}");
            Console.WriteLine($"Is {input2}, a palindrome? {IsPalindrome(input2)}");
            Console.WriteLine($"Is {input3}, a palindrome? {IsPalindrome(input3)}");
        }




        static bool IsPalindrome(string str)
        {

            char[] charArray = str.ToCharArray();


            Array.Reverse(charArray);


            string reversedString = new string(charArray);


            return str.Equals(reversedString, StringComparison.OrdinalIgnoreCase);


        }

    }
}

