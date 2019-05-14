using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.CheckListMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.Response.CommonResponse.ChecklistMasterResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class ChecklistMasterBLL : BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveChecklistMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseChecklistMasterDAL objDAL = this.MyDal.GetDalRepository().GetChecklistMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Checklist Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveChecklistMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;
            try
            {
                BaseChecklistMasterDAL objDAL = this.MyDal.GetDalRepository().GetChecklistMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Checklist Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAllChecklistMasterResponse SelectRecord(SelectChecklistMasterRequest objRequest)
        {
            SelectAllChecklistMasterResponse objResponse = null;
            try
            {
                BaseChecklistMasterDAL objDAL = this.MyDal.GetDalRepository().GetChecklistMasterDAL();
                objResponse = (SelectAllChecklistMasterResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllChecklistMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Checklist Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAllChecklistMasterResponse SelectAll(SelectChecklistMasterRequest objRequest)
        {
            SelectAllChecklistMasterResponse objResponse = null;
            try
            {
                BaseChecklistMasterDAL objDAL = this.MyDal.GetDalRepository().GetChecklistMasterDAL();
                objResponse = (SelectAllChecklistMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllChecklistMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Checklist Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAllChecklistMasterResponse GetChecklist(SelectChecklistMasterRequest objRequest)
        {
            SelectAllChecklistMasterResponse objResponse = null;

            try
            {
                BaseChecklistMasterDAL objDAL = this.MyDal.GetDalRepository().GetChecklistMasterDAL();
                objResponse = (SelectAllChecklistMasterResponse)objDAL.GetChecklist(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllChecklistMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Checklist");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        } 
    }
}
