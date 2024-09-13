using System;

namespace EventsExample
{
    public class EventClass
    {
        public delegate void NotifyDelegate();

        public event NotifyDelegate NotifyEvent;

        public void Execute()
        {
            OnExecutedCompletion();
        }
        private void OnExecutedCompletion()
        {
            if(NotifyEvent!=null)
            {
                NotifyEvent();//invoke
            }
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            EventClass objEventClass = new EventClass();
            objEventClass.NotifyEvent += NotiflyHandler;
            objEventClass.Execute();

            Console.ReadKey();
        }

        private static void NotiflyHandler()
        {
            Console.WriteLine("Event handled successfully");
        }
    }
}
