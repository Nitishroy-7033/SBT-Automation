using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBT_Automation.Data
{
    public class MongoDbConfigs
    {
        public const string Option = "MongoDbConfigs";
        public required string ConnectionString { get; set; }
        public required string DatabaseName { get; set; }
        public bool EnableCommandTracing { get; set; }
    }
}
