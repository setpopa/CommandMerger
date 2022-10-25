using Rocket.API;
using CommandMerger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Serialisation;
using System.Xml.Serialization;

namespace CommandMerger
{

    public class CommandMergerConfiguration : IRocketPluginConfiguration
    {

        public HashSet<CommandPermision> CommandsMergedsPermissions;
        public void LoadDefaults()
        {
            CommandsMergedsPermissions = new HashSet<CommandPermision>
            {
                new CommandPermision()
                {
                    Permission = "commandmerger.newcommand",
                    Commands = new HashSet<Command>
                    {
                        new Command()
                        {
                            CommandName = "mycommand",
                            Commands = new string[]
                            {
                                "rocket",
                                "heal",
                                "unlimidedammo"
                            }
                        }
                    }
                },
                new CommandPermision()
                {
                    Permission = "commandmerger.newcommand2",
                    Commands = new HashSet<Command>
                    {
                        new Command()
                        {
                            CommandName = "mycommand2",
                            Commands = new string[]
                            {
                                "rocket",
                                "tp setpopa"
                            }
                        }
                    }
                },
            };
            
        }
    }
    public class CommandPermision
    {       
        public string Permission { get; set; }       
        public HashSet<Command> Commands { get; set; }
        public CommandPermision()
        {

        }
    }
    public class Command
    {
        public string CommandName { get; set; }
        [XmlArray(ElementName = "Command")]
        public string[] Commands { get; set; }

        public Command()
        {

        }
    }

}
