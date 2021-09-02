﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webMvc.Models;
using webMvc.Services;

namespace webMvc.Controllers
{
    public class Employeecontroller : Controller
    {
        private EmployeeServices _empServices;
        public ActionResult List()
        {​​​​​​​

            _empServices = new EmployeeServices();
            var model = _empServices.GetEmployeeList();

            return View(model);
        }​​​​​​​
      
        public ActionResult AddEmployee()
        {​​​​​​ 
             return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel model)
        {
            _empServices = new EmployeeServices();
            _empServices.InsertEmployee(model);
            return RedirectToAction("List");
        }


        public ActionResult EditEmployee(int Id)
        {
            _empServices = new EmployeeServices();
            var model = _empServices.GetEditById(Id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(EmployeeModel model)
        {
            _empServices = new EmployeeServices();
            _empServices.UpdateEmp(model);
            return RedirectToAction("List");
        }
        public ActionResult DeleteEmployee(int Id)
        {
            _empServices = new EmployeeServices();
            _empServices.DeleteEmp(Id);
            return RedirectToAction("List");
        }

    }
}





