internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DecimalToBinary();
                    break;
                case 2:
                    BinaryToDecimal();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }

    static void DecimalToBinary()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine($"Binary equivalent: {binaryNumber}");
    }

    static void BinaryToDecimal()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(binaryNumber, 2);
        Console.WriteLine($"Decimal equivalent: {decimalNumber}");
    }
}