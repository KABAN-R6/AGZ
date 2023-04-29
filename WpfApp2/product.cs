namespace WpfApp2
{
    public class product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
