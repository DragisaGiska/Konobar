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
    public partial class Konobar : Form
    {
        public Konobar(string ime_konobara,Image slika)
        {
            InitializeComponent();
            this.Text = ime_konobara;
            this.pictureBoxKonobar.Image = slika;
            labelKonobar.Text = ime_konobara;
            this.listBoxPonuda.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));//Da bi bilo poravnato
            this.listBoxRacun.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ispuniPonudu();
        }



        private void ispuniPonudu()
        {
            listBoxPonuda.Items.Add(new Pica("Fanta",2.00f));
            listBoxPonuda.Items.Add(new Pica("Sok jabuka", 2.50f));
            listBoxPonuda.Items.Add(new Pica("Sok narandza", 2.50f));
            listBoxPonuda.Items.Add(new Pica("Sok jagoda", 3.00f));
            listBoxPonuda.Items.Add(new Pica("Coca Cola", 2.00f));
        }

        private void buttonPonudaURacun_Click(object sender, EventArgs e)
        {
           
            // string artikal = listBoxPonuda.GetItemText(listBoxPonuda.SelectedItem);
            try
            {
               // if (string.IsNullOrWhiteSpace(artikal))
                {
                    //throw new Exception("Niste selektovali ni jedan artikal iz ponuda.");
                }
                //listBoxRacun.Items.Add(artikal);
                listBoxRacun.Items.Add(listBoxPonuda.SelectedItem);
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Niste selektovali ni jedan artikal iz ponude.");
            }
            
        }

        private void buttonIzbaciIzRacuna_Click(object sender, EventArgs e)
        {
            listBoxRacun.Items.Remove(listBoxRacun.SelectedItem);
        }

        private void buttonIzdajRacun_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
            }
            catch (NotImplementedException ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Račun:\n\t" + ispis_narudzbe());
                this.Hide();
                FormPin form_pin = new FormPin();
                form_pin.FormClosed += (s, args) => this.Close();
                form_pin.Show();
            }
        }

        private float IzracunajRacun()
        {
            float racun = 0;
            foreach (Pica item in listBoxRacun.Items)
            {
                racun += item.Cijena;
            }
            return racun;
        }
        private string ispis_narudzbe()
        {
            string narudzba = "";
            foreach (Pica item in listBoxRacun.Items)
            {
                narudzba +="\n\t"+ item.ToString();
            }
            return narudzba+"\n\n\n\tUkupna cijena: "+IzracunajRacun()+"KM";
        }


        void Test() { throw new NotImplementedException(); }

    }
}
