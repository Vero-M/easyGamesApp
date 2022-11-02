using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace easyGamesApp
{
    public partial class Form1 : Form
    {
        //Vars
        string connectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        string comment;
        int clientID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupConn();
            string sql;
            con.Open();
            sql = "SELECT Name, Surname FROM Client";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbClient.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1));
            }
            cmbClient.Text = cmbClient.Items[0].ToString();
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            createCols();
            
            string sql;
            con.Open();
            string client;
            int delim;

            client = cmbClient.SelectedItem.ToString();

            delim = client.IndexOf(' ');
            client = client.Substring(0, delim);

            sql = "SELECT ClientID FROM Client WHERE Name = '" + client + "'";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clientID = (int)reader.GetValue(0);
            }

            reader.Close();
            sql = null;
            sql = "SELECT * FROM TransactionTable WHERE ClientID = " + clientID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var data = new ListViewItem(new[] { reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString() });
                lstData.Items.Add(data);
            }
            con.Close();
            enable();

        }

        private void setupConn()
        {
            connectionString = @"Data Source=VARSHEN-DESKTOP;Initial Catalog=easyGames;Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
        private void createCols()
        {
            lstData.Clear();
            lstData.View = View.Details;
            lstData.Columns.Add("Amount", 80);
            lstData.Columns.Add("Transaction Type ID", 120);
            lstData.Columns.Add("Client ID", 80);
            lstData.Columns.Add("Comment", 80);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (edtComment.Text.Equals(""))
            {
                MessageBox.Show("Please enter a comment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comment = edtComment.Text;
                updateDb(comment, clientID);
            }
            
        }
        private void updateDb(string comment, int ID)
        {
            string sql;
            con.Open();
            sql = "UPDATE TransactionTable SET Comment = '" + comment + "' WHERE ClientID = " + ID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();
            reader.Close();
            MessageBox.Show("Updated data", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Open();
            sql = "SELECT * FROM TransactionTable WHERE ClientID = " + clientID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            lstData.Items.Clear();
            while (reader.Read())
            {
                var data = new ListViewItem(new[] { reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString() });
                lstData.Items.Add(data);
            }
            con.Close();
            edtComment.Text = "";
            edtComment.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql;
            float returnAmount =0;
            float data = 0;
            int trans;

            if (cmbTrans.SelectedItem.Equals("Debit"))
            {
                trans = 1;
            }
            else
                trans = 2;
            con.Open();
            sql = "INSERT INTO TransactionTable(Amount,TransactionTypeID,ClientID,Comment)" +
                "VALUES(" + float.Parse(edtAmount.Text)+"," + trans +","+ clientID + ",'" + edtCom.Text + "')";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();
            reader.Close();

            con.Open();
            sql = "SELECT ClientBalance FROM Client WHERE ClientID= " + clientID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data = float.Parse(reader.GetValue(0).ToString());
            }
            switch(trans)
            {
                case 1:
                    {
                        returnAmount = data + float.Parse(edtAmount.Text);
                        break;
                    }
                case 2:
                    {
                        returnAmount = data - float.Parse(edtAmount.Text);
                        break;
                    }
            }
            con.Close();
            reader.Close();

            con.Open();
            sql = "UPDATE Client SET ClientBalance = " + returnAmount + " WHERE ClientID = " + clientID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();


            con.Open();
            sql = "SELECT * FROM TransactionTable WHERE ClientID = " + clientID;
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            lstData.Items.Clear();
            while (reader.Read())
            {
                var dataLst = new ListViewItem(new[] { reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString() });
                lstData.Items.Add(dataLst);
            }
            MessageBox.Show("Transaction Complete", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
        private void enable()
        {
            edtComment.Enabled = true;
            edtAmount.Enabled = true;
            edtCom.Enabled = true;
            cmbTrans.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }
    }
}
