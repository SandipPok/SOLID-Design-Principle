namespace Open_Close_Principle.Methods.E_Commerce
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double price);
    }

    public class RegularDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.15;
        }
    }

    public class PremiumDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.35;
        }
    }

    public class NewbieDiscount: IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.09;
        }
    }

    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateFinalDiscount(double price)
        {
            return _discountStrategy.CalculateDiscount(price);
        }
    }
}
