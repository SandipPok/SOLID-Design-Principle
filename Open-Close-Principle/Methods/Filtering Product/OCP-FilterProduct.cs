namespace Open_Close_Principle.Methods.Filtering_Product
{
    public class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    public class ColorSpecification: ISpecification<Product>
    {
        private readonly string _color;
        public ColorSpecification(string color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product item)
        {
            return item.Color == _color;
        }
    }
    public class SizeSpecification:ISpecification<Product>
    {
        private readonly double _size;

        public SizeSpecification(double size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product item)
        {
            return item.Size == _size.ToString();
        }
    }
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            return items.Where(p => specification.IsSatisfied(p));
        }
    }
}
