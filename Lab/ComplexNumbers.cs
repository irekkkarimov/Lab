
namespace Lab
{
    public class ComplexNumbers
    {
        private double _re;
        private double _im;
        private double _mod;
        private double _arg;

        public ComplexNumbers(){}

        public ComplexNumbers(double a)
        {
            Re = a;
            _mod = Math.Sqrt(Re * Re);
            _arg = Math.Acos(Re / Mod);
        }
        public ComplexNumbers(double a, double b)
        {
            Re = a;
            Im = b;
            _mod = Math.Sqrt(Re * Re + Im * Im);
            _arg = Math.Acos(Re / Mod);
        }

        public double Re
        {
            get { return _re; }
            set { _re = value;
                _mod = Math.Sqrt(Re * Re + Im * Im);
                _arg = Math.Acos(Re / Mod); }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value;
                _mod = Math.Sqrt(Re * Re + Im * Im);
                _arg = Math.Acos(Re / Mod); }
        }

        public double Mod => _mod;
        public double Arg => _arg;

        public void Print()
        {
            Console.WriteLine(Im >= 0 ? $"{Re} + {Math.Abs(Im)}i" : $"{Re} - {Math.Abs(Im)}i");
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

        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            double reRes = a.Re * b.Re - a.Im * b.Im;
            double imRes = a.Re * b.Im + a.Im * b.Re;
            return new ComplexNumbers(reRes, imRes);
        }

        public static ComplexNumbers operator /(ComplexNumbers a, ComplexNumbers b)
        {
            var divOpp = new ComplexNumbers(b.Re, -b.Im);
            var numerator = a * divOpp;
            var temp = b * divOpp;
            double denominator = temp.Re;
            double reRes = numerator.Re / denominator;
            double imRes = numerator.Im / denominator;
            return new ComplexNumbers(reRes, imRes);
        }
    }
}