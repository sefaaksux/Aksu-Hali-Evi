﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
{
    public partial class anasayfa : Form
    {
        
        public anasayfa()
        {
            InitializeComponent();
        }

        private void hedefDegistir(Form Frm)
        {
            hedefPanel.Controls.Clear();
            Frm.MdiParent = this;
            hedefPanel.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_paragirisisayfa_Click_1(object sender, EventArgs e)
        {          
            ParaGirisi frm = new ParaGirisi();
            hedefDegistir(frm);          
        }

        private void btn_paracikisisayfa_Click_1(object sender, EventArgs e)
        {          
            ParaCikisi paraCikisi = new ParaCikisi();
            hedefDegistir(paraCikisi);         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            ParaGirisListele frm = new ParaGirisListele();
            hedefDegistir(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            ParaCikisiListele frm = new ParaCikisiListele();
            hedefDegistir(frm);
        }


        private void lbl_anasayfa_Click(object sender, EventArgs e)
        {
            ResimGetir resimGetir = new ResimGetir();
            hedefDegistir(resimGetir);
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            ResimGetir resimGetir = new ResimGetir();
            hedefDegistir(resimGetir);
        }

        private void btn_kasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void btn_borcGir_Click(object sender, EventArgs e)
        {
            BorcGir borcGir = new BorcGir();
            hedefDegistir(borcGir);
        }

        private void btn_borcDus_Click(object sender, EventArgs e)
        {
            BorcDus borcDus = new BorcDus();
            hedefDegistir(borcDus);
        }

        private void btn_borcListele_Click(object sender, EventArgs e)
        {
            BorcListele borcListele = new BorcListele();
            hedefDegistir(borcListele);
        }

        private void btn_islemDuzenle_Click(object sender, EventArgs e)
        {
            İslemDuzenlemeSecim islemDuzenlemeSecim = new İslemDuzenlemeSecim();
            islemDuzenlemeSecim.Show();
        }

        private void btn_paragirisListe_Click(object sender, EventArgs e)
        {
           ParaGirisListele paraGirisListele = new ParaGirisListele();
            hedefDegistir(paraGirisListele);
        }

        private void btn_paracikisListe_Click(object sender, EventArgs e)
        {
            ParaCikisiListele paraCikisiListele = new ParaCikisiListele();
            hedefDegistir(paraCikisiListele);
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitEkle kayitEkle = new KayitEkle();
            kayitEkle.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimGetir resimGetir = new ResimGetir();
            hedefDegistir(resimGetir);
        }

        private void cikisStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ödemeYöntemiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeYöntemiEkle odemeYöntemiEkle = new OdemeYöntemiEkle();
            odemeYöntemiEkle.Show();
            this.Close();
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
