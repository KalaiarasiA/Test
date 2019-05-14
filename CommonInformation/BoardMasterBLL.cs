using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.BoardRequest;
using Inspace.Chalo.Types.Response.CommonResponse.BoardMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class BoardMasterBLL : BaseBL
    {

        public SaveOperationResponse InsertRecord(SaveBoardMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseBoardMasterDAL objDAL = this.MyDal.GetDalRepository().GetBoardMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Board Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveBoardMasterRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseBoardMasterDAL objDAL = this.MyDal.GetDalRepository().GetBoardMasterDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Board Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectBoardMasterIdResponse SelectRecord(SelectBoardMasterIdRequest objRequest)
        {
            SelectBoardMasterIdResponse objResponse = null;

            try
            {
                BaseBoardMasterDAL objDAL = this.MyDal.GetDalRepository().GetBoardMasterDAL();
                objResponse = (SelectBoardMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectBoardMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Board Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllBoardMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllBoardMasterResponse objResponse = null;

            try
            {
                BaseBoardMasterDAL objDAL = this.MyDal.GetDalRepository().GetBoardMasterDAL();
                objResponse = (SelectAllBoardMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllBoardMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Board Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

    }
}
