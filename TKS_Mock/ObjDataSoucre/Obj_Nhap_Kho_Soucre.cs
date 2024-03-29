using System.ComponentModel;
using TKS_Mock_Data_Access.Controller;
using TKS_Mock_Data_Access.Entity;

namespace TKS_Mock.ObjDataSoucre
{
    [DataObject]
    public class Obj_Nhap_Kho_Soucre
    {
        CXNK_Tao_Phieu_Controller v_objTPController = new();

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CXNK_Phieu_Nhap_ViewModel> Get_Nhap_Kho(string p_strId)
        {
            return v_objTPController.FQ_719_NKRD_sp_sel_Get_By_ID_To_Export(p_strId);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CXNK_Phieu_Xuat_ViewModel> Get_Xuat_Kho(string p_strId)
        {
            return v_objTPController.FQ_734_XKRD_sp_sel_Get_By_ID_To_Export(p_strId);
        }
    }
}
