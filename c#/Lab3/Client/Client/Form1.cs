using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using RisLab2;

namespace Client
{
    public partial class Form1 : Form
    {
        const int port = 8888;
        const string address = "127.0.0.1";
        TcpClient client = null;

        public Form1()
        {
            InitializeComponent();
            client = new TcpClient(address, port);
            SendAndGetMessageFromSocket("GET_ALL");
        }

        /**
         * destructor
         * closes socket
         */
        ~Form1()
        {
            client.Close();
        }

        private void SendAndGetMessageFromSocket(string str)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                // преобразуем сообщение в массив байтов
                byte[] data = Encoding.Unicode.GetBytes(str);
                //   отправка сообщения
                stream.Write(data, 0, data.Length);

                // получаем ответ
                data = new byte[3024]; // буфер для получаемых данных
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                } while (stream.DataAvailable);

                var store = builder.ToString().DeserializeString<ComputerStore>();
                TvListBox.Items.Clear();
                foreach (var computer in store.Computers)
                {
                    TvListBox.Items.Add(computer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SendMessageFromSocket(string str)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                // преобразуем сообщение в массив байтов
                byte[] data = Encoding.Unicode.GetBytes(str);
                //   отправка сообщения
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            string command = checkedButton.Text;

            if (command.Equals("Add"))
            {
                SendMessageFromSocket("SAVE");

                Computer computer = new Computer();
                computer.Id = textBox3.Text;
                computer.Price = textBox1.Text;
                computer.Brand = textBox2.Text;

                var serializedComp = computer.SerializeToString();
                SendAndGetMessageFromSocket(serializedComp);
            }

            if (command.Equals("Edit"))
            {
                SendMessageFromSocket("EDIT");

                Computer computer = new Computer();
                computer.Id = textBox3.Text;
                computer.Price = textBox1.Text;
                computer.Brand = textBox2.Text;

                var serializedComp = computer.SerializeToString();
                SendAndGetMessageFromSocket(serializedComp);
            }

            if (command.Equals("Delete"))
            {
                SendMessageFromSocket("DELETE");

                Computer computer = new Computer();
                computer.Id = textBox3.Text;
                computer.Price = textBox1.Text;
                computer.Brand = textBox2.Text;

                var serializedComp = computer.SerializeToString();
                SendAndGetMessageFromSocket(serializedComp);
            }

            if (command.Equals("Find by brand"))
            {
                if (textBox2.Text.Equals(""))
                {
                    SendAndGetMessageFromSocket("GET_ALL");
                }
                else
                {
                    SendMessageFromSocket("FIND");

                    Computer computer = new Computer();
                    computer.Id = "";
                    computer.Price = "";
                    computer.Brand = textBox2.Text;

                    var serializedComp = computer.SerializeToString();
                    SendAndGetMessageFromSocket(serializedComp);
                }
            }

            textBox.Text += "\r\ndata has sent to the server";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computer computer = (Computer) TvListBox.SelectedItem;

            textBox3.Text = computer.Id.ToString();
            textBox2.Text = computer.Brand;
            textBox1.Text = computer.Price.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }


        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.ReadOnly = true;
            textBox1.Clear();
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = false;
            textBox1.ReadOnly = false;
        }
    }
}