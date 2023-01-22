namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check");

            var name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
           string reversed = new string (nameArray );
            if (name .Equals(reversed, StringComparison.OrdinalIgnoreCase ))
            {
                Console.WriteLine($"The {name } is a palindrome");
            }
            else
            {
                Console.WriteLine($"The {name} is not a palindrome");
            }
        }
    }
}