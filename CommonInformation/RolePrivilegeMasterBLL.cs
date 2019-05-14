using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspace.Chalo.DataAccess.Factory;
using Inspace.Chalo.Types.Request.CommonRequest;
using Inspace.Chalo.Types.Response.CommonResponse;
using Inspace.Chalo.Types.General.ResourceStrings;
using Inspace.Chalo.Types.Request.CommonRequest.RolePrivilegeRequest;
using Inspace.Chalo.Types.Response.CommonResponse.RolePrivilegeMasterResponse;
using Inspace.Chalo.DataAccess.Interfaces.CommonInformation;
using Inspace.Chalo.Types.Response.CommonResponse.ScreenMasterResponse;
using Inspace.Chalo.Types.Request.CommonRequest.RoleMasterRequest;
using Inspace.Chalo.Types.Response.CommonResponse.RoleMasterResponse;
using Inspace.Chalo.Types.Response;


namespace Inspace.Chalo.BusinessLogic.CommonInformation
{
  public  class RolePrivilegeMasterBLL :BaseBL
    {
        public SaveOperationResponse InsertRecord(SaveRolePrivilegeMasterRequest objRequest)
        {
            SaveOperationResponse objResponse = null;
            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (SaveOperationResponse)objDAL.InsertRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveOperationResponse();
                objResponse.DisplayMessage = CommonStrings.SaveErrorMessage.Replace("{}", "Role Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SaveRolePrivilegeResponse UpdateRecord(SaveRolePrivilegeMasterRequest objRequest)
        {
            SaveRolePrivilegeResponse objResponse = null;

            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (SaveRolePrivilegeResponse)objDAL.UpdateRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SaveRolePrivilegeResponse();
                objResponse.DisplayMessage = CommonStrings.UpdateErrorMessage.Replace("{}", "Role Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;

        }

        public SelectRolePrivilegeMasterIdResponse SelectRecord(SelectRolePrivilegeMasterIdRequest objRequest)
        {
            SelectRolePrivilegeMasterIdResponse objResponse = null;

            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (SelectRolePrivilegeMasterIdResponse)objDAL.SelectRecord(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectRolePrivilegeMasterIdResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Role Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllRoleMasterResponse SelectAll(SelectAllCommonRequest objRequest)
        {
            SelectAllRoleMasterResponse objResponse = null;

            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (SelectAllRoleMasterResponse)objDAL.SelectAll(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllRoleMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Role Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public SelectAllRolePrivilegeMasterResponse SelectRoleAuthorization(SelectRolePrivilegeMasterIdRequest objRequest)
        {
            SelectAllRolePrivilegeMasterResponse objResponse = null;
            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (SelectAllRolePrivilegeMasterResponse)objDAL.LoadRoleAuthorization(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new SelectAllRolePrivilegeMasterResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Role Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }

        public ReadScreenPrivilegeResponse SelectScreenPrivilege(SelectRoleMasterIDRequest objRequest)
        {
            ReadScreenPrivilegeResponse objResponse = null;
            try
            {
                BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
                objResponse = (ReadScreenPrivilegeResponse)objDAL.LoadScreenPrivilege(objRequest);
            }
            catch (Exception ex)
            {
                objResponse = new ReadScreenPrivilegeResponse();
                objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Screen Privilege Master");
                objResponse.ExceptionMessage = ex.Message;
                objResponse.StackTrace = ex.StackTrace;

                this.SetLogger(this.GetLogger());
                this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return objResponse;
        }
        //public BaseResponseType LoadModule(SelectRoleMasterIDRequest objRequest)
        //{
        //    BaseResponseType objResponse = null;
        //    try
        //    {
        //        BaseRolePrivilegeMasterDAL objDAL = this.MyDal.GetDalRepository().GetRolePrivilegeMasterDAL();
        //        objResponse = (BaseResponseType)objDAL.LoadModule(objRequest);
        //    }
        //    catch (Exception ex)
        //    {
        //        objResponse = new ReadScreenPrivilegeResponse();
        //        objResponse.DisplayMessage = CommonStrings.RetrievalErrorMessage.Replace("{}", "Screen Privilege Master");
        //        objResponse.ExceptionMessage = ex.Message;
        //        objResponse.StackTrace = ex.StackTrace;

        //        this.SetLogger(this.GetLogger());
        //        this.WriteToLog(ex.Message + Environment.NewLine + ex.StackTrace);
        //    }
        //    return objResponse;
        //}

    }
}
