using BehavioralPatterns.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.Invokers
{
    public class ButtonInvoker
    {
        private readonly ICommand _command;
        public ButtonInvoker(ICommand command)
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
