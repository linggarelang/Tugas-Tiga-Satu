using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            labelNim.Text = "NIM : ";
            labelNama.Text = "Nama : ";
            labelKelas.Text = "Kelas : ";


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            labelNim.Text = "NIM : 22.11.4849";
            labelNama.Text = "Nama : Linggar Elang Pratama";
            labelKelas.Text = "Kelas : Informatika 05";
        }
    }
}
