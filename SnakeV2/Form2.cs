using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeV2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetNames(typeof(Snake.Color));
            comboBox2.DataSource = Enum.GetNames(typeof(Game.Difficulty));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Snake.Color ColorChoice;
            Enum.TryParse<Snake.Color>(comboBox1.SelectedValue.ToString(), out ColorChoice);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game.Difficulty GameDifficulty;
            Enum.TryParse<Game.Difficulty>(comboBox1.SelectedValue.ToString(), out GameDifficulty);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Location = this.Location;
            form3.Show();
        }

    }
}
