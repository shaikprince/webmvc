﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using webMvc.Models;

namespace webMvc.Services
{
    public class RoleServices
    {
        public string connect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlDataAdapter _adapter;
        private DataSet _ds;
        public IList<Rolemodel> GetRole()
        {
            IList<Rolemodel> getRolemodel = new List<Rolemodel>();
            _ds = new DataSet();



            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("RoleDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mode", "GetRole");
                _adapter = new SqlDataAdapter(cmd);
                _adapter.Fill(_ds);



                if (_ds.Tables.Count > 0)
                {
                    for (int i = 0; i < _ds.Tables[0].Rows.Count; i++)
                    {
                        Rolemodel obj = new Rolemodel();
                        obj.Role = Convert.ToInt32(_ds.Tables[0].Rows[i]["Id"]);
                        obj.Name = Convert.ToString(_ds.Tables[0].Rows[i]["Name"]);
                        getRolemodel.Add(obj);
                    }


                }
                return getRolemodel;

            }
        }
    }

}   
    