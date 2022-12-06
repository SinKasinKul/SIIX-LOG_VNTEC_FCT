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
using System.Configuration;
using System.IO;
using System.Data.OleDb;

namespace LOG_VNTEC_FCT
{
    class ConnectDB
    {
        public SqlConnection ConnectionDB()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string Server = appSettings.Get("Server");
            string DataBase = appSettings.Get("DBNane");
            string User = appSettings.Get("User");
            string PW = appSettings.Get("PW");
            string PoolSize = appSettings.Get("PoolSize");
            string Timeout = appSettings.Get("Timeout");

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=" + Server + ";"
                            + "Initial Catalog=" + DataBase + ";"
                            + "User ID=" + User + ";"
                            + "Password=" + PW + ";"
                            + "Max Pool Size=" + PoolSize + ";"
                            + "Connect Timeout=" + Timeout + ";";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
        public string MAIN_INS_FCT_LOG(string MODEL, string BARCODE, string LOGDATE, string RESULT, string MC, string CUS)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "MAIN_INS_FCT_LOG";
                    objCmd.Parameters.Add(new SqlParameter("@pMODEL", MODEL));
                    objCmd.Parameters.Add(new SqlParameter("@pBARCODE", BARCODE));
                    objCmd.Parameters.Add(new SqlParameter("@pLOGDATE", LOGDATE));
                    objCmd.Parameters.Add(new SqlParameter("@pRESULT", RESULT));
                    objCmd.Parameters.Add(new SqlParameter("@pMC", MC));
                    objCmd.Parameters.Add(new SqlParameter("@pCUS", CUS));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["RSts"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
    }
}
