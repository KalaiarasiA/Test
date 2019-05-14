using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.PortalRequest;
using Inspace.Chalo.Types.Response.PortalResponse;
using Inspace.Chalo.DataAccess.Interfaces.StudentManagement.Settings;
using Inspace.Chalo.Types.Response.CommonResponse.SMS_EmailResponse;
using Inspace.Chalo.Types.Request.CommonRequest.SMS_EmailRequest;
using Inspace.Chalo.DataAccess.Interfaces.SchoolInformation.Masters;
using Inspace.Chalo.Types.Response.StudentManagementResponse.SettingsResponse;
using Inspace.Chalo.Types.Request.StudentManagementRequest.SettingsRequest;
using Inspace.Chalo.Web.ReportLibrary.StudentManagement.StudentCertificates;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
    public class PortalBLL : BaseBL
    {
        public SavePortalUserResponse InsertRecord(SavePortalUserRequest objRequest)
        {
            SavePortalUserResponse objResponse = null;
            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SavePortalUserResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SavePortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SavePortalUserResponse UpdateRecord(SavePortalUserRequest objRequest)
        {
            SavePortalUserResponse objResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SavePortalUserResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SavePortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectAllPortalUserResponse SelectAll(SelectAllPortalUserRequest objRequest)
        {
            SelectAllPortalUserResponse objResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SelectAllPortalUserResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllPortalUserResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User");
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
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SelectBulkSMSEmailResponse)objDAL.SendBulkSMS(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectBulkSMSEmailResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }


        public SelectPortalRecordResponse GetPortalUser(SelectAllPortalUserRequest objRequest)
        {
            SelectPortalRecordResponse objResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SelectPortalRecordResponse)objDAL.GetPortalUser(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectPortalRecordResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        public SelectAllPortalGalleryResponse SelectPortalGalleryData(SelectPortalDataIDRequest objRequest)
        {
            SelectAllPortalGalleryResponse objResponse = null;

            try
            {
                BaseGalleryMasterDAL objDAL = this.MyDal.GetDalRepository().GetGalleryMasterDAL();
                objResponse = (SelectAllPortalGalleryResponse)objDAL.SelectPortalGalleryData(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllPortalGalleryResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectPortalRecordResponse GetPortalAcademicYear(SelectAllPortalUserRequest ObjRequest)
        {
            SelectPortalRecordResponse ObjResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ObjResponse = (SelectPortalRecordResponse)objDAL.GetPortalAcademicYear(ObjRequest);
            }
            catch (Exception ex)
            {
                ObjResponse = new SelectPortalRecordResponse();
                ObjResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Academic Year");
                ObjResponse.ExceptionMessage = ex.Message;
                ObjResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ObjResponse;
        }

        public SelectPortalRecordResponse StudentExamPlanner(SelectPortalDataIDRequest objRequest)
        {
            SelectPortalRecordResponse objResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SelectPortalRecordResponse)objDAL.StudentExamPlanner(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectPortalRecordResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Exam Planner");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectPortalConfigIDResponse URLPathDetails(SelectPortalConfigIDRequest objRequest)
        {
            SelectPortalConfigIDResponse objResponse = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                objResponse = (SelectPortalConfigIDResponse)objDAL.URLPathDetails(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectPortalConfigIDResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "URL Path Details!");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectPortalRecordResponse GetPortalUserList(SelectAllPortalUserRequest RequestData)
        {
            SelectPortalRecordResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SelectPortalRecordResponse)objDAL.GetPortalUserList(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SelectPortalRecordResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User Data");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }


        public SelectPortalDataIDResponse GetPopUpDetails(SelectPortalDataIDRequest RequestData)
        {
            SelectPortalDataIDResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SelectPortalDataIDResponse)objDAL.GetPopUpDetails(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SelectPortalDataIDResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "School Pop-Up option Details");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }


        public SelectPortalRecordResponse GetPORTALEXAMTYPE(SelectPortalDataIDRequest RequestData)
        {
            SelectPortalRecordResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SelectPortalRecordResponse)objDAL.GetPORTALEXAMTYPE(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SelectPortalRecordResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal Exam Data");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }

        public SelectPortalRecordResponse GetAllIssuedCertificateList(SelectPortalDataIDRequest RequestData)
        {
            SelectPortalRecordResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SelectPortalRecordResponse)objDAL.GetAllIssuedCertificateList(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SelectPortalRecordResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Certificate History");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }

        public SearchStudentListResponse GetStudentCertificateByID(SearchStudentListRequest RequestData)
        {
            SearchStudentListResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SearchStudentListResponse)objDAL.GetStudentCertificateByID(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SearchStudentListResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Student Certificate");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }

        public SelectAllPortalUserResponse PortalUserMasterReport(SelectAllPortalUserRequest RequestData)
        {
            SelectAllPortalUserResponse ResponseData = null;

            try
            {
                BasePortalLoginDAL objDAL = this.MyDal.GetDalRepository().GetPortalLoginDAL();
                ResponseData = (SelectAllPortalUserResponse)objDAL.PortalUserMasterReport(RequestData);
            }
            catch (Exception ex)
            {
                ResponseData = new SelectAllPortalUserResponse();
                ResponseData.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Portal User");
                ResponseData.ExceptionMessage = ex.Message;
                ResponseData.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return ResponseData;
        }
    }
}
