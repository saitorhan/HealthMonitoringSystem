using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HealthMonitoringSystem_WebApp {
    public partial class Register : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnCreateUser_Click(object sender, EventArgs e) {
            try {
                MembershipUser user = Membership.CreateUser(tbUserName.Text, tbPassword.Text, tbEmail.Text);
                Response.Redirect(Request.QueryString["ReturnUrl"] ?? "~/Account/RegisterSuccess.aspx");
            }
            catch (MembershipCreateUserException exc) {
                if (exc.StatusCode == MembershipCreateStatus.DuplicateEmail || exc.StatusCode == MembershipCreateStatus.InvalidEmail) {
                    tbEmail.ErrorText = exc.Message;
                    tbEmail.IsValid = false;
                }
                else if (exc.StatusCode == MembershipCreateStatus.InvalidPassword) {
                    tbPassword.ErrorText = exc.Message;
                    tbPassword.IsValid = false;
                }
                else {
                    tbUserName.ErrorText = exc.Message;
                    tbUserName.IsValid = false;
                }
            }
        }
    }
}