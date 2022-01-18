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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            //AcceptButton Kısmına şu tuşa basılınca bu butona basılma isteği için örneği bu butona gelir 
            //properties dedikten sonra AcceptButton da bu buttonu seçersek enter tuşuna basıldığında kayıt 
            // basılmış gibi olur.
            SqlCommand komut = new SqlCommand("insert into Tbl_Hasta (HastaAd,HastaSoyad,HastaTC,HastaTelefon," +
               "HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MsdTextTc.Text);
            komut.Parameters.AddWithValue("@p4", MsdTxtTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt işleminiz gerçekleşmiştir. Şifreniz:" + TxtSifre.Text,/*Başlık parametresi bölümü*/
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
