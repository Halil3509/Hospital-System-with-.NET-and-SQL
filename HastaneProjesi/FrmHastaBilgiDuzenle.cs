using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneProjesi
{
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MsdTextTc.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad,HastaTelefon,HastaSifre,HastaCinsiyet From Tbl_Hasta where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MsdTextTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[0].ToString();
                TxtSoyad.Text = dr[1].ToString();
                MsdTxtTel.Text = dr[2].ToString();
                TxtSifre.Text = dr[3].ToString();
                CmbCinsiyet.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if(checkBox1.Checked==false)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void BtnBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut2 = new SqlCommand("update Tbl_Hasta set HastaAd=@p7,HastaSoyad=@p8,HastaTelefon=@p9,HastaSifre=@p10,HastaCinsiyet=@p11 where HastaTC=@p12", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p7", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p8", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p9", MsdTxtTel.Text);
            komut2.Parameters.AddWithValue("@p10", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p11", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p12", MsdTextTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
