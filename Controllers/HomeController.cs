using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Push_Pull_Program.Data;
using Push_Pull_Program.Models;
using System.Diagnostics;
using System.IO;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Web;
using System;

namespace Push_Pull_Program.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Push_Pull_ProgramContext _context;
        
        public HomeController(ILogger<HomeController> logger, Push_Pull_ProgramContext context)
        {
            _context=context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public  FileResult CreateFile()
        {
            IQueryable<Empleado> empList =
                from emp in _context.Empleado
                select emp;
            
            
            var inventando =
                _context.Empleado.Select(emp => emp.Sexo);

            Console.WriteLine(inventando); 

            //foreach( IQueryable<> emp in inventando)
            //{

              
                
            //}

            Byte[] byteArray;
            byteArray=Encoding.ASCII.GetBytes(inventando.ToString());
            foreach (var employee  in inventando)
            {
                



            }
            //var byteArray = Encoding.ASCII.GetBytes(empList.ToString());

            MemoryStream stream = new MemoryStream(byteArray);

            var result = File(stream, "text/plain", "nomina.txt");

            return result;
         }
    }
    //SqlConnection cnn;
    //SqlCommand cmd;
    //string connectionString = null;
    //connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FAmericana_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    //string sql = "Select * from Empleados";

    //cnn = new SqlConnection(connectionString); 

    //cmd = new SqlCommand(sql, cnn);
    //var empList =
    //    from emp in _context.Empleados
    //    select emp;

    //var montoTotal = empList.Select(c => c.Salario).Sum();
    //var countEmp = empList.Select(c => c.Id).Count();

    //using (StreamWriter sw = System.IO.File.AppendText("C:\\Codigos\\nomina.txt"))
    //{
    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        sw.WriteLine("E101-00991-8FERRETERIAAMERICANA" + DateTime.Now + "\n");
    //        while (reader.Read())
    //        {
    //            sw.Write("D{0}{1}{2}{3}{4}", reader.GetString(0),
    //                reader.GetString(1), reader.GetDecimal(2), reader.GetString(3), reader.GetDateTime(4));
    //        }
    //        reader.Close();
    //    }
    //    sw.Write("S" + countEmp);
    //    cmd.Dispose();
    //    cnn.Close(); 
    //}

    //return RedirectToAction("Home");
}