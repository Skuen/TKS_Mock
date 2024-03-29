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
    public class CXNK_Tao_Phieu_Controller
    {
        public List<CXNK_Phieu_Nhap_ViewModel> FQ_719_NKRD_sp_sel_Get_By_ID_To_Export(string p_iID)
        {
            List<CXNK_Phieu_Nhap_ViewModel> v_arrRes = new();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_719_NKRD_sp_sel_Get_By_ID_To_Export", p_iID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    var v_objRes = CUtility.Map_Row_To_Entity<CXNK_Phieu_Nhap_ViewModel>(v_row);
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
        public List<CXNK_Phieu_Xuat_ViewModel> FQ_734_XKRD_sp_sel_Get_By_ID_To_Export (string p_iID)
        {
            List<CXNK_Phieu_Xuat_ViewModel> v_arrRes = new();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_734_XKRD_sp_sel_Get_By_ID_To_Export", p_iID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    var v_objRes = CUtility.Map_Row_To_Entity<CXNK_Phieu_Xuat_ViewModel>(v_row);
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
    }
}
