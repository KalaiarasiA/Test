using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.SMSGroupMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.Response.CommonResponse.SMSGroupMasterResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class SMSGroupMasterBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveSMSGroupMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;


            try
            {
                BaseSMSGroupMasterDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}","Group Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveSMSGroupMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseSMSGroupMasterDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}","Group Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectSMSGroupMasterIDResponse SelectRecord(SelectSMSGroupMasterIDRequest objRequest)
        {
            SelectSMSGroupMasterIDResponse objResponse = null;

            try
            {
                BaseSMSGroupMasterDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMasterDAL();
                objResponse = (SelectSMSGroupMasterIDResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectSMSGroupMasterIDResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}","Group Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllSMSGroupMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllSMSGroupMasterResponse objResponse = null;

            try
            {
                BaseSMSGroupMasterDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMasterDAL();
                objResponse = (SelectAllSMSGroupMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllSMSGroupMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}","Group Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
