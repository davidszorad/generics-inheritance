using System;

namespace GenericsInheritance
{
    public class Customer
    {
        public double CreditRating { get; set; }
    }

    public class Product
    {
        public double Price { get; set; }
        public double MinimumCreditRating { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            var customer = new Customer();
            var eligible = new EligibleForDiscountSpecification(product);
            var satisfied = eligible.IsSatisfiedBy(customer);
        }
    }
}