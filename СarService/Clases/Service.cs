using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService
{
    public class Service
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public List<Master>masters=new List<Master>();


        public Service()
        {

        }
        public Service(int id, string description,  int price)
        {
            Id = id;
            Description = description;
            Price = price;

        }
    }
}
