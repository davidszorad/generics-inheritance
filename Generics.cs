using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsInheritance
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T sut);
    }

    public class EligibleForDiscountSpecification : ISpecification<Customer>
    {
        private readonly Product _product;

        public EligibleForDiscountSpecification(Product product)
        {
            _product = product;
        }

        public bool IsSatisfiedBy(Customer customer)
        {
            return (_product.Price < 100 && customer.CreditRating >= _product.MinimumCreditRating);
        }
    }
}
