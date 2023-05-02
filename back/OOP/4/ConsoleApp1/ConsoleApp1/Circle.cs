using System;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        #region Fields
        private float radius;
        #endregion

        #region Constructors
        public Circle(string _color, float _radius) : base(_color)
        {
            Radius = _radius;
        }
        #endregion

        #region Properties
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        #endregion

        #region Methods
        public float calcArea()
        {
            return (float)(Radius * Math.PI * 2);
        }
        public void draw()
        {
            Console.WriteLine($" Area {calcArea()} , Color: {Color}");
        }
        #endregion
    }
}
