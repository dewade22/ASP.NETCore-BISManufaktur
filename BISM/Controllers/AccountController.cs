using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BISM.Models.MainSystem;
using BISM.helpers;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Text;
using System.Reflection;
using Newtonsoft.Json;

namespace BISM.Controllers
{
    public class AccountController : Controller
    {
        private readonly MainSystemContext _mainSystemContext;

        public AccountController(MainSystemContext mainSystemContext)
        {
            _mainSystemContext = mainSystemContext;
        }



        [BindProperty]
        public string ReturnUrl { get; set; }

        public IActionResult Login(string returnUrl= null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public IActionResult SignIn(Systemusers systemUser, string returnUrl = null)
        {
            if(systemUser.UserCode != null && systemUser.UserCode != "")
            {
                var result = _mainSystemContext.Systemusers.Where(s => s.UserCode == systemUser.UserCode).FirstOrDefault();

                if(result != null)
                {
                    string userPass = dbSecurity.MD5(systemUser.UserPassword);
                    if(result.UserPassword == userPass)
                    {
                        HttpContext.Session.SetString("UserCode", result.UserCode);
                        var _systemuserroles = _mainSystemContext.Systemuserroles.FirstOrDefault(a => a.UserCode == result.UserCode && a.DefaultCompany == 1);
                        HttpContext.Session.SetString("Role", _systemuserroles.RoleId);
                        HttpContext.Session.SetString("CompanyCode", _systemuserroles.CompanyCode);
                        string roles = HttpContext.Session.GetString("Role");
                        List<Systemusermenu> SystemUserMenus = _mainSystemContext.Systemusermenu.Where(s => s.RoleId == roles && s.CompanyCode == _systemuserroles.CompanyCode).OrderBy(a => a.SeqNo).ToList();

                        DataSet ds = new DataSet();
                        ds = ToDataSet(SystemUserMenus);
                        DataTable table = ds.Tables[0];
                        DataRow[] parentMenus = table.Select("ParentId = 1");

                        var sb = new StringBuilder();
                        string menuString = GenerateUL(parentMenus, table, sb);
                        HttpContext.Session.SetString("menuString", menuString);
                        HttpContext.Session.SetString("menus", JsonConvert.SerializeObject(SystemUserMenus));

                        return Json(new { status = true, message = "Login Successfull!", returnUrl = returnUrl });
                    }
                    else
                    {
                        return Json(new { status = false, message = "Invalid Password!" });
                    }
                }
                else
                {
                    return Json(new { status = false, message = "User Not Found!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid UserName!" });
            }
        }

        /*private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string url = dr["Url"].ToString();
                    string menuText = dr["Name"].ToString();
                    string icon = dr["Icon"].ToString();

                    if (url != "#")
                    {
                        string line = String.Format(@"<li class=""@Url.MakeActiveClass(""home"", ""index"")""><a href=""{0}""><i class=""{2}""></i> {1} </a></li>", url, menuText, icon);
                        sb.Append(line);
                    }

                    string pid = dr["Id"].ToString();
                    string parentId = dr["ParentId"].ToString();

                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""sub-menu""><a href=""#"" data-ma-action=""submenu-toggle""><i class=""{0}""></i>{1}</a><ul>", icon, menuText);
                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(line);
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.Append("</ul></li>");
                    }
                }
            }
            return sb.ToString();
        }
        */
        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    var _SystemObject = _mainSystemContext.Systemobject.Where(s => s.SystemObjectId == Convert.ToInt32(dr["ChildID"])).FirstOrDefault();
                    string objecttype = _SystemObject.ObjectType.ToString();
                    string menuText = _SystemObject.ObjectDesc.ToString();
                    string ControllerName = _SystemObject.ControllerName.ToString();
                    string ActionName = _SystemObject.ActionName.ToString();
                    string urllink = Url.Action(ActionName, ControllerName);
                    string icon = "zmdi zmdi-home"; // _SystemObject.icon.ToString();
                    
                    if (objecttype != "Menu" || menuText == "LogOff")
                    {
                        string line = String.Format(@"<li class=""@Url.MakeActiveClass(""{0}"")""><a href = ""{0}""><i class=""{2}""></i> {1} </a></li>", urllink, menuText, icon);
                        //string lineAsli = String.Format(@"<li><a href=""{0}""><i class=""{2}""></i> <span>{1}</span></a></li>", url, menuText, icon);
                        sb.Append(line);
                    }
                    string pid = dr["ChildID"].ToString();
                    string parentId = dr["ParentId"].ToString();
                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""sub-menu""><a href=""#"" data-ma-action=""submenu-toggle""><i class=""{0}""></i>{1}</a><ul>", icon, menuText);
                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(line);
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.Append("</ul></li>");
                    }
                }
            }
            return sb.ToString();
        }

        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}