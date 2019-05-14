using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.PrivilegeMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.PrivilegeMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class PrivilegeMasterBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SavePrivilegeMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BasePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetPrivilegeMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SavePrivilegeMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BasePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetPrivilegeMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectPrivilegeMasterIdResponse SelectRecord(SelectPrivilegeMasterIDRequest objRequest)
        {
            SelectPrivilegeMasterIdResponse objResponse = null;

            try
            {
                BasePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetPrivilegeMasterDAL();
                objResponse = (SelectPrivilegeMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectPrivilegeMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace); 
            }
            return objResponse;
        }

        public SelectAllPrivilegeMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllPrivilegeMasterResponse objResponse = null;

            try
            {
                BasePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetPrivilegeMasterDAL();
                objResponse = (SelectAllPrivilegeMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllPrivilegeMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

    }
}
