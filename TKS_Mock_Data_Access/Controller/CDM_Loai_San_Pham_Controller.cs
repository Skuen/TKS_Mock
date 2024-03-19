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
    public class CDM_Loai_San_Pham_Controller
    {
        public List<CDM_Loai_San_Pham> FQ_122_LSP_sp_sel_List_For_Cache()
        {
            List<CDM_Loai_San_Pham> v_arrRes = new List<CDM_Loai_San_Pham>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_122_LSP_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Loai_San_Pham v_objRes = CUtility.Map_Row_To_Entity<CDM_Loai_San_Pham>(v_row);
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
