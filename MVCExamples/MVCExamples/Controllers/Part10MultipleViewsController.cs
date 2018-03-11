using MVCExamples.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using BusinessObjects;
namespace MVCExamples.Controllers
{
    public class Part10MultipleViewsController : Controller
    {
        // GET: Part10MultipleViews
        public ActionResult Departments()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con_Emp"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string query = "SELECT [ID],[Department] FROM [dbo].[Department]";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<EmployeeDetails> list = new List<EmployeeDetails>();
                EmployeeDetails emp;
                foreach (DataRow dr in dt.Rows)
                {
                    emp = new EmployeeDetails();
                    emp.ID = Convert.ToInt32(dr["ID"]);
                    emp.Department = dr["Department"].ToString();
                    list.Add(emp);
                }
                return View("Departments", list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ActionResult DeptEmployees(int ID)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con_Emp"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string query = "select EmpID,Name from Employees where DepartmentID=" + ID + "";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<EmployeeDetails> list = new List<EmployeeDetails>();
                EmployeeDetails emp;
                foreach (DataRow dr in dt.Rows)
                {
                    emp = new EmployeeDetails();
                    emp.EmpID = Convert.ToInt32(dr["EmpID"]);
                    emp.Name = dr["Name"].ToString();
                    list.Add(emp);
                }


                return View("DeptEmployees", list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ActionResult GetEmployee(int ID)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con_Emp"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string query = "select EmpID,Name,Gender,City,DepartmentID from [dbo].[Employees] where EmpID=" + ID + "";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<EmployeeDetails> list = new List<EmployeeDetails>();
                EmployeeDetails emp;
                foreach (DataRow dr in dt.Rows)
                {
                    emp = new EmployeeDetails();
                    emp.EmpID = Convert.ToInt32(dr["EmpID"]);
                    emp.Name = dr["Name"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.Gender = dr["City"].ToString();
                    emp.Department = dr["DepartmentID"].ToString();
                    list.Add(emp);
                }


                return View("EmployeeDetails", list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        // Part 11 Object Model Impliementation
        public ActionResult Index()
        {
            EmployeeBusiness obj = new EmployeeBusiness();
            List<EmployeeBO> list = obj.DeptEmployees().ToList();


            return View("Testing", list);
        }

    }
}