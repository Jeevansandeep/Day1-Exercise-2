using system;
namespace Product
{
	 class Product
    {
        int productId;
        string productName;
        double price;
        string color;

        void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
		static void main(string[] args)
		{
			product1=new Product();
			product1.productID = 1110;
			product1.productName = "Hard drive";
			product1.price = 5550;
			product1.color = "Black";
			
			product1.Display();
		}
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1=new Product();
			product1.productID = 1110;
			product1.productName = "Hard drive";
			product1.price = 5550;
			product1.color = "Black";
			
			product1.Display();
		}
	}
}