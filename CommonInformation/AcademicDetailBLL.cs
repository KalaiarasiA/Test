using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.AcademicDetailRequest;
using Inspace.Chalo.Types.Response.CommonResponse.AcademicDetailResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class AcademicDetailBLL :BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveAcademicDetailRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseAcademicDetailDAL objDAL = this.MyDal.GetDalRepository().GetAcademicDetailDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Academic Detail");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public UpdateOperationResponse UpdateRecord(SaveAcademicDetailRequest objRequest)
        {
            UpdateOperationResponse objResponse = null;

            try
            {
                BaseAcademicDetailDAL objDAL = this.MyDal.GetDalRepository().GetAcademicDetailDAL();
                objResponse = (UpdateOperationResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new UpdateOperationResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Academic Detail");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAcademicDetailIdResponse SelectRecord(SelectAcademicDetailIdRequest objRequest)
        {
            SelectAcademicDetailIdResponse objResponse = null;

            try
            {
                BaseAcademicDetailDAL objDAL = this.MyDal.GetDalRepository().GetAcademicDetailDAL();
                objResponse = (SelectAcademicDetailIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAcademicDetailIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Detail");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllAcademicDetailResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllAcademicDetailResponse objResponse = null;

            try
            {
                BaseAcademicDetailDAL objDAL = this.MyDal.GetDalRepository().GetAcademicDetailDAL();
                objResponse = (SelectAllAcademicDetailResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllAcademicDetailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Detail");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
