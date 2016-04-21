namespace TestQueueReceiver
{
    using System;

    [Serializable]
    public class SomeMessage
    {
        public string SomeProp { get; set; }

        public dynamic FormData { get; set; }

        public DateTime SomeOtherProp { get; set; }
    }
}