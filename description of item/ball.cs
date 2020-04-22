using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace description_of_item
{
    class ball
    {
        public int weight { get; set; }
        public string type_of_balls { get; set; }
        public string the_size_of_the_ball { get; set; }
        public int razmer { get; set; }
        public double speed { get; set; }
        public string material { get; set; }

        string metal = "Металл";
        int HP = 100;
        public void Damag()
        {
            if (speed > 10)
            {
                HP -= 5;
            }
            else
            {
                smert();
            }
        }
        public string smert()
        {
            if (material == metal)
            {
                return "ТЫ УМЕР!";
            }
            return "";
        }
    }
}
