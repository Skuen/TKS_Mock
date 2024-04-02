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
    public class CXNK_Ton_Kho_Controller
    {
        public List<CXNK_Ton_Kho_ViewModel> FQ_XNK_sp_sel_List_Ton_Kho_By_Date(DateTime p_dtmFrom, DateTime p_dtmTo)
        {
            List<CXNK_Ton_Kho_ViewModel> v_arrRes = new List<CXNK_Ton_Kho_ViewModel>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = p_dtmFrom.Date;
                p_dtmTo = p_dtmTo.Date.AddDays(1).AddTicks(-1);

                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_XNK_sp_sel_List_Ton_Kho_By_Date", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Ton_Kho_ViewModel v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho_ViewModel>(v_row);
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
