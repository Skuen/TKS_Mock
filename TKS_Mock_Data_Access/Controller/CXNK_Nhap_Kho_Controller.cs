using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.DataLayer;
using TKS_Mock_Data_Access.Entity;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Controller
{
    public class CXNK_Nhap_Kho_Controller
    {
        public List<CXNK_Nhap_Kho> FQ_718_NK_sp_sel_List_For_Cache()
        {
            List<CXNK_Nhap_Kho> v_arrRes = new List<CXNK_Nhap_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_718_NK_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    var v_objRes = CUtility.Map_Row_To_Entity<CXNK_Nhap_Kho>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
        public List<CXNK_Nhap_Kho> FQ_718_NK_sp_sel_List_By_Date_Created(DateTime p_dtmFrom, DateTime p_dtmTo)
        {
            List<CXNK_Nhap_Kho> v_arrRes = new List<CXNK_Nhap_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = p_dtmFrom.Date;
                p_dtmTo = p_dtmTo.Date.AddDays(1).AddTicks(-1);

                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_718_NK_sp_sel_List_By_Date_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho v_objRes = CUtility.Map_Row_To_Entity<CXNK_Nhap_Kho>(v_row);
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
        public CXNK_Nhap_Kho FQ_718_NK_sp_sel_Get_By_ID(string p_iID)
        {
            CXNK_Nhap_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_718_NK_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Nhap_Kho>(v_dt.Rows[0]);
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

            return v_objRes;
        }
        public int FQ_718_NK_sp_ins_Insert(CXNK_Nhap_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_718_NK_sp_ins_Insert",
                    p_objData.So_Phieu_Nhap_Kho, p_objData.Kho_ID, p_objData.NCC_ID, p_objData.Ngay_Nhap_Kho, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return v_iRes;
        }
        public int FQ_718_NK_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Nhap_Kho p_objData)
		{
            int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Mock_Conn_String, "FQ_718_NK_sp_ins_Insert",
                    p_objData.So_Phieu_Nhap_Kho, p_objData.Kho_ID, p_objData.NCC_ID, p_objData.Ngay_Nhap_Kho, p_objData.Ghi_Chu);
			}

			catch (Exception)
			{
				throw;
			}

			return v_iRes;
		}
        public int FQ_718_NK_sp_upd_Update(CXNK_Nhap_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_718_NK_sp_upd_Update", 
                    p_objData.So_Phieu_Nhap_Kho, p_objData.Kho_ID, p_objData.NCC_ID, p_objData.Ngay_Nhap_Kho, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return v_iRes;
        }
        public int FQ_718_NK_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Nhap_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Mock_Conn_String, "FQ_718_NK_sp_upd_Update",
                    p_objData.So_Phieu_Nhap_Kho, p_objData.Kho_ID, p_objData.NCC_ID, p_objData.Ngay_Nhap_Kho, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return v_iRes;
        }
        public int FQ_718_NK_sp_del_Delete_By_ID(string p_iID)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_718_NK_sp_del_Delete_By_ID", p_iID);
            }

            catch (Exception)
            {
                throw;
            }
            return v_iRes;
        }

    }
}
