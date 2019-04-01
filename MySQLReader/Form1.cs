using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLReader
{
    public partial class Form1 : Form
    {
        //MySqlConnection cn = new MySqlConnection("port=3306;server=localhost;userid=root;password=123654;database=cosmetic");
        MySqlConnection cn = new MySqlConnection();
        MySqlDataAdapter adapdt;
        MySqlCommandBuilder cmbuil;

        MySqlDataAdapter left;
        MySqlDataAdapter right;
        MySqlCommandBuilder cmbul;
        MySqlCommandBuilder cmbur;

        public Form1()
        {
            InitializeComponent();
            Text = "MySQL Reader";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectBTN_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                cn.ConnectionString = $"port={portTB.Text};server={hostnameTB.Text};userid={usernameTB.Text};password={passwordTB.Text};database=db_books";
                cn.Open();
                DataTable dts = cn.GetSchema("Databases");

                for (int i = 0; i < dts.Rows.Count; i++)
                {
                    TreeNode tree = new TreeNode(dts.Rows[i]["database_name"].ToString());
                    treeView1.Nodes.Add(tree);
                }
                mainTabC.TabPages[1].Text = $"Server - {hostnameTB.Text}:{portTB.Text} - {usernameTB.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connecting to server");
            }
            finally
            {
                cn.Close();
            }
            //#############################################################
            try
            {
                cn.Open();
                //DataTable dts = cn.GetSchema("Databases");
                //for (int i = 0; i < dts.Rows.Count; i++)
                //{
                //    DB_CB.Items.Add(dts.Rows[i]["database_name"].ToString());
                //}

                left = new MySqlDataAdapter("select `Name_author` from `authors`", cn);
                DataTable dt = new DataTable();
                left.Fill(dt);
                SelRowCB.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                    SelRowCB.Items.Add(dt.Rows[i][0]);
                right = new MySqlDataAdapter("select * from `books`", cn);
                cmbur = new MySqlCommandBuilder(right);
                DataTable dtr = new DataTable();
                right.Fill(dtr);
                dataGridView2.DataSource = dtr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connecting to server for coupling");
            }
            finally
            {
                cn.Close();
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //double-click on database
            if (e.Node.Level == 0)
            {
                try
                {
                    e.Node.Nodes.Clear();
                    cn.Open();
                    cn.ChangeDatabase(e.Node.Text);
                    DataTable dts = cn.GetSchema("Tables");
                    for (int i = 0; i < dts.Rows.Count; i++)
                    {
                        string tablename = dts.Rows[i]["TABLE_NAME"].ToString();
                        TreeNode dbtree = new TreeNode(tablename);

                        dbtree.Nodes.AddRange(new[] { new TreeNode("Columns"), new TreeNode("Foreign Keys") });

                        DataTable schemadt = cn.GetSchema("Columns");
                        DataRow[] dtrs = schemadt.Select($"TABLE_NAME = \'{tablename}\'");
                        for (int j = 0; j < dtrs.Length; j++)
                        {
                            TreeNode coltree = new TreeNode(dtrs[j]["COLUMN_NAME"].ToString());
                            dbtree.Nodes[0].Nodes.Add(coltree);
                        }

                        schemadt = cn.GetSchema("Foreign Key Columns");
                        dtrs = schemadt.Select($"TABLE_NAME = \'{tablename}\'");
                        for (int j = 0; j < dtrs.Length; j++)
                        {
                            TreeNode foreigntree = new TreeNode
                                (
                                dtrs[j]["COLUMN_NAME"].ToString(),
                                new[] { new TreeNode(dtrs[j]["REFERENCED_TABLE_NAME"].ToString() + " . " + dtrs[j]["REFERENCED_COLUMN_NAME"].ToString()) }
                                );
                            dbtree.Nodes[1].Nodes.Add(foreigntree);
                        }

                        e.Node.Nodes.Add(dbtree);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "selecting a database");
                }
                finally
                {
                    cn.Close();
                }
            }
            else // double-click on table
            {
                if (e.Node.Level == 1)
                {
                    try
                    {
                        cn.Open();
                        cn.ChangeDatabase(e.Node.Parent.Text);
                        adapdt = new MySqlDataAdapter($"SELECT * FROM `{e.Node.Parent.Text}`.`{e.Node.Text}`;", cn);
                        cmbuil = new MySqlCommandBuilder(adapdt);
                        DataTable dt = new DataTable();
                        adapdt.Fill(dt);
                        dataGrid.DataSource = dt;
                        menuStrip1.Enabled = true;
                        menuStrip1.Items[2].Text = e.Node.Text + "    rows(" + dt.Rows.Count.ToString() + ")";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "selecting a table");
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                cn.Open();
                DataTable dts = cn.GetSchema("Databases");
                for (int i = 0; i < dts.Rows.Count; i++)
                {
                    TreeNode tree = new TreeNode(dts.Rows[i]["database_name"].ToString());
                    treeView1.Nodes.Add(tree);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "refresh schemas");
            }
            finally
            {
                cn.Close();
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            menuStrip1.Items[2].Text = "result";
            try
            {
                cn.Open();
                adapdt = new MySqlDataAdapter(textBox1.Text, cn);
                cmbuil = new MySqlCommandBuilder(adapdt);
                DataTable dt = new DataTable();
                adapdt.Fill(dt);
                dataGrid.DataSource = dt;
                menuStrip1.Items[2].Text = "result" + "    rows(" + dt.Rows.Count.ToString() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "execution a script");
            }
            finally
            {
                cn.Close();
            }
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                adapdt.Update((DataTable)dataGrid.DataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "applying changes");
            }
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                adapdt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "reverting changes");
            }
        }

        private void DB_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                leftCB.Items.Clear();
                rightCB.Items.Clear();
                cn.Open();
                cn.ChangeDatabase(DB_CB.Text);
                DataTable dts = cn.GetSchema("Tables");
                for (int i = 0; i < dts.Rows.Count; i++)
                {
                    leftCB.Items.Add(dts.Rows[i]["TABLE_NAME"].ToString());
                    rightCB.Items.Add(dts.Rows[i]["TABLE_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connecting to database");
            }
            finally
            {
                cn.Close();
            }
        }

        private void leftCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                left = new MySqlDataAdapter($"select * from `{leftCB.Text}`", cn);
                cmbul = new MySqlCommandBuilder(left);
                DataTable dt = new DataTable();
                left.Fill(dt);
                dataGridView1.DataSource = dt;

                SelRowCB.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SelRowCB.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connecting to left table");
            }
            finally
            {
                cn.Close();
            }
        }

        private void rightCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                right = new MySqlDataAdapter($"select * from `{rightCB.Text}`", cn);
                cmbur = new MySqlCommandBuilder(right);
                DataTable dt = new DataTable();
                right.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connecting to left table");
            }
            finally
            {
                cn.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //e.RowIndex

            //try
            //{
            //    cn.Open();
            //    string colstr = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            //    string rowstr = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex][colstr].ToString();

            //    //right = new MySqlDataAdapter($"select * from `{rightCB.Text}` where ", cn);
            //    //cmbur = new MySqlCommandBuilder(right);
            //    right = new MySqlDataAdapter($"select * from `{rightCB.Text}` where `{rightCB.Text}`.`{colstr}` = \'{rowstr}\'", cn);
            //    cmbur = new MySqlCommandBuilder(right);
            //    DataTable dt = new DataTable();
            //    right.Fill(dt);
            //    dataGridView2.DataSource = dt;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "connecting to left table");
            //}
            //finally
            //{
            //    cn.Close();
            //}
        }

        private void SelRowCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    cn.Open();
            //    right = new MySqlDataAdapter($"select * from `{rightCB.Text}` where ", cn);
            //    cmbur = new MySqlCommandBuilder(right);
            //    DataTable dt = new DataTable();
            //    right.Fill(dt);
            //    dataGridView2.DataSource = dt;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "connecting to left table");
            //}
            //finally
            //{
            //    cn.Close();
            //}

            try
            {
                cn.Open();
                cn.ChangeDatabase("db_books");
                right = new MySqlDataAdapter($"select `books`.* from `books`, `authors` " +
                    $"where `books`.`Code_author` = `authors`.`Code_author` and `authors`.`Name_author` = \'{SelRowCB.Text}\';", cn);
                cmbur = new MySqlCommandBuilder(right);
                DataTable dtr = new DataTable();
                right.Fill(dtr);
                dataGridView2.DataSource = dtr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "open selected author");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
