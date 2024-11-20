using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSuiteMODEL
{
    public class HomeModel
    {
        public string Name { get; set; } = string.Empty;

    }

    public class SlidesData
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; } = string.Empty;
        public string Logdate { get; set; } = string.Empty;
        public int IsActive { get; set; }
    }

}
