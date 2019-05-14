using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
   public class CommonSettingBLL:BaseBL 
    {
       public SelectAllLookupDataResponse SelectAllApplicationStatus(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllApplicationStatus(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Application Status");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllCommunity(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllCommunity(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Community");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllLanguage(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllLanguage(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Language");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllLeaveStatus(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllLeaveStatus(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Leave Status");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllLeaveType(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllLeaveType(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Leave Type");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllMotherTongue(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllMotherTongue(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Mother Tongue");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllNationality(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllNationality(objRequest);
           }

           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Nationality");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllBoard(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllBoard(objRequest);
           }

           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Board");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllReligion(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllReligion(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Religion");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllTerm(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllTerm(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Term");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllBloodGroup(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllBloodGroup (objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Blood");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllLevel(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllLevel(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Level");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllRelationShip(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllRelationShip(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "RelationShip");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllStaffDesignation(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllStaffDesignation(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Designation");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllCaste(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllCaste(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Caste");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectStaffActivityTypeMaster(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectStaffActivityTypeMaster(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Staff ActivityTypeMaster");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllStaffData(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllStaffData(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Staff Master");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
       public SelectAllLookupDataResponse SelectAllActiveStaffData(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
             //  objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllActiveStaffData(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Staff Master");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllAccountTypeData(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllAccountTypeData(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Account Type Master");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllStaffTypeCategory(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllStaffTypeCategory(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Staff Type Category Master");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }


       public SelectAllLookupDataResponse SelectAllTemplate(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllTemplate(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Template");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }


       public SelectAllLookupDataResponse GetSampleTemplate(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;

           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.GetSampleTemplate(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Template");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }

       public SelectAllLookupDataResponse SelectAllLevelWiseClass(SelectAllCommonRequest objRequest)
       {
           SelectAllLookupDataResponse objResponse = null;
           try
           {
               BaseCommonSettingDAL objDAL = this.MyDal.GetDalRepository().GetCommonSettingDAL();
               objResponse = (SelectAllLookupDataResponse)objDAL.SelectAllLevelWiseClass(objRequest);
           }
           catch (Exception ex)
           {
               objResponse = new SelectAllLookupDataResponse();
               objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Level-wise Class Master");
               objResponse.ExceptionMessage = ex.Message;
               objResponse.StackTrace = ex.StackTrace;

               this.SetLogger(this.GetLogger());
               this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
           }
           return objResponse;

       }
    }
}
