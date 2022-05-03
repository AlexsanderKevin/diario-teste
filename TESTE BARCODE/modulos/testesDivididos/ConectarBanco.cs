using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void ConectarBanco() {
                string strcony = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandoy = "Select * from SERVICE where SN =@SN";

                OleDbConnection cony = new OleDbConnection(strcony);
                OleDbCommand comy = new OleDbCommand(comandoy, cony);

                comy.Parameters.AddWithValue("SN", tbSN.Text);
                comy.CommandType = CommandType.Text;

                OleDbDataReader readery;

                cony.Open();
        }
    }
}
