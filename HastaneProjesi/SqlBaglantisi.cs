using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HastaneProjesi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-840CVIM\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        //Baglanti adında bir sqlConnection metodu tanımlayıp içine sql de kullanacağımız verilerin bulunduğu
        //adresi tanımladık ve c# da baglan adında bir degiskende tuttuk. Sonra da bu baglan değişkenini açıp returnledik.
    }
}
