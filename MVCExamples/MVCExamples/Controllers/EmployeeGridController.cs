using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample1.Models;
namespace MVCExample1.Controllers
{
    public class EmployeeGridController : Controller
    {
        // GET: EmployeeGrid
        public ActionResult Index()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string query = "SELECT [ID],[Username],[EmailID],[Fname],[Mname],[Lname],[Phone],[City] FROM [dbo].[EmployeeDetails]";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<EmployeeGrid> list = new List<EmployeeGrid>();
                EmployeeGrid emp;
                foreach (DataRow dr in dt.Rows)
                {
                    emp = new EmployeeGrid();
                    emp.ID = Convert.ToInt32(dr["ID"]);
                    emp.Username = dr["Username"].ToString();
                    emp.EmailID = dr["EmailID"].ToString();
                    emp.Fname = dr["Fname"].ToString();
                    emp.Mname = dr["Mname"].ToString();
                    emp.Lname = dr["Lname"].ToString();
                    emp.Phone = dr["Phone"].ToString();
                    emp.City = dr["City"].ToString();
                    list.Add(emp);
                }
                return View("Index", list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ActionResult Edit(int ID)
        {
            EmployeeGrid emp = new EmployeeGrid();
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string query = "SELECT [ID],[Username],[EmailID],[Fname],[Mname],[Lname],[Phone],[City] FROM [dbo].[EmployeeDetails] where ID=" + ID + "";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewBag.EditDetails = dt;
                //List<EmployeeGrid> list = new List<EmployeeGrid>();
                //foreach (DataRow dr in dt.Rows)
                //{
                emp.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                emp.Username = dt.Rows[0]["Username"].ToString();
                emp.EmailID = dt.Rows[0]["EmailID"].ToString();
                emp.Fname = dt.Rows[0]["Fname"].ToString();
                emp.Mname = dt.Rows[0]["Mname"].ToString();
                emp.Lname = dt.Rows[0]["Lname"].ToString();
                emp.Phone = dt.Rows[0]["Phone"].ToString();
                emp.City = dt.Rows[0]["City"].ToString();
                //    list.Add(emp);
                //}
            }
            catch (Exception ex)
            {
            }
            return View("Edit", emp);
        }
    }
}