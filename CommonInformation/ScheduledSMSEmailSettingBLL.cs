using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.SMS_EmailRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.Response.CommonResponse.SMS_EmailResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class ScheduledSMSEmailSettingBLL : BaseBL
    {


        public SaveOperationResponse InsertRecord(SaveScheduledSMSEmailSettingRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseScheduledSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetScheduledSMSEmailSettingDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Scheduled SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveScheduledSMSEmailSettingRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseScheduledSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetScheduledSMSEmailSettingDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Scheduled SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectSMSEmailSettingIdResponse SelectRecord(SelectSMSEmailSettingIDRequest objRequest)
        {
            SelectSMSEmailSettingIdResponse objResponse = null;

            try
            {
                BaseScheduledSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetScheduledSMSEmailSettingDAL();
                objResponse = (SelectSMSEmailSettingIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectSMSEmailSettingIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllSMSEmailSettingResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllSMSEmailSettingResponse objResponse = null;

            try
            {
                BaseScheduledSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetScheduledSMSEmailSettingDAL();
                objResponse = (SelectAllSMSEmailSettingResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllSMSEmailSettingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Scheduled SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);     
            }
            return objResponse;
        }
    }
}
