// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace TheWayOfTheAlex.Controllers {
    public partial class AccountController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AccountController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AccountController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Login() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Login);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AccountController Actions { get { return MVC.Account; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Account";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Account";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Login = "Login";
            public readonly string LogOff = "LogOff";
            public readonly string Register = "Register";
            public readonly string ChangePassword = "ChangePassword";
            public readonly string ChangePasswordSuccess = "ChangePasswordSuccess";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Login = "Login";
            public const string LogOff = "LogOff";
            public const string Register = "Register";
            public const string ChangePassword = "ChangePassword";
            public const string ChangePasswordSuccess = "ChangePasswordSuccess";
        }


        static readonly ActionParamsClass_Login s_params_Login = new ActionParamsClass_Login();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Login LoginParams { get { return s_params_Login; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Login {
            public readonly string returnUrl = "returnUrl";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string ChangePassword = "~/Views/Account/ChangePassword.cshtml";
            public readonly string ChangePasswordSuccess = "~/Views/Account/ChangePasswordSuccess.cshtml";
            public readonly string Login = "~/Views/Account/Login.cshtml";
            public readonly string Register = "~/Views/Account/Register.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_AccountController: TheWayOfTheAlex.Controllers.AccountController {
        public T4MVC_AccountController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Login(string returnUrl) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Login(TheWayOfTheAlex.Models.LoginModel model, string returnUrl) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult LogOff() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.LogOff);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Register() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Register);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Register(TheWayOfTheAlex.Models.RegisterModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Register);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangePassword() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangePassword);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangePassword(TheWayOfTheAlex.Models.ChangePasswordModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangePassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangePasswordSuccess() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangePasswordSuccess);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
