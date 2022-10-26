using System;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        async static Task Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();

            var tss = new TaskCompletionSource();

            messageBox.action += (State state) =>
            {
                if (state == State.Cancel)
                {
                    Console.WriteLine("Cancel");
                }
                else
                {
                    Console.WriteLine("Ok");
                }

                tss.SetResult();
            };

            messageBox.Open();

            await tss.Task;
        }

      
    }
}
