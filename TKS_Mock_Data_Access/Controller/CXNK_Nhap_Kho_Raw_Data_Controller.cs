using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock;
using TKS_Mock_Data_Access.DataLayer;
using TKS_Mock_Data_Access.Entity;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Controller
{
    public class CXNK_Nhap_Kho_Raw_Data_Controller
    {
        //Sử dụng Phieu_Nhap_ID
        public List<CXNK_Nhap_Kho_Raw_Data> FQ_719_NKRD_sp_sel_Get_By_ID(string p_iID)
        {
            List<CXNK_Nhap_Kho_Raw_Data> v_arrRes = new ();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_719_NKRD_sp_sel_Get_By_ID", p_iID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    var v_objRes = CUtility.Map_Row_To_Entity<CXNK_Nhap_Kho_Raw_Data>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
        public int FQ_719_NKRD_sp_ins_Insert(CXNK_Nhap_Kho_Raw_Data p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_719_NKRD_sp_ins_Insert",
                    p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Nhap, p_objData.Don_Gia_Nhap);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return v_iRes;
        }
        public int FQ_719_NKRD_sp_upd_Update(CXNK_Nhap_Kho_Raw_Data p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_719_NKRD_sp_upd_Update",
                    p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Nhap, p_objData.Don_Gia_Nhap);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return v_iRes;
        }
        public int FQ_719_NKRD_sp_del_Delete_By_ID(CXNK_Nhap_Kho_Raw_Data p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_719_NKRD_sp_del_Delete_By_ID", 
                    p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return v_iRes;
        }

    }
}
