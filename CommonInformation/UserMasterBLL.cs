using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.UserMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.UserMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class UserMasterBLL : BaseBL
    {
        public SaveUserMasterResponse InsertRecord(SaveUserMasterRequest objRequest)
        {
            SaveUserMasterResponse objResponse = null;
            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SaveUserMasterResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SaveLoginUserMasterResponse InsertLoginUser(SaveClassMasterRequest objRequest)
        {
            SaveLoginUserMasterResponse objResponse = null;
            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SaveLoginUserMasterResponse)objDAL.InsertLoginUser(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveLoginUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }


        public SaveUserMasterResponse UpdateRecord(SaveUserMasterRequest objRequest)
        {
            SaveUserMasterResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SaveUserMasterResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectUserMasterIdResponse SelectRecord(SelectUserMasterIDRequest objRequest)
        {
            SelectUserMasterIdResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectUserMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectUserMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllUserMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllUserMasterResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectAllUserMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        public SelectLoginResponse LoginProcess(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.LoginProcess(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectLoginResponse LoginUserDetails(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.LoginProcess(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        public SelectLoginResponse GetAcademicYearData(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.GetAcademicYearData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Year Data");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectLoginResponse ChangePassword(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.ChangePassword(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectLoginResponse GetAcademicYearDetails(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.GetAcademicYearDetails(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Year Data");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        public SelectLoginResponse GetStaffDetailsofUser(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.GetStaffDetailsofUser(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Block Data");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllUserMasterResponse SearchUserMasterList(SelectUserMasterIDRequest objRequest)
        {
            SelectAllUserMasterResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectAllUserMasterResponse)objDAL.SearchUserMasterList(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Class Subject Mapping");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectLoginResponse UserLoginProcessP1(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.UserLoginProcessP1(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.BLLRetrievalErrorMessage.Replace("{}", "User Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectLoginResponse GetAcademicYearByBranch(SelectLoginRequest objRequest)
        {
            SelectLoginResponse objResponse = null;

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectLoginResponse)objDAL.GetAcademicYearByBranch(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectLoginResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Year Data");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllUserMasterResponse UserMasterReport(SelectAllCommonRequest objRequest)
        {
            SelectAllUserMasterResponse objResponse = new SelectAllUserMasterResponse();

            try
            {
                BaseUserMasterDAL objDAL = this.MyDal.GetDalRepository().GetUserMasterDAL();
                objResponse = (SelectAllUserMasterResponse)objDAL.UserMasterReport(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllUserMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "User Master Report");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
    }
}
