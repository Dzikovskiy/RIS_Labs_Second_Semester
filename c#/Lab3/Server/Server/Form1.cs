using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RisLab2;
using Server.DAO;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private async void StartServer()
        {
            //textBox1.Text += ("Ожидание подключений...");
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            const int port = 8888;
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);

            try
            {
                listener.Start();
                textBox1.Text += ("Ожидание подключений...");

                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    ClientObject clientObject = new ClientObject(client);

                    //создаем новый поток для обслуживания нового клиента
                    Thread clientThread = new Thread(() => clientObject.Process(textBox1));
                    textBox1.Text += "\r\n New client started!";
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
        }

        class ClientObject
        {
            public TcpClient client;

            public ClientObject(TcpClient tcpClient)
            {
                client = tcpClient;
            }

            public void Process(TextBox textBox)
            {
                NetworkStream stream = null;
                try
                {
                    stream = client.GetStream();
                    byte[] data = new byte[3024]; // буфер для получаемых данных
                    while (true)
                    {
                        // getting of command
                        StringBuilder builder = new StringBuilder();
                        int bytes = 0;
                        do
                        {
                            bytes = stream.Read(data, 0, data.Length);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        } while (stream.DataAvailable);

                        string message = builder.ToString();
                        builder.Clear();

                        if (message.Equals("GET_ALL"))
                        {
                            //send initial store to client
                            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
                            var storeSerialized = computerFromFile.SerializeToString();
                            data = Encoding.Unicode.GetBytes(storeSerialized);
                            stream.Write(data, 0, data.Length);
                            Debug.WriteLine("GET_ALL");
                            textBox.Text += "\r\nGET_ALL";
                        }

                        if (message.Equals("SAVE"))
                        {
                            //read computer from client
                            do
                            {
                                bytes = stream.Read(data, 0, data.Length);
                                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                            } while (stream.DataAvailable);

                            var computer = builder.ToString().DeserializeString<Computer>();
                            ComputerService.AddComputer(computer);
                            textBox.Text += "\r\nComputer saved";

                            //send store to client
                            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
                            var storeSerialized = computerFromFile.SerializeToString();
                            data = Encoding.Unicode.GetBytes(storeSerialized);
                            stream.Write(data, 0, data.Length);
                            textBox.Text += "\r\nGET_ALL";
                        }

                        if (message.Equals("EDIT"))
                        {
                            //read computer from client
                            do
                            {
                                bytes = stream.Read(data, 0, data.Length);
                                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                            } while (stream.DataAvailable);

                            var computer = builder.ToString().DeserializeString<Computer>();
                            ComputerService.EditComputer(computer);
                            textBox.Text += "\r\nComputer edited";

                            //send store to client
                            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
                            var storeSerialized = computerFromFile.SerializeToString();
                            data = Encoding.Unicode.GetBytes(storeSerialized);
                            stream.Write(data, 0, data.Length);
                            textBox.Text += "\r\nGET_ALL";
                        }

                        if (message.Equals("DELETE"))
                        {
                            //read computer from client
                            do
                            {
                                bytes = stream.Read(data, 0, data.Length);
                                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                            } while (stream.DataAvailable);

                            var computer = builder.ToString().DeserializeString<Computer>();
                            ComputerService.DeleteComputer(computer);
                            textBox.Text += "\r\nComputer deleted";

                            //send store to client
                            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
                            var storeSerialized = computerFromFile.SerializeToString();
                            data = Encoding.Unicode.GetBytes(storeSerialized);
                            stream.Write(data, 0, data.Length);
                            textBox.Text += "\r\nGET_ALL";
                        }

                        if (message.Equals("FIND"))
                        {
                            //read computer from client
                            do
                            {
                                bytes = stream.Read(data, 0, data.Length);
                                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                            } while (stream.DataAvailable);

                            var computer = builder.ToString().DeserializeString<Computer>();
                            var store = ComputerService.FindComputerByBrand(computer);
                            textBox.Text += "\r\nComputer found";

                            //send store to client
                            var storeSerialized = store.SerializeToString();
                            data = Encoding.Unicode.GetBytes(storeSerialized);
                            stream.Write(data, 0, data.Length);
                            textBox.Text += "\r\nFIND";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                    if (client != null)
                        client.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}