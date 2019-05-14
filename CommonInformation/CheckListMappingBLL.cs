using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.CheckListMappingRequest;
using Inspace.Chalo.Types.Response.CommonRequest.CheckListMappingRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class CheckListMappingBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveCheckListMappingRequest objRequest)
        {
            SaveOperationResponse objResponse = null;


            try
            {
                BaseCheckListMappingDAL objDAL = this.MyDal.GetDalRepository().GetCheckListMappingDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "CheckListMapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveCheckListMappingRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseCheckListMappingDAL objDAL = this.MyDal.GetDalRepository().GetCheckListMappingDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "CheckListMapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectCheckListMappingIDResponse SelectRecord(SelectCheckListMappingIDRequest objRequest)
        {
            SelectCheckListMappingIDResponse objResponse = null;

            try
            {
                BaseCheckListMappingDAL objDAL = this.MyDal.GetDalRepository().GetCheckListMappingDAL();
                objResponse = (SelectCheckListMappingIDResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectCheckListMappingIDResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "CheckListMapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllCheckListMappingResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllCheckListMappingResponse objResponse = null;

            try
            {
                BaseCheckListMappingDAL objDAL = this.MyDal.GetDalRepository().GetCheckListMappingDAL();
                objResponse = (SelectAllCheckListMappingResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllCheckListMappingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "CheckListMapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }


        public SelectAllCheckListMappingResponse SelectChecklistData(SelectAllCommonRequest objRequest)
        {
            SelectAllCheckListMappingResponse objResponse = null;

            try
            {
                BaseCheckListMappingDAL objDAL = this.MyDal.GetDalRepository().GetCheckListMappingDAL();
                objResponse = (SelectAllCheckListMappingResponse)objDAL.SelectChecklistData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllCheckListMappingResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "CheckListMapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
