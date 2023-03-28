namespace ConsoleAppDealingWithAbstract
{
    abstract class Shape
    {
        private string color;


        public Shape(string _color)
        {
            Color = _color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public abstract float CalcArea();

        public abstract string Draw();
    }
}
