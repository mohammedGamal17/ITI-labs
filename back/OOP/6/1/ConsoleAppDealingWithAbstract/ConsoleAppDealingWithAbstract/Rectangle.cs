namespace ConsoleAppDealingWithAbstract
{
    class Rectangle : Shape
    {
        public Rectangle(string _color, float _dim1, float _dim2) : base(_color)
        {
            Dim1 = _dim1;
            Dim2 = _dim2;
        }


        public float Dim1 { get; set; }
        public float Dim2 { get; set; }

        public override float CalcArea()
        {
            if (Dim1 == Dim2)
                return Dim1 * Dim2;
            else return (Dim1 + Dim2) * 2;
        }

        public override string Draw()
        {
            if (Dim1 == Dim2)
                return $"Square Draw is : {Color}";
            else return $"Rectangle Draw Color is : {Color}";
        }
    }
}
