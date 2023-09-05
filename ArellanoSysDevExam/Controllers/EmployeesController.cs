using ArellanoSysDevExam.Data;
using ArellanoSysDevExam.Models;
using ArellanoSysDevExam.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace ArellanoSysDevExam.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ExamDbContext examDbContext;

        public EmployeesController(ExamDbContext examDbContext)
        {
            this.examDbContext = examDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await examDbContext.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeRequest)
        {
            var employee = new Employee()
            {
                employeeid = Guid.NewGuid(),
                last_name = addEmployeRequest.last_name,
                first_name = addEmployeRequest.first_name,
                middle_name = addEmployeRequest.middle_name,
                datehired = addEmployeRequest.datehired,
                isactive = addEmployeRequest.isactive,
                imagepath = addEmployeRequest.imagepath
            };

            await examDbContext.Employees.AddAsync(employee);
            await examDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var employee = await examDbContext.Employees.FirstOrDefaultAsync(x => x.employeeid == id);

            if (employee != null) {
                var viewModel = new UpdateEmployeeViewModel()
                {
                    employeeid = employee.employeeid,
                    last_name = employee.last_name,
                    first_name = employee.first_name,
                    middle_name = employee.middle_name,
                    datehired = employee.datehired,
                    isactive = employee.isactive,
                    imagepath = employee.imagepath
                };
                return await Task.Run(() => View("View", viewModel));
            };

            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateEmployeeViewModel model)
        {
            var employee = await examDbContext.Employees.FindAsync(model.employeeid);

            if (employee.employeeid != null)
            {
                employee.first_name = model.first_name;
                employee.middle_name = model.middle_name;
                employee.last_name = model.last_name;
                employee.datehired = model.datehired;
                employee.imagepath = model.imagepath;

                await examDbContext.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel model) 
        {
            var employee = await examDbContext.Employees.FindAsync(model.employeeid);

            if (employee != null)
            {
                
                examDbContext.Remove(employee);
                await examDbContext.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");
        }

    }
}
