using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Планировщик_Подарков
{
    public class Gifts
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public Human human { get; set; }
        public Holidays holidays { get; set; }



    }
}
