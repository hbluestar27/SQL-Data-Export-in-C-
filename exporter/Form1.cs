using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace exporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadUserInfo();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            string datasource = txt_datasource.Text;
            string dbname = txt_dbname.Text;
            string username = txt_user_name.Text;
            string password = txt_password.Text;

            //SetLoading(true);
            //exportToCSVfile(datasource, dbname, username, password, "dump.csv");
            //SetLoading(false);
            try
            {
                Thread threadInput = new Thread(() => DisplayData(datasource, dbname, username, password, "dump.csv"));
                threadInput.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return;
        }

        private void DisplayData(string datasource, string dbname, string username, string password, string csvfile)
        {
            SetLoading(true);
            exportToCSVfile(datasource, dbname, username, password, csvfile);
            SetLoading(false);
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox_gif.Visible = true;
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox_gif.Visible = false;
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }

        private void exportToCSVfile(string datasource, string dbname, string username, string password, string csvfile)
        {
            var encoding = Encoding.UTF8;
            var separator = ",";
            var sql = "SELECT " +
                            "p.ProductID, " +
                            "p.ProductDescription, " +
                            "p.Retail, " +
                            "ps.PuzzleStyleID, " +
                            "pr.Gender, " +
                            "ps.PuzzleStyle, " +
                            "ps.Notes, " +
                            "mc.MetalClassSKU, " +
                            "mc.MetalClass " +
                        "FROM " +
                            "Products as p " +
                            "INNER JOIN PuzzleRings as pr ON(p.ProductID = pr.ProductID) " +
                            "INNER JOIN PuzzleStyles as ps on(pr.PuzzleStyleID = ps.PuzzleStyleID) " +
                            "INNER JOIN MetalClass as mc on(pr.MetalClassSKU = mc.MetalClassSKU) " +
                        "WHERE " +
                            "ps.Notes IS NOT NULL " +
                        "ORDER BY " +
                            "ps.Notes, pr.Gender;";
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = datasource;
                builder.UserID = username;
                builder.Password = password;
                builder.InitialCatalog = dbname;

                using (SqlConnection cnn = new SqlConnection(builder.ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        try
                        {
                            saveUserInfo(datasource, dbname, username, password);

                            StreamWriter sw = new StreamWriter(csvfile, false, encoding);
                            string strRow;

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    strRow = "";
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        strRow += Regex.Replace(reader.GetValue(i).ToString(), @"\t|\n|\r", "");
                                        if (i < reader.FieldCount - 1)
                                        {
                                            strRow += separator;
                                        }
                                    }
                                    sw.WriteLine(strRow);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            MessageBox.Show("The dump.csv is used by other program. if there is no other program, please restart program.");
                            cnn.Close();
                            return;
                        }
                    }
                    cnn.Close();
                    MessageBox.Show("Complete Export!");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Connection Failed!");
            }
            return;
        }

        private void loadUserInfo()
        {
            var path = "userinfo.dat";

            try
            {
                string[] lines = File.ReadAllLines(path);
                var i = 0;
                var flag = true;
                foreach (string line in lines)
                {
                    switch (i)
                    {
                        case 0: txt_datasource.Text = line; break;
                        case 1: txt_dbname.Text = line; break;
                        case 2: txt_user_name.Text = line; break;
                        case 3: txt_password.Text = line; break;
                        default: flag = false; break;
                    }
                    i++;
                    if (!flag) break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return;
        }

        private void saveUserInfo(string datasource, string dbname, string username, string password)
        {
            var path = "userinfo.dat";

            File.WriteAllText(path, datasource + Environment.NewLine);
            File.AppendAllText(path, dbname + Environment.NewLine);
            File.AppendAllText(path, username + Environment.NewLine);
            File.AppendAllText(path, password);
        }

        private void pictureBox_gif_Click(object sender, EventArgs e)
        {

        }
    }
}
