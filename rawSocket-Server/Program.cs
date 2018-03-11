using System;
using System.Threading.Tasks;

namespace rawSocket_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpHelper.StartServer(2584);
            TcpHelper.Listen();
            while(true)
            {
                Console.WriteLine("enter 'quit' to exit...");
                string handleKey = Console.ReadLine();
                if(handleKey == "quit")
                    break;
            }
        }
    }
}
