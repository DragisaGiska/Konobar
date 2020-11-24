using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._4._2014.kafic
{
    public partial class FormPin : System.Windows.Forms.Form
    {
        public FormPin()
        {
            InitializeComponent();
            textBoxPin.TabStop = false;
            buttonClear.Enabled = false;
            buttonEnter.Enabled = false;
            this.toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy     HH:mm:ss");
            
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy     HH:mm:ss");
        }

        private void FormPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                buttonClear.PerformClick();
            }
            else if (textBoxPin.TextLength<textBoxPin.MaxLength)
            {
                    foreach (Button b in tableLayoutPanelButtons.Controls)
                    {
                        if (b.Text == e.KeyChar.ToString())
                        {
                            b.Focus();
                            textBoxPin.Text += e.KeyChar.ToString();
                            enableEnterOrClear();
                        }
                    }
            }
            buttonEnter.Focus();

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBoxPin.TextLength < textBoxPin.MaxLength)
            {
                Button b = (Button)sender;
                textBoxPin.Text += b.Text;
                enableEnterOrClear();
            }
            buttonEnter.Focus();

        }

        private void enableEnterOrClear()
        {
            if (textBoxPin.TextLength > 0)
            {
                buttonClear.Enabled = true;
            }
            if (textBoxPin.TextLength > 3)
            {
                buttonEnter.Enabled = true;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPin.Clear();
            buttonEnter.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPin.Text == "1234")
            {
                this.Hide();
                Konobar konobar = new Konobar("Petar Petrović", Properties.Resources.konobar);
                konobar.FormClosed += (s, args) => this.Close();
                konobar.Show();

            }
            else if (textBoxPin.Text == "4321")
            {
                this.Hide();
                Konobar konobar = new Konobar("Ivana Ivanović",Properties.Resources.konobarica);
                konobar.FormClosed += (s, args) => this.Close();
                konobar.Show();
            }
            else
            {
                MessageBox.Show("Pogrešan pin.");
                buttonClear.PerformClick();
            }
        }


    }
}
