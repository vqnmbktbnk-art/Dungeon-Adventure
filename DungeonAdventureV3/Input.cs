public class InputProcessing
{
    public int InputConversion(string? input)
    {
        while (true)
        {
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