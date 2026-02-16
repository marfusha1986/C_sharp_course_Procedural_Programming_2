namespace C_sharp_course_Procedural_Programming_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or 'Quit' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
            Console.WriteLine("Donguden ciktim");

            Console.WriteLine("Unique numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;

                }
    }
}
