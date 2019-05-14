using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.SMS_EmailRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.Response.CommonResponse.ScreenMasterResponse;
using Inspace.Chalo.Types.Response.CommonResponse.SMS_EmailResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class SMSEmailSettingBLL :BaseBL
    {

        public SaveOperationResponse InsertRecord(SaveSMSEmailSettingRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveSMSEmailSettingRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "SMS Email Setting");
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
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
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
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectAllSMSEmailSettingResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllSMSEmailSettingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllScreenKeywordsResponse LoadkeywordByScreenID(SelectAllCommonRequest objRequest)
        {
            SelectAllScreenKeywordsResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectAllScreenKeywordsResponse)objDAL.LoadkeywordByScreenID(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllScreenKeywordsResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectSMSEmailSettingIdResponse LoadSMSScreen(SelectSMSEmailSettingIDRequest objRequest)
        {
            SelectSMSEmailSettingIdResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectSMSEmailSettingIdResponse)objDAL.LoadSMSScreens(objRequest);
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
     

        public FetchScheduledSMSEmailResponse SendScheduledSMSEmail(FetchScheduledSMSEmailRequest objRequest)
        {
            FetchScheduledSMSEmailResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (FetchScheduledSMSEmailResponse)objDAL.SendScheduledSMSEmail(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new FetchScheduledSMSEmailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
      
        public SelectScheduledSMSEmailResponse FetchScheduledSMSEmailData(FetchScheduledSMSEmailRequest objRequest)
        {
            SelectScheduledSMSEmailResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectScheduledSMSEmailResponse)objDAL.FetchScheduledSMSEmailData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectScheduledSMSEmailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Email Setting");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllLookupDataResponse SelectAllSMSScreenMaster(SelectAllCommonRequest objRequest)
        {
            SelectAllLookupDataResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllSMSScreenMaster(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllLookupDataResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAllLookupDataResponse SelectAllTypeByScreenID(SelectAllCommonRequest objRequest)
        {
            SelectAllLookupDataResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllTypeByScreenID(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllLookupDataResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "SMS Screen Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectBulkSMSEmailResponse GenerateStudentStaffDataForBulkSMS(SelectBulkSMSEmailRequest objRequest)
        {
            SelectBulkSMSEmailResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectBulkSMSEmailResponse)objDAL.GenerateStudentStaffDataForBulkSMS(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectBulkSMSEmailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Bulk SMS Record");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

       public SelectBulkSMSEmailResponse SendBulkSMS(SendBulkSMSEmailRequest objRequest)
        {
            SelectBulkSMSEmailResponse objResponse = null;

            try
            {
                BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
                objResponse = (SelectBulkSMSEmailResponse)objDAL.SendBulkSMS(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectBulkSMSEmailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Bulk SMS Record");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

       public SelectTransportSMSResponse GenerateTransportSMS(SelectTransportSMSRequest objRequest)
       {
           SelectTransportSMSResponse objResponse = null;

           try
           {
               BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
               objResponse = (SelectTransportSMSResponse)objDAL.GenerateTransportSMS(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectTransportSMSResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Transport SMS");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;
       }

       public SelectHostelSMSResponse GenerateHostelSMS(SelectHostelSMSRequest objRequest)
       {
           SelectHostelSMSResponse objResponse = null;

           try
           {
               BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
               objResponse = (SelectHostelSMSResponse)objDAL.GenerateHostelSMS(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectHostelSMSResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Hostel SMS");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;
       }


       public SelectBulkSMSEmailResponse SendFeePendencyBulkSMS(SendBulkSMSEmailRequest objRequest)
       {
           SelectBulkSMSEmailResponse objResponse = null;

           try
           {
               BaseSMSEmailSettingDAL objDAL = this.MyDal.GetDalRepository().GetSMSEmailSettingDAL();
               objResponse = (SelectBulkSMSEmailResponse)objDAL.SendFeePendencyBulkSMS(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectBulkSMSEmailResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Bulk SMS Record");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }


    }
}
