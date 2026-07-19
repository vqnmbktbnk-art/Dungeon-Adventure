public class InputProcessing
{
    public int InputConversion()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                continue;
            }
            if (!int.TryParse(input , out int inputValue))
            {
                continue;
            }
            return inputValue;
        }
    }
}