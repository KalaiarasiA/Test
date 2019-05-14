using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.AcademicWeeklyOffRequest;
using Inspace.Chalo.Types.Response.CommonResponse.AcademicWeeklyOffResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;


namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class AcademicWeeklyOffBLL:BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveAcademicWeeklyOffRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseAcademicWeeklyOffDAL objDAL = this.MyDal.GetDalRepository().GetAcademicWeeklyOffDAL(); 
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Academic WeeklyOff");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveAcademicWeeklyOffRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;
            try
            {
                BaseAcademicWeeklyOffDAL objDAL = this.MyDal.GetDalRepository().GetAcademicWeeklyOffDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Academic WeeklyOff");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAcademicWeeklyoffIdResponse SelectRecord(SelectAcademicWeeklyOffIdRequest objRequest)
        {
            SelectAcademicWeeklyoffIdResponse objResponse = null;

            try
            {
                BaseAcademicWeeklyOffDAL objDAL = this.MyDal.GetDalRepository().GetAcademicWeeklyOffDAL();
                objResponse = (SelectAcademicWeeklyoffIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAcademicWeeklyoffIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic WeeklyOff");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllAcademicWeeklyoffResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllAcademicWeeklyoffResponse objResponse = null;

            try
            {
                BaseAcademicWeeklyOffDAL objDAL = this.MyDal.GetDalRepository().GetAcademicWeeklyOffDAL();
                objResponse = (SelectAllAcademicWeeklyoffResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllAcademicWeeklyoffResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic WeeklyOff");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
