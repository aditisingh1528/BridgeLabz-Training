using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStream
{
    static void Main(string[] args)
    {
        try
        {
            AnonymousPipeServerStream server =
                new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

            AnonymousPipeClientStream client =
                new AnonymousPipeClientStream(PipeDirection.In, server.GetClientHandleAsString());

            Thread writerThread = new Thread(() => WriteData(server));
            Thread readerThread = new Thread(() => ReadData(client));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Pipe error: " + ex.Message);
        }
    }

    static void WriteData(AnonymousPipeServerStream server)
    {
        try
        {
            StreamWriter writer = new StreamWriter(server, Encoding.UTF8);
            writer.AutoFlush = true;

            writer.WriteLine("Hello from writer thread");
            writer.WriteLine("Data sent through pipe");
            writer.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write error: " + ex.Message);
        }
    }

    static void ReadData(AnonymousPipeClientStream client)
    {
        try
        {
            StreamReader reader = new StreamReader(client, Encoding.UTF8);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Reader received: " + line);
            }

            reader.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read error: " + ex.Message);
        }
    }
}
