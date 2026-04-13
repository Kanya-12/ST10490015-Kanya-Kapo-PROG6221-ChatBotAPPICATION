using System;

namespace CyberSecurityChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "KanyaShield Chatbot";

            AudioPlayer.PlayGreeting();

            Logo.Display();

            ChatBot bot = new ChatBot();
            bot.Start();

            Console.ReadKey();
        }
    }
}