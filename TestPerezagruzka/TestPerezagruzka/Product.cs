using System;
namespace TestPerezagruzka
{
    public abstract class Product
    {
        
            public string Name { get; set; }
            public int Calories { get; set; }
            public int Volume { get; set; }

        public Product(string name, int calories, int volume)
        {

        }

    }
}
