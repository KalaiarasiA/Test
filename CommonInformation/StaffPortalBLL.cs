using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.StaffPortalRequest;
using Inspace.Chalo.Types.Response.StaffPortalResponse;
using Inspace.Chalo.DataAccess.Interfaces.StaffManagement.Settings;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.DataAccess.Interfaces.SchoolInformation.Masters;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class StaffPortalBLL : BaseBL
    {
        public SelectStaffPortalUserResponse GetStaffPortalUser(SelectStaffPortalUserRequest objRequest)
        {
            SelectStaffPortalUserResponse objResponse = null;
            try
            {
                BaseStaffPortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetStaffPortalLoginDAL();
                objResponse = (SelectStaffPortalUserResponse)objDAL.GetStaffPortalUser(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectStaffPortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Staff Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllStaffPortalGalleryResponse StaffPortalGalleryData(SelectStaffPortalUserRequest objRequest)
        {
            SelectAllStaffPortalGalleryResponse objResponse = null;
            try
            {
                BaseGalleryMasterDAL objDAL = this.MyDal.GetDalRepository().GetGalleryMasterDAL();
                objResponse = (SelectAllStaffPortalGalleryResponse)objDAL.StaffPortalGalleryData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllStaffPortalGalleryResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal Staff User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }


        public SelectStaffPortalUserResponse ChangePassword(SelectStaffPortalUserRequest objRequest)
        {
            SelectStaffPortalUserResponse objResponse = null;
            try
            {
                BaseStaffPortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetStaffPortalLoginDAL();
                objResponse = (SelectStaffPortalUserResponse)objDAL.ChangePassword(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectStaffPortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Staff");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectStaffPortalUserResponse GetAnsappUserData(SelectStaffPortalUserRequest objRequest)
        {
            SelectStaffPortalUserResponse objResponse = null;
            try
            {
                BaseStaffPortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetStaffPortalLoginDAL();
                objResponse = (SelectStaffPortalUserResponse)objDAL.GetAnsappUserData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectStaffPortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.BLLRetrievalErrorMessage.Replace("{}", "ANSAPP User Data");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

    }
}
