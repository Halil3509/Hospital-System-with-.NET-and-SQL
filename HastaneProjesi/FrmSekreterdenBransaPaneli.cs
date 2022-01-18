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
    public partial class FrmSekreterdenBransaPaneli : Form
    {
        public FrmSekreterdenBransaPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterdenBransaPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            DgwBransGoruntuleme.DataSource = dt;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutD = new SqlCommand("Delete From Tbl_Brans Where BransAd=@p1", bgl.baglanti());
            komutD.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            komutD.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBransAd.Text = null;
            TxtBransId.Text = null;
            TxtBransId.Focus();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand KomutI = new SqlCommand("insert into Tbl_Brans  (BransAd,BransId)  values (@i1,@i2)", bgl.baglanti());
            KomutI.Parameters.AddWithValue("@i1", TxtBransAd.Text);
            KomutI.Parameters.AddWithValue("@i2", TxtBransId.Text);
            KomutI.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşleminiz Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutU = new SqlCommand("Update Tbl_Brans set BransAd=@u1 where BransId=@u2", bgl.baglanti());
            komutU.Parameters.AddWithValue("@u1", TxtBransAd.Text);
            komutU.Parameters.AddWithValue("@u2", TxtBransId.Text);
            komutU.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işleminiz Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBransAd.Text = null;
            TxtBransId.Text = null;
            TxtBransId.Focus();
        }

        private void DgwBransGoruntuleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwBransGoruntuleme.SelectedCells[0].RowIndex;
            TxtBransId.Text = DgwBransGoruntuleme.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = DgwBransGoruntuleme.Rows[secilen].Cells[1].Value.ToString();      
        }
    }
}
