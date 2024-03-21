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
    public class CDM_Kho_Controller
    {
        public List<CDM_Kho> FQ_114_K_sp_sel_List_For_Cache()
        {
            List<CDM_Kho> v_arrRes = new List<CDM_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_114_K_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Kho v_objRes = CUtility.Map_Row_To_Entity<CDM_Kho>(v_row);
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
        public int FQ_114_K_sp_ins_Insert(CDM_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_114_K_sp_ins_Insert",
                    p_objData.Ma_Kho, p_objData.Ten_Kho, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return v_iRes;
        }
        public int FQ_114_K_sp_upd_Update(CDM_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_114_K_sp_upd_Update",
                    p_objData.Ma_Kho, p_objData.Ten_Kho, p_objData.Ghi_Chu);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return v_iRes;
        }

        public CDM_Kho FQ_114_K_sp_sel_Get_By_ID(string? p_iID)
        {
            CDM_Kho? v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Mock_Conn_String, v_dt, "FQ_114_K_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CDM_Kho>(v_dt.Rows[0]);
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

            return v_objRes;
        }
        public int FQ_114_K_sp_del_Delete_By_ID(string p_iID)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = CSqlHelper.ExecuteNonquery(CConfig.TKS_Mock_Conn_String, "FQ_114_K_sp_del_Delete_By_ID", p_iID);
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
