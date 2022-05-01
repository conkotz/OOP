using System;

namespace HelloWorld
{
    class MainClass
    {
        static void Main(string[] args)
        {


            Message myMessage;
            myMessage = new Message("Hello World - From Message object");
            myMessage.Print();

            Message[] messages;
            messages = new Message[4];
            messages[0] = new Message("Welcome Back"); 
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("That is a silly name"); 

            Console.WriteLine("Enter name: ");
            string usersName = Console.ReadLine().ToLower();

            if (usersName == "conrad")
            {
                messages[0].Print();           
            }
            else if (usersName == "james")
            {
                messages[1].Print();
            }
            else if (usersName == "john")
            {
                messages[2].Print();
            }
            else
            {
                messages[3].Print();
            }
        }
    }
}
