using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketCliente
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*5) Declaramos el socket cliente con las mismas propiedades y direccion */
            Socket cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            /* 6) Conectamos */
            cliente.Connect(direccion);               

            Console.WriteLine(" You arrive to Mordor's lair, and said.. \n");

            /* 7) Capturamos el mensaje y lo enviamos al otro lado */
            string info = Console.ReadLine();

            byte[] infoEnviar = Encoding.Default.GetBytes(info);

            cliente.Send(infoEnviar, 0, infoEnviar.Length, 0);
            cliente.Close();

            Console.WriteLine("Presione cualquier tecla para terminar");

            Console.ReadKey();


        }
    }
}
