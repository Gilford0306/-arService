using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService
{
    public class Part
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int  Price { get; set; }


        public Part()
        {
                
        }
        public Part(int id, string name, string model, int price)
        {
            Id = id;
            Name = name;    
            Model = model;
            Price = price;
        }
    }
}
