using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.ScreenMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.ScreenMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.Response.CommonResponse.RolePrivilegeMasterResponse;
using Inspace.Chalo.Types.Request.CommonRequest.RolePrivilegeRequest;


namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public  class ScreenMasterBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveScreenMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseScreenMasterDAL objDAL = this.MyDal.GetDalRepository().GetScreenMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveScreenMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseScreenMasterDAL objDAL = this.MyDal.GetDalRepository().GetScreenMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectScreenMasterIdResponse SelectRecord(SelectScreenMasterIDRequest objRequest)
        {
            SelectScreenMasterIdResponse objResponse = null;

            try
            {
                BaseScreenMasterDAL objDAL = this.MyDal.GetDalRepository().GetScreenMasterDAL();
                objResponse = (SelectScreenMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectScreenMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllScreenMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllScreenMasterResponse objResponse = null;

            try
            {
                BaseScreenMasterDAL objDAL = this.MyDal.GetDalRepository().GetScreenMasterDAL();
                objResponse = (SelectAllScreenMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllScreenMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllScreenPrivilegeMasterResponse LoadPrivilegeByScreenID(SelectRolePrivilegeMasterIdRequest objRequest)
        {
            SelectAllScreenPrivilegeMasterResponse objResponse = null;

            try
            {
                BaseScreenMasterDAL objDAL = this.MyDal.GetDalRepository().GetScreenMasterDAL();
                objResponse = (SelectAllScreenPrivilegeMasterResponse)objDAL.LoadPrivilegeByScreen(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllScreenPrivilegeMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

    }
}
