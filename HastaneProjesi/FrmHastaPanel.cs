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
    public partial class FrmHastaPanel : Form
    {
        public FrmHastaPanel()
        {
            InitializeComponent();
        }
        public string TCNo;
       
        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutUpdate = new SqlCommand("Update Tbl_Randevu set  RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where RandevuId=@p3", bgl.baglanti());
            komutUpdate.Parameters.AddWithValue("@p1", LblTC.Text);
            komutUpdate.Parameters.AddWithValue("@p2", RTxtSikayet.Text);
            komutUpdate.Parameters.AddWithValue("@p3", TxtId.Text);
            komutUpdate.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz alınmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            TxtId.Text = null;
            CmdBrans.Text = null;
            CmdDoktor.Text = null;
            RTxtSikayet.Text = null;
            
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaPanel_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCNo;
            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hasta Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu where HastaTC="+TCNo,bgl.baglanti());
            da.Fill(dt);
            DgwRandevuGecmisi.DataSource = dt;

            //Branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmdBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

          
           


        }

        private void CmdDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevu where RandevuBrans='" + CmdBrans.Text+"'"+"and RandevuDoktor='"+CmdDoktor.Text+ "' and RandevuDurum=0", bgl.baglanti());
            //SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Randevu", bgl.baglanti());
            da1.Fill(dt1);
            DgwAktifRandevular.DataSource = dt1; 

        }

        private void CmdBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmdDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmdBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmdDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.TcNo = LblTC.Text;
            fr.Show();

        }

        private void DgwAktifRandevular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwAktifRandevular.SelectedCells[0].RowIndex;
            TxtId.Text = DgwAktifRandevular.Rows[secilen].Cells[0].Value.ToString();

        }
    }
}
