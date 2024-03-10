using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri_3Toplama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        double Sonuc, AnsTemp, MainTemp;
        bool AnsVarMi = false, Shift = false;
        int VirgulSayac = 0;

        private void AnsRes()
        {
            AnsVarMi = false;
            AnsTemp = 0;
        }

        private bool KontrolV2()
        {
            if (Ekran.Text.Length == 0 || Ekran.Text == "Hata 13" || Ekran.Text == "Matematiksel\nHata\n Kod: 11" || Ekran.Text == "NaN" || Ekran.Text == "∞" || Ekran.Text == "-∞")
            {
                if (Ekran.Text.Length == 0 || Ekran.Text == "Hata 13")
                {
                    Ekran.Text = "Hata 13";
                    Lbl_Hata.Text = "Değer girilmedi!";
                    return false;
                }
                return false;
            }
            else
                return true;
        }

        private void Kontrol(string secim, int Num)
        {
            switch (secim)
            {
                case "islem":
                    if (Ekran.Text.Length == 0 || Ekran.Text == "Hata 13" || Ekran.Text == "Matematiksel\nHata\n Kod: 11" || Ekran.Text == "NaN" || Ekran.Text == "∞" || Ekran.Text == "-∞")
                    {
                        if (Ekran.Text == "Hata 13")
                        {
                            Ekran.Text = "Hata 13";
                            Lbl_Hata.Text = "Değer girilmedi!";
                        }
                    }
                    else
                    {
                        switch (AnsVarMi)
                        {
                            case true: break;
                            case false:
                                MainTemp = Convert.ToDouble(Ekran.Text);
                                Ekran.Text = "";
                                break;
                        }
                    }
                    break;
                case "numerik":
                    if (Ekran.Text == "Hata 13" || Ekran.Text == "Matematiksel\nHata\n Kod: 11" || Ekran.Text == "NaN" || Ekran.Text == "∞" || Ekran.Text == "-∞")
                    {
                        Ekran.Text = "";
                    }
                    else
                    {
                        Ekran.Text = Ekran.Text + Convert.ToString(Num);
                    }
                    break;
            }
        }

        private void Buton_Shift(object Label, string LabelIsim, object Button, string ButonIsim)
        {
            System.Windows.Forms.Label Lbl = (System.Windows.Forms.Label)Label;
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)Button;
            switch (Shift)
            {
                case false:

                    Lbl.Text = ButonIsim;
                    Lbl.ForeColor = Color.Black;

                    Btn.Text = LabelIsim;
                    Btn.ForeColor = Color.DarkOrange;
                    break;

                case true:
                    Lbl.Text = LabelIsim;
                    Lbl.ForeColor = Color.DarkOrange;

                    Btn.Text = ButonIsim;
                    Btn.ForeColor = Color.Black;
                    break;
            }
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 0);
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 1);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 2);
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 3);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 4);
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 5);
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 6);
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 7);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            this.Kontrol("numerik", 8);
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            
            hakkımda Hk = new hakkımda();
            switch (Shift)
            {
                case true:
                    

                    Hk.ShowDialog();
                    break;
                case false: this.Kontrol("numerik", 9); break;
            }
            
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            hakkımda Hk = new hakkımda();
            switch (Shift)
            {
                case true:

                    

                    Ekran.Text = "";
                    Lbl_Hata.Text = "Def";
                    MainTemp = 0;
                    Sonuc = 0;

                    break;

                case false:
                    if (KontrolV2() == true)
                    {
                        int uzunluk = Ekran.TextLength;
                        string YeniSonuc = Ekran.Text, SonSonuc = "";
                        for (int i = 0; i < uzunluk - 1; i++)
                        {
                            SonSonuc += Ekran.Text[i];
                        }
                        Ekran.Text = "";
                        Ekran.Text = SonSonuc;
                    }
                    else
                    {
                        Ekran.Text = "";
                    }
                    break;
            }

        }
        private void Btn_Shift_Click(object sender, EventArgs e)
        {
            switch (Shift)
            {
                case false:
                    Btn_Shift.BackColor = Color.LightGreen;
                    Buton_Shift(Lbl_Cos, "cos-1", Btn_Cos, "cos");      /* Cos butonu */
                    Buton_Shift(Lbl_Sin, "sin-1", Btn_Sin, "sin");      /* Sin butonu */
                    Buton_Shift(Lbl_Hk, "Hk", Btn_9, "9");            /* 9 butonu */
                    Buton_Shift(Lbl_Clr, "CLR", Btn_Sil, "🠐");           /* Sil butonu */
                    Shift = true;
                    break;

                case true:
                    Btn_Shift.BackColor = Color.White;
                    Buton_Shift(Lbl_Cos, "cos-1", Btn_Cos, "cos");      /* Cos butonu */
                    Buton_Shift(Lbl_Sin, "sin-1", Btn_Sin, "sin");      /* Sin butonu */
                    Buton_Shift(Lbl_Hk, "Hk", Btn_9, "9");            /* 9 butonu */
                    Buton_Shift(Lbl_Clr, "CLR", Btn_Sil, "🠐");           /* Sil butonu */
                    Shift = false;
                    break;
            }
        }
        private void Btn_Topla_Click(object sender, EventArgs e)
        {
            this.Kontrol("islem",-1);
            Lbl_Hata.Text = "Toplam";
        }
        private void Btn_Cikar_Click(object sender, EventArgs e)
        {
            this.Kontrol("islem", -1);
            Lbl_Hata.Text = "Cikarma";
        }
        private void Btn_Bol_Click(object sender, EventArgs e)
        {
            this.Kontrol("islem",-1);
            Lbl_Hata.Text = "Bolme";
        }
        private void Btn_Carp_Click(object sender, EventArgs e)
        {
            this.Kontrol("islem", -1);
            Lbl_Hata.Text = "Carpma";
        }
        private void Btn_Ans_Click(object sender, EventArgs e)
        {
            this.Kontrol("islem",-1);
            AnsVarMi = true;

        }

       

        
        private double Radyan_Derece(double girdi)
        {
            double Derece = -1;
            Derece = girdi * 180 / Math.PI;
            return Derece;
        }
        private double Derece_Radyan(double girdi)
        {
            double Radyan = -1;
            Radyan = girdi * Math.PI / 180;
            return Radyan;
        }
        private void Btn_Cos_Click(object sender, EventArgs e)
        {
            if (KontrolV2() == true)
            {
                switch (Shift)
                {
                    case true:
                        Lbl_Hata.Text = "cos-1";
                        if (Convert.ToDouble(Ekran.Text) > 1)
                        {
                            Ekran.Text = "Matematiksel\nHata\n Kod: 11";
                            Lbl_Hata.Text = "Değer 1'den büyük olamaz";
                        }
                        else
                        {
                            MainTemp = Convert.ToDouble(Ekran.Text);
                            Ekran.Text = "";
                            Ekran.Text = Convert.ToString(Radyan_Derece(Math.Acos(MainTemp)));
                        }
                        break;
                    case false:
                        Lbl_Hata.Text = "cos";
                        MainTemp = Convert.ToDouble(Ekran.Text);
                        Ekran.Text = "";
                        Ekran.Text = Convert.ToString(Math.Cos(Derece_Radyan(MainTemp)));
                        break;
                }
            }
        }
        private void Btn_sin_Click(object sender, EventArgs e)
        {
            if (KontrolV2() == true)
            {
                switch (Shift)
                {
                    case true:
                        Lbl_Hata.Text = "sin-1";
                        if (Convert.ToDouble(Ekran.Text) > 1)
                        {
                            Ekran.Text = "Matematiksel\nHata\n Kod: 11";
                            Lbl_Hata.Text = "Değer 1'den büyük olamaz";
                        }
                        else
                        {
                            Lbl_Hata.Text = "sin";
                            MainTemp = Convert.ToDouble(Ekran.Text);
                            Ekran.Text = "";
                            Ekran.Text = Convert.ToString(Radyan_Derece(Math.Asin(MainTemp)));
                        }
                        break;
                    case false:
                        MainTemp = Convert.ToDouble(Ekran.Text);
                        Ekran.Text = "";
                        Ekran.Text = Convert.ToString(Math.Sin(Derece_Radyan(MainTemp)));
                        break;
                }
            }
        }

        private void Ekran_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = e.KeyValue;
            switch (ascii)
            {
                case 8: Btn_Sil_Click(this, EventArgs.Empty);  break;
                case 13: Btn_Esittir_Click(this, EventArgs.Empty); break;
                case 39: Btn_Ans_Click(this, EventArgs.Empty); break;
                case 83: Btn_Shift_Click(this, EventArgs.Empty); break;
                case 88: Btn_sin_Click(this, EventArgs.Empty); break;
                case 90: Btn_Cos_Click(this, EventArgs.Empty); break;
                case 96: Btn_0_Click(this, EventArgs.Empty); break;
                case 97: Btn_1_Click(this, EventArgs.Empty); break;
                case 98: Btn_2_Click(this, EventArgs.Empty); break;
                case 99: Btn_3_Click(this, EventArgs.Empty); break;
                case 100: Btn_4_Click(this, EventArgs.Empty); break;
                case 101: Btn_5_Click(this, EventArgs.Empty); break;
                case 102: Btn_6_Click(this, EventArgs.Empty); break;
                case 103: Btn_7_Click(this, EventArgs.Empty); break;
                case 104: Btn_8_Click(this, EventArgs.Empty); break;
                case 105: Btn_9_Click(this, EventArgs.Empty); break;
                case 106: Btn_Carp_Click(this, EventArgs.Empty); break;
                case 107: Btn_Topla_Click(this, EventArgs.Empty); break;
                case 109: Btn_Cikar_Click(this, EventArgs.Empty); break;
                case 110: Btn_Virgul_Click(this, EventArgs.Empty); break;
                case 111: Btn_Bol_Click(this, EventArgs.Empty); break;
                
            }
        }

        /*
         private void Ekran_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = e.KeyValue;
            switch (ascii)
            {
                case 8: Btn_Sil_Click(this, EventArgs.Empty);  break;
                case 13: Btn_Esittir_Click(this, EventArgs.Empty); break;
                case 39: Btn_Ans_Click(this, EventArgs.Empty); break;
                case 83: Btn_Shift_Click(this, EventArgs.Empty); break;
                case 88: Btn_sin_Click(this, EventArgs.Empty); break;
                case 90: Btn_Cos_Click(this, EventArgs.Empty); break;
                case 96: Btn_0_Click(this, EventArgs.Empty); break;
                case 97: Btn_1_Click(this, EventArgs.Empty); break;
                case 98: Btn_2_Click(this, EventArgs.Empty); break;
                case 99: Btn_3_Click(this, EventArgs.Empty); break;
                case 100: Btn_4_Click(this, EventArgs.Empty); break;
                case 101: Btn_5_Click(this, EventArgs.Empty); break;
                case 102: Btn_6_Click(this, EventArgs.Empty); break;
                case 103: Btn_7_Click(this, EventArgs.Empty); break;
                case 104: Btn_8_Click(this, EventArgs.Empty); break;
                case 105: Btn_9_Click(this, EventArgs.Empty); break;
                case 106: Btn_Carp_Click(this, EventArgs.Empty); break;
                case 107: Btn_Topla_Click(this, EventArgs.Empty); break;
                case 109: Btn_Cikar_Click(this, EventArgs.Empty); break;
                case 110: Btn_Virgul_Click(this, EventArgs.Empty); break;
                case 111: Btn_Bol_Click(this, EventArgs.Empty); break;
                
            }
        }
         */



        private void Btn_Virgul_Click(object sender, EventArgs e)
        {
            if (KontrolV2() == true)
            {
                VirgulSayac = 0;
                for (int i = 0; i < Ekran.TextLength; i++)
                {
                    if (Ekran.Text[i] == ',')
                    {
                        VirgulSayac++;
                    }
                }
                if (VirgulSayac >= 1)
                {

                }
                else
                {
                    Ekran.Text = Ekran.Text + ",";
                    VirgulSayac++;
                }
            }
        }
        
        private void Btn_Esittir_Click(object sender, EventArgs e)
        {
            if (KontrolV2() == true)
            {
                switch (Lbl_Hata.Text)
                {
                    case "Toplam":
                        switch (AnsVarMi)
                        {
                            case true:
                                Sonuc = Convert.ToDouble(Ekran.Text) + AnsTemp;
                                AnsRes();
                                Lbl_Hata.Text = "Def";
                                break;
                            case false:
                                Sonuc = Convert.ToDouble(Ekran.Text) + MainTemp;
                                Lbl_Hata.Text = "Def";
                                break;
                        }
                        break;
                    case "Cikarma":
                        switch (AnsVarMi)
                        {
                            case true:
                                Sonuc = AnsTemp - Convert.ToDouble(Ekran.Text);
                                AnsRes();
                                Lbl_Hata.Text = "Def";
                                break;
                            case false:
                                Sonuc = MainTemp - Convert.ToDouble(Ekran.Text);
                                Lbl_Hata.Text = "Def";
                                break;
                        }
                        break;
                    case "Bolme":
                        switch (AnsVarMi)
                        {
                            case true:
                                Sonuc = AnsTemp / Convert.ToDouble(Ekran.Text);
                                AnsRes();
                                Lbl_Hata.Text = "Def";
                                break;
                            case false:
                                Sonuc = MainTemp / Convert.ToDouble(Ekran.Text);
                                Lbl_Hata.Text = "Def";
                                break;
                        }
                        break;
                    case "Carpma":
                        switch (AnsVarMi)
                        {
                            case true:
                                Sonuc = Convert.ToDouble(Ekran.Text) * AnsTemp;
                                AnsRes();
                                Lbl_Hata.Text = "Def";
                                break;

                            case false:
                                Sonuc = Convert.ToDouble(Ekran.Text) * MainTemp;
                                Lbl_Hata.Text = "Def";
                                break;
                        }
                        break;
                    case "Def": break;

                }
                Ekran.Text = "";
                Ekran.Text = Convert.ToString(Sonuc);
            }else Ekran.Text = "";
        }
    }
}
