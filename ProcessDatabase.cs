﻿using System;
using System.Collections.Generic;
using System.Linq;2
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarroApp
{
   public  class ProcessDatabase
    {
        string strConnect = "Data Source=.\\sqlexpress;Initial Catalog=CaroApp;Integrated Security=True"
        SqlConnection sqlConnect = null;
        //Hàm mở kết nối
        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Hàm đóng kết nối
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }

        //Hàm thực lệnh insert hoặc update hoặc delete
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
            sqlcommand.Dispose();
        }

    }
}

