namespace TestQueueReceiver
{
    using System;

    [Serializable]
    public class MessageWrapper<TMessage>
    {
        public string Title { get; set; }

        public TMessage Message { get; set; }
    }
}