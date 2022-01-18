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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //Ad soyad Aktarma
            LblSekreterTC.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblSekreterAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            DgwBranslar.DataSource = dt;
            bgl.baglanti().Close();

            //Doktorları Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktor',DoktorBrans as 'Branş' From Tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            DtwDoktorlar.DataSource = dt2;

            //Branşları Combobox a aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmdRandevuBrans.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void BtnRandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", MsdRandevuTarih.Text);
            komut2.Parameters.AddWithValue("@r2", MsdRandevuSaat.Text);
            komut2.Parameters.AddWithValue("@r3", CmdRandevuBrans.Text);
            komut2.Parameters.AddWithValue("@r4", CmdRandevuDoktor.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydetme işleminiz gerçekleşmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CmdRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmdRandevuDoktor.Items.Clear();
            SqlCommand komut4 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1",bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", CmdRandevuBrans.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                CmdRandevuDoktor.Items.Add(dr4[0] + " " + dr4[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand KomutDuyuru = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)", bgl.baglanti());
            KomutDuyuru.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            KomutDuyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyurunuz oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RchDuyuru.Text = null;
            RchDuyuru.Focus();
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmSekreterdenDoktorPaneli fr = new FrmSekreterdenDoktorPaneli();
            fr.Show();
            
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmSekreterdenBransaPaneli fr1 = new FrmSekreterdenBransaPaneli();
            fr1.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr2 = new FrmRandevuListesi();
            fr2.Show();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr3 = new FrmDuyurular();
            fr3.Show();
        }
    }
}
