using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommandMerger.Models
{
    public class CommandMergedPermisions
    {
        [XmlAttribute]
        public string Permission { get; set; }
        [XmlArrayItem("Value")]
        public HashSet<Command> Commands { get; set; }

        public CommandMergedPermisions()
        {

        }
    }
}
