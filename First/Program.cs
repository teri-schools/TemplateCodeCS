namespace First
{
    public static class FirstProgram
    {

        public static bool ToTestFunction(int num)
        {
            return (num % 2) == 0;
        }

        public static int Main(string[] argv)
        {
            string? input_line = Console.ReadLine();

            if (input_line is null)
            {
                return -1;
            }
        
            int input_num = int.Parse(input_line);

            bool result = ToTestFunction(input_num);

            Console.WriteLine(result);

            return 0;
        }
    }
}