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
    public partial class FrmSekreterdenDoktorPaneli : Form
    {
        public FrmSekreterdenDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterdenDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            DgwDoktorGoruntuleme.DataSource = dt;
            bgl.baglanti().Close();



            //Branş COmbobox ı 
            SqlCommand komut2 = new SqlCommand("Select BransAD From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmdBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_DOktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmdBrans.Text);
            komut.Parameters.AddWithValue("@d4", MsdTc.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Eklemee İşlmeniz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAd.Text = null;
            TxtSoyad.Text = null;
            CmdBrans.Text = null;
            MsdTc.Text = null;
            TxtSifre.Text = null;
            TxtAd.Focus();
        }

        private void CmdBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DgwDoktorGoruntuleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwDoktorGoruntuleme.SelectedCells[0].RowIndex;
            TxtAd.Text = DgwDoktorGoruntuleme.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = DgwDoktorGoruntuleme.Rows[secilen].Cells[2].Value.ToString();
            CmdBrans.Text = DgwDoktorGoruntuleme.Rows[secilen].Cells[3].Value.ToString();
            MsdTc.Text = DgwDoktorGoruntuleme.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = DgwDoktorGoruntuleme.Rows[secilen].Cells[5].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", MsdTc.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işleminiz gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            TxtAd.Text = null;
            TxtSoyad.Text = null;
            CmdBrans.Text = null;
            MsdTc.Text = null;
            TxtSifre.Text = null;
            TxtAd.Focus();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutU = new SqlCommand("Update Tbl_Doktor set DoktorAd=@d1,DOktorSoyad=@d2,DoktorBrans=@d3,DoktorTC=@d4,DoktorSifre=@d5", bgl.baglanti());
            komutU.Parameters.AddWithValue("@d1", TxtAd.Text);
            komutU.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komutU.Parameters.AddWithValue("@d3", CmdBrans.Text);
            komutU.Parameters.AddWithValue("@d4", MsdTc.Text);
            komutU.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komutU.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşleminiz gerçekleşti.","Bİlgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            TxtAd.Text = null;
            TxtSoyad.Text = null;
            CmdBrans.Text = null;
            MsdTc.Text = null;
            TxtSifre.Text = null;
            TxtAd.Focus();

        }
    }
}
