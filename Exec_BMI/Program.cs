internal class Program
{
    private static void Main(string[] args)
    {

        //取得身高
        double height=0;
        try
        {
            height = GetHeight();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        //取得體重
        double weight = 0;
        try
        {
            weight = GetWeight();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        //BMI公式
        double result=GenerateBMI(height, weight);
        Console.WriteLine($"BMI為{ result.ToString("##.00")}");
    }

    private static double GenerateBMI(double height, double weight)
    {
        double meterHeight = height / 100;
        double result = weight / Math.Pow(meterHeight, 2);
        return result;
    }

    private static double GetWeight()
    {
        Console.WriteLine("請輸入體重（Kg）:");
        string inputWeight = Console.ReadLine();
        bool isWieght = double.TryParse(inputWeight, out double weight);
        if (isWieght == false)
        {
            throw new Exception("必須是數值");
       
        }
        return weight;
    }

    private static double GetHeight()
    {
        Console.WriteLine("請輸入身高（cm）:");
        string inputHeight = Console.ReadLine();
        bool isHeight = double.TryParse(inputHeight, out double height);
        if (isHeight == false)
        {
            throw new Exception("必須是數值");
           
        }
        return height;
    }
}