using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService
{
    public class Car
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Model { get; set; }

        public int Year{ get; set; }

        public Car()
        {
                
        }
        public Car(int id, string model, int clientId, int year)
        {
            this.Id = id;
            this.Model = model;
            this.ClientId = clientId;
            this.Year = year;    
        }
    }
}
