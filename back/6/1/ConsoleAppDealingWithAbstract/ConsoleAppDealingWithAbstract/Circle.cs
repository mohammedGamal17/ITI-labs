using System;

namespace ConsoleAppDealingWithAbstract
{
    class Circle : Shape
    {


        public Circle(float _radius, string _color) : base(_color)
        {
            Radius = _radius;

        }

        public float Radius { get; set; }


        public override float CalcArea()
        {
            return (float)(Radius * 2 * Math.PI);
        }

        public override string Draw()
        {
            return $"Circle Draw is : {Color}";
        }
    }
}
