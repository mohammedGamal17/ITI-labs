namespace AnimationCircle
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }

        public Circle(int x, int y, int radius, int speed, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Speed = speed;
            Color = color;
        }

        public void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color);
            graphics.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
        }
    }
}
