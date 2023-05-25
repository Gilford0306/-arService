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

        public Car()
        {
                
        }
        public Car(int id, int clientId, string model)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Model = model;
        }
    }
}
