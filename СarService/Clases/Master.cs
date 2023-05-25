using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService
{
    public class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Professional { get; set; }
        public int Level { get; set; }


        public Master()
        {
                
        }

        public Master(int id, string name, string Prof, int level)
        {
            Id = id;
            Name = name;
            Professional = Prof;
            Level = level;
        }
    }
}
