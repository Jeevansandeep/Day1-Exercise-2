using system;
namespace Product
{
	 class Product
    {
        internal int productId;
        internal string productName;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1 = new Product();
			product1.productID = 1110;
			product1.productName = "Hard drive";
			product1.price = 5550;
			product1.color = "Black";
			
			product1.Display();
		}
	}
}