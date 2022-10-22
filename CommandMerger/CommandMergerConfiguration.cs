using Rocket.API;
using CommandMerger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Serialisation;

namespace CommandMerger
{
    public class CommandMergerConfiguration : IRocketPluginConfiguration
    {

        public HashSet<CommandMergedPermisions> CommandsMergedsPermissions;
        public void LoadDefaults()
        {
            CommandsMergedsPermissions = new HashSet<CommandMergedPermisions>
            {
                new CommandMergedPermisions()
                {
                    Permission = "commandmerger.newcommand",
                    Commands = new HashSet<Command>
                    {
                        new Command()
                        {
                            CommandName = "mycommand",
                            Commands = new List<string>
                            {
                                "rocket",
                                "heal",
                                "unlimidedammo"
                            }
                        }
                    }
                },
                new CommandMergedPermisions()
                {
                    Permission = "commandmerger.newcommand2",
                    Commands = new HashSet<Command>
                    {
                        new Command()
                        {
                            CommandName = "mycommand2",
                            Commands = new List<string>
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
}
