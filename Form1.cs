using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Делегаты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void AccountHandler(string message);
        public class Account
        {
            int sum;
            public Account(int sum) => this.sum = sum;
            AccountHandler? taken;
            public Account(int sum) => this.sum = sum;
            public void Add(int sum) => this.sum += sum;
            public void Take(int sum)
            {
                if (this.sum >= sum) this.sum -= sum;
                {
                    this.sum -= sum;
                    Console.WriteLine($"Со счета списано {sum} у.е.");
                }
                        else
                {
                    taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");

                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
            this.sum -= sum;
            // вызываем делегат, передавая ему сообщение
            taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
               taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
            }
            }

            public void RegisterHandler(AccountHandler del)
        {
            taken = del;
        }
            private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
