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
    public partial class FrmDoktorPanel : Form
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string Tc;
        private void FrmDoktorPanel_Load(object sender, EventArgs e)
        {
            //Tc kimlik ve Ad soyad alma 
            LblDoktorTc.Text = Tc;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblDoktorAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            
            //Randevuları alma 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu where RandevuDoktor='"+ LblDoktorAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            DgwRandevuListesi.DataSource = dt;
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBİlgiDuzenle fr1 = new FrmDoktorBİlgiDuzenle();
            fr1.TCNO = LblDoktorTc.Text;
            fr1.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr2 = new FrmDuyurular();
            fr2.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DgwRandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwRandevuListesi.SelectedCells[0].RowIndex;
            RTxtSikayet.Text = DgwRandevuListesi.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
