namespace Complex
{
    internal class Complex : IComparable<Complex>

    {

        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex Add(Complex other)
        {
            double real = Real + other.Real;
            double imaginary = Imaginary + other.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator +(Complex first, Complex second)
        {
            return new Complex(first.Real + second.Real, first.Imaginary + second.Imaginary);
        }

        public static Complex operator +(Complex first, int second)
        {
            return new Complex(first.Real + second, first.Imaginary);
        }

        public static Complex operator +(int second, Complex first)
        {
            return first + second;
        }

        public static Complex operator ++(Complex first)
        {
            return new Complex(first.Real++, first.Imaginary);
        }

        public static bool operator >(Complex first, Complex second)
        {
            return first > second;
        }

        public static bool operator <(Complex first, Complex second)
        {
            return first < second;
        }

        public static explicit operator double(Complex first)
        {
            return first.Real;
        }


        public int CompareTo(Complex? other)
        {
            Complex complex = other as Complex;
            return Real.CompareTo(complex.Real);

        }

        public override string ToString()
        {

            return $"{Real} + {Imaginary}i";
        }
    }

}
