using Lab;

namespace ComplexNumbersTest;
public class ComplexNumbersTest
{
    public void ToStringTest1()
    {
        int a = 10;
        int b = 20;

        var complexNumber = ComplexNumbers.AlgForm(a, b);

        var result = $"{a} + {b}i";
        Assert.AreEqual(complexNumber.ToString(), result);
    }
}