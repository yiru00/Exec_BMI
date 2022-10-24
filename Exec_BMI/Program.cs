internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("請輸入身高（cm）:");
        string inputHeight = Console.ReadLine();
        bool isHeight = double.TryParse(inputHeight, out double height);
        if (isHeight == false)
        {
            Console.WriteLine("請輸入數值");
            return;
        }

        Console.WriteLine("請輸入體重（Kg）:");
        string inputWeight = Console.ReadLine();

        
        bool isWieght = double.TryParse(inputWeight, out double weight);
        if (isWieght==false)
        {
            Console.WriteLine("請輸入數值");
        }

        double meterHeight = height / 100;
        double result = weight /Math.Pow( meterHeight,2);
        Console.WriteLine(result.ToString());
    }
}