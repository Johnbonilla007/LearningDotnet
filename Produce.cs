
using System;

namespace DotnetCoreTest
{
    public class Produce
    {
        public int IdProducto { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchase { get; set; }

        public Produce()
        {
        }

        public class Builder
        {
            private readonly Produce _product;

            public Builder()
            {
                _product = new Produce();
            }

            public Builder WhitIdProduct(int id)
            {
                _product.IdProducto = id;
                return this;
            }

            public Builder WhitPurchasePrice(decimal purchasePrice)
            {
                _product.PurchasePrice = purchasePrice;
                return this;
            }

            public Builder WhitQuantity(int quantity)
            {
                _product.Quantity = quantity;
                return this;
            }

            public Builder WhitDatePurchase(DateTime datePurchase)
            {
                _product.DatePurchase = datePurchase;
                return this;
            }

            public Produce Build()
            {
                return _product;
            }
        }
    }
}