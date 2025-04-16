namespace Liskov_Substitution_Principle.Methods
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
        public double ChangeDimensions(Rectangle rect, double width, double height)
        {
            rect.Width = width;
            rect.Height = height;
            return rect.GetArea();
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
