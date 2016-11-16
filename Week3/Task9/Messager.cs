namespace Task9
{
    
    class Messager
    {
        public delegate void MessageEventHandler(string message);
        public static event MessageEventHandler SendMessageEvent;

        // Method for sending string messages to UI
        public static void SendMessage(string message)
        {
            if (SendMessageEvent != null)
            {
                SendMessageEvent(message);
            }
        }
    }
}
