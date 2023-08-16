using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.Commands
{
    public class SaveCommand : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _operatedBy;
        public SaveCommand(Receiver receiver, string operatedBy)
        {
            _receiver = receiver;
            _operatedBy = operatedBy;
        }

        public void Execute()
        {
            _receiver.Run(Operation.Save, _operatedBy);
        }

        public void Undo()
        {
            _receiver.Run(Operation.Unsave, _operatedBy);
        }
    }
}
