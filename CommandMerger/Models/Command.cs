using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMerger.Models
{
    public class Command
    {
        public string CommandName { get; set; }
        public List<string> Commands { get; set; }
        
        public Command()
        {
            
        }
    }
}
