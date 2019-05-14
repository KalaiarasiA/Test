using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.SMSGroupMappingRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.Response.CommonResponse.SMSGroupMappingResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class SMSGroupMappingBLL : BaseBL
    {

        public SaveSMSGroupMappingResponse UpdateRecord(SaveSMSGroupMappingRequest objRequest)
        {
            SaveSMSGroupMappingResponse objResponse = null;

            try
            {
                BaseSMSGroupMappingDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMappingDAL();
                objResponse = (SaveSMSGroupMappingResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveSMSGroupMappingResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}","Group Mapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectSMSGroupMappingResponse SelectRecord(SelectSMSGroupMappingListRequest objRequest)
        {
            SelectSMSGroupMappingResponse objResponse = null;

            try
            {
                BaseSMSGroupMappingDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMappingDAL();
                objResponse = (SelectSMSGroupMappingResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectSMSGroupMappingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}","Group Mapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectSMSGroupMappingResponse SelectAll(SelectSMSGroupMappingListRequest objRequest)
        {
            SelectSMSGroupMappingResponse objResponse = null;

            try
            {
                BaseSMSGroupMappingDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMappingDAL();
                objResponse = (SelectSMSGroupMappingResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectSMSGroupMappingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}","Group Mapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectGroupSMSResponse GenerateGroupSMS(SelectGroupSMSRequest objRequest)
        {
            SelectGroupSMSResponse objResponse = null;

            try
            {
                BaseSMSGroupMappingDAL objDAL = this.MyDal.GetDalRepository().GetBaseSMSGroupMappingDAL();
                objResponse = (SelectGroupSMSResponse)objDAL.GenerateGroupSMS(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectGroupSMSResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Group SMS");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
