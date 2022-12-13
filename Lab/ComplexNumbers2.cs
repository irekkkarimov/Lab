namespace Lab;

public class ComplexNumbers2
{
    private double _mod;
    private double _arg;
    
    public double Re
    {
        get { return Mod * Math.Cos(Arg); }
    }

    public double Im
    {
        get { return Mod * Math.Sin(Arg); }
    }

    public double Mod
    {
        get { return _mod; }
        init { _mod = value; }
    }

    public double Arg
    {
        get { return _arg; }
        init { _arg = value; }
        
    }
    
    private ComplexNumbers2(double mod, double arg)
    {
        Mod = mod;
        Arg = arg;
    }
    
    public static ComplexNumbers2 AlgForm(double re, double im)
    {
        var mod = Math.Sqrt(re * re + im * im);
        var arg = Math.Atan2(re, im);
        return new ComplexNumbers2(mod, arg);
    }

    public static ComplexNumbers2 TrigForm(double mod, double arg)
    {
        return new ComplexNumbers2(mod, arg);
    }
    
    public override string ToString()
    {
        if (Im > 0) return $"{Re} + {Im}i";
        if (Im < 0) return $"{Re} - {-Im}i";
        return Re.ToString();
    }

    public static ComplexNumbers2 operator *(ComplexNumbers2 a, ComplexNumbers2 b)
    {
        return new ComplexNumbers2(a.Mod * b.Mod, a.Arg + b.Arg);
    }
    
    public static ComplexNumbers2 operator /(ComplexNumbers2 a, ComplexNumbers2 b)
    {
        return new ComplexNumbers2(a.Mod * b.Mod, a.Arg - b.Arg);
    }
        
}