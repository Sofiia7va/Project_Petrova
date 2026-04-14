using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Configuration
    {
        public string AppName { get; set; }
        public string Version { get; set; }

        public Configuration()
        {
            AppName = "Recipe Manager";
            Version = "1.0";
        }
    }
}
