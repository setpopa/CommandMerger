using System;
using Rocket.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using CommandMerger.Models;

namespace CommandMerger
{
    internal class CommandMerger : RocketPlugin<CommandMergerConfiguration>
    {
        public string _permission;
        public static CommandMergerConfiguration Conf;
        public static CommandMerger Inst { get; private set; }
        protected override void Load()
        {
            Inst = this;
            Conf = Configuration.Instance;
            if (Configuration != null && Configuration.Instance.CommandsMergedsPermissions.Count != 0)
            {
                foreach (var commandPermissions in Configuration.Instance.CommandsMergedsPermissions)
                {
                    _permission = commandPermissions.Permission;
                    foreach (var commands in commandPermissions.Commands)
                    {
                        Commands cmd = new Commands(_permission,commands.CommandName,commands.Commands);
                        R.Commands.Register(cmd);
                    }                  
                }
            }
            Logger.Log($"Plugin {Name} {Assembly.GetName().Version} loaded.");
        }
        protected override void Unload()
        {
            Inst = null;
            Conf = null;
            Logger.Log($"Plugin {Name} unloaded.");
            foreach (var command in Configuration.Instance.CommandsMergedsPermissions)
            {
                R.Commands.DeregisterFromAssembly(this.Assembly);
            }
        }
    }
}
