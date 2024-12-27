﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public class Example
    {
        //thêm
        private void btnNVThem_Click(object sender, EventArgs e)
        {
            int dem = 0;
            try
            {
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", "123"),
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", "123"),
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", "123"),
                DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", "123"));
                DBConnection.Instance.SelectDB("tblKhachHang");
                dem++;
                if (dem > 0)
                {
                    MessageBox.Show("oke");
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        //sửa
        private void btnNVSua_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", 123),
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", "123"),
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", "123"),
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", "123"),
                DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", "123"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //xóa
        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", 123),
                DBConnection.Instance.BuildParameter("@bDeleted", SqlDbType.Bit, 0, "bDeleted", true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tìm 
 
    }
}
