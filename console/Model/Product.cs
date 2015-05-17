namespace console
{
	public class Product {
		private string name;
		private decimal price;
		public string Name { get { return name; }  set { name = value; } }
		public decimal Price { get { return price; }  set { price = value; } }
		
		override
		public string ToString() {
			return name + ", " + price;
		}
	}
}