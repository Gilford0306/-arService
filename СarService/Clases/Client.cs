using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService
{
    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }

        public List <Car>cars = new List <Car> ();
        public List<Service> services = new List<Service>();
        public List<Part> parts = new List<Part>();


        public Client()
        {
                
        }
        public Client(int id, string login, string name)
        {
            this.Id = id;
            this.Login = login;
            this.Name = name;

        }
    }
}
