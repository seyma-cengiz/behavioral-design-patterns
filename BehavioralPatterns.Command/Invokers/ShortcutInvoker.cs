using BehavioralPatterns.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.Invokers
{
    public class ShortcutInvoker
    {
        private readonly ICommand _command;
        public ShortcutInvoker(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }

        public void Undo()
        {
            _command.Undo();
        }
    }
}
