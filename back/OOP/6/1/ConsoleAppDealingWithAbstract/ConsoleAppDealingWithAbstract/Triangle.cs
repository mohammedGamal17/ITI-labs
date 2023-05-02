using System;

namespace ConsoleAppDealingWithAbstract
{
    class Triangle : Shape
    {
        public Triangle(string _color, float _dim1, float _dim2, float _dim3) : base(_color)
        {
            Dim1 = _dim1;
            Dim2 = _dim2;
            Dim3 = _dim3;
        }

        public float Dim1 { get; set; }
        public float Dim2 { get; set; }
        public float Dim3 { get; set; }

        public override float CalcArea()
        {
            float semiperimeter = (Dim1 + Dim2 + Dim3) / 2;
            return (float)Math.Sqrt(semiperimeter * (semiperimeter - Dim1) * (semiperimeter - Dim2) * (semiperimeter - Dim3));
        }

        public override string Draw()
        {
            return $"Triangle Draw is : {Color}";
        }
    }
}
