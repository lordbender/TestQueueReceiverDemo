namespace TestQueueReceiver
{
    using System;
    using System.Threading;

    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (IQueueService service = new QueueService("localhost"))
            {
                //Would presumably be in some other application.
                //Get the next available message from the Queue.
                while (true)
                {
                    Thread.Sleep(new TimeSpan(0, 0, 0, 2, 0));

                    Console.WriteLine("Checking Queue for work");
                    var message = service.DequeueObject<SomeMessage>("testQueue");

                    if (message != null)
                    {
                        //Prove the message was read...
                        Console.WriteLine("\tFound Work:\n\t\tComplex Object Message Title: {0}", message.SomeProp);
                        Console.WriteLine("\t\tProcessing Complex Object: {0}\n\n", JsonConvert.SerializeObject(message));
                    }
                }
            }
        }
    }
}