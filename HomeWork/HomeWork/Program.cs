using System;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
       async static Task Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();

            messageBox.action += CloseWindow;

           await OpenAsync(messageBox);
        }

        public static void CloseWindow(State state)
        {
            Console.WriteLine($"{state}");
        }
        public static Task OpenAsync(MessageBox messageBox)
        {
            var task = new TaskCompletionSource<bool>();
            Task.Run(async ()=> { 
                bool result = await messageBox.Open();
                task.SetResult(result);
            });
           

            return task.Task;
        }
    }
}
