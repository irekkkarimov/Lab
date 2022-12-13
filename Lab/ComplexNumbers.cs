
namespace Lab
{
    public class ComplexNumbers
    {
        private double _re;
        private double _im;
        
        public double Re
        {
            get { return _re; }
            init { _re = value; }
        }
        
        public double Im
        {
            get { return _im; }
            init { _im = value;}
        }

        public double Mod
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }
        
        public double Arg
        {
            get { return Math.Atan2(Im , Re); }
        }
        private ComplexNumbers(double a, double b)
        {
            Re = a;
            Im = b;
        }

        public static ComplexNumbers AlgForm(double re, double im)
        {
            return new ComplexNumbers(re, im);
        }

        public static ComplexNumbers TrigForm(double mod, double arg)
        {
            var re = mod * Math.Cos(arg);
            var im = mod * Math.Sin(arg);
            return new ComplexNumbers(re, im);
        }
        
        public override string ToString()
        {
            if (Im > 0) return $"{{Re}} + {Im}i";
            if (Im < 0) return $"{Re} - {-Im}i";
            return Re.ToString();
        }
        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            double reRes = a.Re + b.Re;
            double imRes = a.Im + b.Im;
            return new ComplexNumbers(reRes, imRes);
        }

        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            double reRes = a.Re - b.Re;
            double imRes = a.Im - b.Im;
            return new ComplexNumbers(reRes, imRes);
        }
    }
}