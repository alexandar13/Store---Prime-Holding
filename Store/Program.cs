using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfPurchase = new DateTime(2021, 6, 14, 12, 34, 56);

            Cashier cashier = new Cashier();

            Appliance laptop = new Appliance("ModelL", new DateTime(2021, 3, 3), 1.125,"laptop", "BrandL", 2345);
            Clothe Tshirt = new Clothe("violet", Sizes.L, "T-shirt", "BrandT", 15.99);
            Food apples = new Food("apples", "BrandA", 1.50, new DateTime(2021, 6, 14));
            Beverage milk = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 2, 2));


            Cart cart = new Cart();
            Purchase purchase;

            purchase = new Purchase(apples, 2.45);
            cart.addToCart(purchase);

            purchase = new Purchase(milk, 3);
            cart.addToCart(purchase);

            purchase = new Purchase(Tshirt, 2);
            cart.addToCart(purchase);

            purchase = new Purchase(laptop, 1);
            cart.addToCart(purchase);

            
            
            cashier.printReceipt(cart ,timeOfPurchase);
        }
    }
}
