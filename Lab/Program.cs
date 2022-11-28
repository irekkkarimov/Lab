namespace Lab;

public class Program
{
    public static void Main()
    {
        var firstNumber = new ComplexNumbers(10, 17);
        var secondNumber = new ComplexNumbers();
        secondNumber.Re = 13;
        secondNumber.Im = 8;
        firstNumber.Print();
        secondNumber.Print();
        (firstNumber + secondNumber).Print();
        (firstNumber * secondNumber).Print();
        (firstNumber - secondNumber).Print();
        (firstNumber / secondNumber).Print();
        



    }
}