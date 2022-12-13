namespace Lab;

public class Program
{
    public static void Main()
    {
        var firstNumber = ComplexNumbers.AlgForm(10, 17);
        var secondNumber = ComplexNumbers.TrigForm(5, 30);
        
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        
        Console.WriteLine(firstNumber + secondNumber);
        Console.WriteLine(firstNumber - secondNumber);

        var thirdNumber = ComplexNumbers2.AlgForm(13, 8);
        var fourthNumber = ComplexNumbers2.TrigForm(9, 60);
        
        Console.WriteLine(thirdNumber);
        Console.WriteLine(fourthNumber);
        
        Console.WriteLine(thirdNumber * fourthNumber);
        Console.WriteLine(thirdNumber / fourthNumber);




    }
}