using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz6_Farkli_Sorular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kelime_bol(string st, int bas, int kaç)
        {
            string bol = st.Substring(bas, kaç);
            return bol;
        }
        // Yanlış Çalışıyor Olabilir
        //int fibon(int a)
        //{
        //    int[] dizi = new int[100];
        //    dizi[1] = 1;
        //    dizi[2] = 1;
        //    for (int i = 3; i < 100; i++)
        //    {
        //        dizi[i] = dizi[i - 1] + dizi[i - 2];
        //    }
        //    return dizi[a];
        //}
        int karakter_say(string dosya)
        {
            StreamReader sr = new StreamReader(dosya);
            int say = sr.ReadToEnd().Length;
            return say;
        }
        bool tekmi(int sayi)
        {
            bool tur;
            if (sayi % 2 == 1) tur = true;
            else tur = true;
            return tur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kelime_bol("Salihdoğan", 0, 5));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(fibon(69).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(karakter_say(@"soru3.txt").ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tekmi(9).ToString());
        }
    }
}
