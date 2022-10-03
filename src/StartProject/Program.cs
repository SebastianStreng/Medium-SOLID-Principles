using SingleResponsibilityPrinciple; 
public class Program
{
    static void Main(string[] args)
    {
        SingleResponsibilityPrinciple.goodCode.SRPGoodCode.GetGoodCode();

        string path = $"{Directory.GetCurrentDirectory()}/test.txt";
        Console.Write(DoSomethingWithThisContent(GetConentFromTxtFile(path)));

    }

    public static string GetConentFromTxtFile(string path)
    {
        return System.IO.File.ReadAllText(path);
    }

    public static string DoSomethingWithThisContent(string content)
    {
        return content; 
    }



}

