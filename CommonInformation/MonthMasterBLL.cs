using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Request.CommonRequest.MonthMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.MonthMasterResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class MonthMasterBLL : BaseBL
    {

        public SelectMonthMasterResponse SelectMonthMasterData(SelectAllCommonRequest objRequest)
        {
            SelectMonthMasterResponse objResponse = null;

            try
            {
                BaseMonthMasterDAL objDAL = this.MyDal.GetDalRepository().GetMonthMasterDAL();
                objResponse = (SelectMonthMasterResponse)objDAL.SelectMonthMasterData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectMonthMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Month Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        public SelectAllMonthMasterResponse SelectAll(SelectMonthMasterIDRequest objRequest)
        {
            SelectAllMonthMasterResponse objResponse = null;

            try
            {
                BaseMonthMasterDAL objDAL = this.MyDal.GetDalRepository().GetMonthMasterDAL();
                objResponse = (SelectAllMonthMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllMonthMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Month Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectMonthMasterIDResponse SelectRecord(SelectMonthMasterIDRequest objRequest)
        {
            SelectMonthMasterIDResponse objResponse = null;

            try
            {
                BaseMonthMasterDAL objDAL = this.MyDal.GetDalRepository().GetMonthMasterDAL();
                objResponse = (SelectMonthMasterIDResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectMonthMasterIDResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", " Month Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
