using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace VDSI_EmpCarPooling
{
 
    public class Database
    {
        
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

        DataSet ds = new DataSet();
    
        public DataSet SelectData(String Query)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand(Query,con);
              
                SqlDataAdapter da = new SqlDataAdapter(Query,con);
                da.Fill(ds);
                

               
            }
            catch (Exception e)
            {
            }
            return ds;

        }

        public void InsertandupdateData(string query)
        {
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public void Storedprocwithparameter(string spname,string[] paramenter)
        {

            SqlCommand cmd=new SqlCommand(spname,con);
            con.Open();
             cmd.CommandType=CommandType.StoredProcedure;
            foreach(string data in paramenter)
            {
                cmd.Parameters.Add(data);
            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void storedproc(string spname)
        {
            
            SqlCommand cmd=new SqlCommand(spname,con);
            con.Open();
             cmd.CommandType=CommandType.StoredProcedure;
             cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    
    }

  
    
