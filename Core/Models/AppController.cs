using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class AppController
    {
        private Configuration _config;

        public AppController()
        {
            _config = new Configuration();
        }

        public void ShowConfig()
        {
            Console.WriteLine("=== Configuration ===");
            Console.WriteLine($"App: {_config.AppName}");
            Console.WriteLine($"Version: {_config.Version}");
        }
    }
}
