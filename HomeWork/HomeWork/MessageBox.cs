using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    class MessageBox
    {
        public event Action<State> action;
        public async Task<bool> Open()
        {
            Console.WriteLine("Окно открыто");
            await Task.Delay(3000);
            Console.WriteLine("Окно закрыто");
            action?.Invoke(StateMehtod());

            return true;
        }

        public State StateMehtod()
        {
            State state = State.Cancel;
            Random rnd = new Random();
            int value = rnd.Next();

            if (value % 2 == 0)
            {
                state = State.Ok;
            }
            return state;
        }
    }

    public enum State
    {
        Ok,
        Cancel
    }
}
