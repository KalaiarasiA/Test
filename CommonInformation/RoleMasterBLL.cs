using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.RoleMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.RoleMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class RoleMasterBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveRoleMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseRoleMasterDAL objDAL = this.MyDal.GetDalRepository().GetRoleMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Role Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveRoleMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseRoleMasterDAL objDAL = this.MyDal.GetDalRepository().GetRoleMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Role Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectRoleMasterIdResponse SelectRecord(SelectRoleMasterIDRequest objRequest)
        {
            SelectRoleMasterIdResponse objResponse = null;
             try
            {
                BaseRoleMasterDAL objDAL = this.MyDal.GetDalRepository().GetRoleMasterDAL();
                objResponse = (SelectRoleMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectRoleMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Role Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllRoleMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllRoleMasterResponse objResponse = null;

            try
            {
                BaseRoleMasterDAL objDAL = this.MyDal.GetDalRepository().GetRoleMasterDAL();
                objResponse = (SelectAllRoleMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllRoleMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Role Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

    }
}
