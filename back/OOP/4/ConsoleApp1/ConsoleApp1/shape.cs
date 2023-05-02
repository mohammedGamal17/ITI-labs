using System;

namespace ConsoleApp1
{
    class Shape
    {
        #region Fields
        private string color;
        #endregion

        #region Constructors
        public Shape(string _color)
        {
            Color = _color;
        }
        #endregion

        #region Properties
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        #endregion

        #region Methods
        public float calcArea()
        {
            return 0;
        }
        public void draw()
        {
            Console.WriteLine(color);
        }
        #endregion
    }
}
