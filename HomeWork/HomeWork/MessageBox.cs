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
        public async void Open()
        {
            Console.WriteLine("Окно открыто");
            await Task.Delay(3000);
            Console.WriteLine("Окно закрыто");
            action?.DynamicInvoke();
        }

    }

    public enum State
    {
        Ok,
        Cancel
    }
}
