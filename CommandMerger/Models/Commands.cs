using Rocket.API;
using Rocket.Core;
using RocketExtensions.Plugins;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMerger.Models
{
    public class Commands : IRocketCommand
    {
        private string _commandPermission;
        private string _commandName;
        private List<string> _commands;

        public Commands(string commandPermission, string commandName, List<string> commands)
        {
            this._commandPermission = commandPermission;
            this._commandName = commandName;
            this._commands = commands;
        }

        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => _commandName;

        public string Help => null;

        public string Syntax => null;

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { _commandPermission };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            foreach (var cmd in _commands)
            {
                R.Commands.Execute(caller, cmd);
            }
        }

    }
}
