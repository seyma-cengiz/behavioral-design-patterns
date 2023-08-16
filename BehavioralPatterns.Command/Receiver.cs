using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command
{
    public class Receiver
    {
        public string Output { get; private set; }
        public void Run(string operation, string operatedBy)
        {
            switch (operation)
            {
                case Operation.Save:
                    Output += $"File saved by {operatedBy}\n";
                    break;
                case Operation.Unsave:
                    Output += $"File unsaved by {operatedBy}\n";
                    break;
                case Operation.Copy:
                    Output += $"File copied by {operatedBy}\n";
                    break;
                case Operation.Uncopy:
                    Output += $"File uncopied by {operatedBy}\n";
                    break;
                default:
                    break;
            }
        }
    }
}
