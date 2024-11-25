using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatern
{

    internal class CommandManager
    {
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (_commandHistory.Count > 0)
                {
                    var command = _commandHistory.Pop();
                    command.Undo();
                }
                else
                {
                    Console.WriteLine("Нет больше действий для отмены.");
                    break;
                }
            }
        }
    }


}
