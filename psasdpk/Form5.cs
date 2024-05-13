using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psasdpk
{
    
    
    public partial class Form5 : Form
    {
        private string Nama;
        private string Alamat;
        private string Nohp;
        private string Email;
        private string Tanggallahir;
        private string Tanggalreservasi;
        private string Lamamenginap;
        private string Checkin;
        private string Checkout;
        private string Tipekamar;

        public Form5(string Nama, string Alamat, string Nohp, string email, string Tanggallahir,
        string tanggalreservasi, string lamamenginap, string checkin, string checkout, string
        tipekamar)
        {
            InitializeComponent();
            this.Nama = Nama;
            this.Alamat = Alamat;
            this.Nohp = Nohp;
            this.Email = email;
            this.Tanggallahir = Tanggallahir;
            this.Tanggalreservasi = tanggalreservasi;
            this.Lamamenginap = lamamenginap;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Tipekamar = tipekamar;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = Nama;
            textBox2.Text = Alamat;
            textBox3.Text = Nohp;
            textBox4.Text = Email;
            textBox5.Text = Tanggallahir;
            textBox6.Text = Tanggalreservasi;
            textBox7.Text = Lamamenginap;
            textBox8.Text = Checkin;
            textBox9.Text = Checkout;
            textBox10.Text = Tipekamar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pesanan Anda Akan Diproses", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
