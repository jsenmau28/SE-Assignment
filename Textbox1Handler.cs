using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database_Tesing
{
    public class Textbox1Handler
    {
            public int addTextbox1(MySqlConnection conn, Admin admin)
            {
                string sql = "INSERT INTO template (Textbox1,Textbox2,Textbox3,Textbox4,Textbox5,Textbox6,Textbox7)"
                    + "VALUE('" + admin.Textbox1 + "','" + admin.Textbox2 + "','" + admin.Textbox3 + "','" + admin.Textbox4 + "','" + admin.Textbox5 + "','" + admin.Textbox6 + "','" + admin.Textbox7 + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                return sqlComm.ExecuteNonQuery();
            }
        
    }
}
