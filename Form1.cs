using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kaynakveri = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] diller = { "C#", "Java", "Python", "Delphi" };
            listBox1.DataSource = diller;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            var kitap = new
            {
                Kitapadı = textBox1.Text,
                kitapyazarı = textBox2.Text,
                kitaptürü = textBox3.Text
                
        };
            kaynakveri.Add(kitap);




            listBox1.DataSource = "";
            listBox1.DataSource = kaynakveri;

            listBox1.DisplayMember = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
