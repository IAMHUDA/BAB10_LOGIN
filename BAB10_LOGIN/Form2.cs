using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAB10_LOGIN
{
    public partial class Form2 : Form
    {
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = informasiMhs;; " +
            "Integrated Security = True;MultipleActiveResultSets=true";
        public Form2(string namaKar)
        {
            InitializeComponent();
            tKar.Text = namaKar;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informasiMhsDataSet.MK' table. You can move, or remove it, as needed.
            this.mKTableAdapter.Fill(this.informasiMhsDataSet.MK);
            // TODO: This line of code loads data into the 'informasiMhsDataSet.KRS' table. You can move, or remove it, as needed.
            this.kRSTableAdapter.Fill(this.informasiMhsDataSet.KRS);

        }

        private void NIM_TextChanged(object sender, EventArgs e)
        {
            if (NIM.Text.Length > 0)
            {
                string sql = "SELECT Nama FROM InfoMahasiswa WHERE NIM = @nim";
                SqlConnection connection = new SqlConnection(strKoneksi);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nim", NIM.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string namaMhs = dr["Nama"].ToString();
                    Nama.Text = namaMhs;
                    SqlDataAdapter da = new SqlDataAdapter("select * from MK", connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cbMK.DisplayMember = "namaMK";
                    cbMK.ValueMember = "namaMK";
                    cbMK.DataSource = ds.Tables[0];

                    cbMK.Enabled = true;
                }
                else
                {
                    Nama.Text = "";
                    cbMK.ValueMember = null;
                    cbMK.Enabled = false;
                }
                connection.Close();
            }

        }

        private void cbMK_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();

            SqlCommand cmd = new SqlCommand("CekdataMK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nim", NIM.Text);
            cmd.Parameters.AddWithValue("@nmMK", cbMK.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Matakuliah sudah diinputkan!", "Duplikasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.DataSource = null;
                tbiaya.Text = string.Empty;
                tsks.Text = string.Empty;
                tSisa.Text = string.Empty;
                btnUpload.Enabled = false;
            }
            else
            {
                SqlCommand cm = new SqlCommand("dataMK", connection);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@nim", NIM.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[1].DefaultCellStyle.Format = "C";
                    dataGridView1.Columns[1].DefaultCellStyle.FormatProvider =
                        CultureInfo.GetCultureInfo("id-ID");
                }
                if (dataTable.Rows.Count == 0)
                {
                    SqlCommand sqlCommand = new SqlCommand("detailkrsNew", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@nmMK", cbMK.Text);
                    SqlDataReader sdr = sqlCommand.ExecuteReader();
                    while (sdr.Read())
                    {
                        int biaya = Convert.ToInt32(sdr["harga"]);
                        tbiaya.Text = biaya.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
                        tsks.Text = sdr["sks"].ToString();
                        int bayar = Convert.ToInt32(sdr["harga"]);
                        tSisa.Text = bayar.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
                    }
                    sdr.Close();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("detailkrs", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@nim", NIM.Text);
                    sqlCommand.Parameters.AddWithValue("@nmMK", cbMK.Text);
                    SqlDataReader sdr = sqlCommand.ExecuteReader();
                    while (sdr.Read())
                    {
                        int biaya = Convert.ToInt32(sdr["biaya"]);
                        tbiaya.Text = biaya.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
                        tsks.Text = sdr["SKS"].ToString();
                        int bayar = Convert.ToInt32(sdr["hargaMk"]);
                        tSisa.Text = bayar.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
                    }
                    sdr.Close();
                }
                btnUpload.Enabled = true;
            }
            dr.Close();
            connection.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                if (tBukti.Text == null)
                {
                    tBukti.Text = dlg.FileName;
                }
                else
                {
                    tBukti.Clear();
                    tBukti.Text = dlg.FileName;
                }
            }

        }

        private void bttnadd_Click(object sender, EventArgs e)
        {
            string kdMatkul = "";
            int NIK = 0;
            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("cek_KdMk", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@nmMK", cbMK.Text);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            if (sdr.Read())
            {
                kdMatkul = sdr["kdMK"].ToString();
            }
            sdr.Close();
            SqlCommand cmd = new SqlCommand("cekNIK", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nm", tKar.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NIK = Convert.ToInt32(dr["NIK"]);
            }
            dr.Close();

            string nomik = tbiaya.Text.Replace(".", "");
            string nok = nomik.Replace("Rp", "");
            string nokk = nok.Replace(",00", "");
            float nk = 0;
            float.TryParse(nokk, out nk);
            string sisa = tSisa.Text.Replace(".", "");
            string sisau = sisa.Replace("Rp", "");
            string sisaa = sisau.Replace(",00", "");
            float sua = 0;
            float.TryParse(sisaa, out sua);

            DialogResult dg;
            dg = MessageBox.Show("Apakah data yang anda masukan sudah sesuai?",
            "Konfirmasi Tambah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    string bKT = tBukti.Text;
                    string exd = Path.GetExtension(bKT);
                    string pth = @"C:\Dotahs\DataPembayaran\";
                    string BBayar = pth + NIM.Text + "BuktiBayar" + cbMK.Text + exd;
                    string str = "insert into KRS (NIM, NIK, kdMK, totalpembayaran," +
                    "buktipembayaran, totalsks, sisapembayaran) " +
                    "values (@nim, @nik, @kdek, @tp, @bp, @ts, @sp)";
                    SqlCommand cm = new SqlCommand(str, connection);
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.Add(new SqlParameter("nim", NIM.Text));
                    cm.Parameters.Add(new SqlParameter("nik", NIK));
                    cm.Parameters.Add(new SqlParameter("kdek", kdMatkul));
                    cm.Parameters.Add(new SqlParameter("tp", nk));
                    cm.Parameters.Add(new SqlParameter("bp", BBayar));
                    cm.Parameters.Add(new SqlParameter("ts", tsks.Text));
                    cm.Parameters.Add(new SqlParameter("sp", sua));
                    cm.ExecuteNonQuery();
                    string currentPath = "C:\\";
                    if (!Directory.Exists(Path.Combine(currentPath, "DataMhs",
                    "DataPembayaran")))
                    {
                        try
                        {
                            //make new folder in disk
                            Directory.CreateDirectory(pth);
                        }
                        catch (FileNotFoundException ex)
                        {
                            // Write error.
                            MessageBox.Show(ex.ToString());
                        }
                        //copy file photo to new folder
                        File.Copy(tBukti.Text, BBayar);
                    }
                    else
                    {
                        if (File.Exists(BBayar))
                        {
                            //copy file photo to folder
                            File.Copy(tBukti.Text, BBayar);
                        }
                    }
                    MessageBox.Show("Data Berhasil Diinputkan", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    connection.Close();
                    refreshform();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    refreshform();
                }
            }

        }
        private void refreshform()
        {
            NIM.Text = string.Empty;
            Nama.Text = string.Empty;
            cbMK.DataSource = null;
            cbMK.Enabled = false;
            dataGridView1.DataSource = null;
            tbiaya.Text = string.Empty;
            tsks.Text = string.Empty;
            tSisa.Text = string.Empty;
            tBukti.Text = string.Empty;
            btnUpload.Enabled = false;
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }
    }
}
