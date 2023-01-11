internal class Program
{
    private static void Main(string[] args)
    {
    
    }
    public static int birthdayCakeCandles(List<int> candles)
    {
    int maxValue = candles.Max();
    int count =0;
    for (int i=0; i < candles.Count; i++)
    {
        if (maxValue == candles[i])
            count++;
    }
        return count;
    }
}