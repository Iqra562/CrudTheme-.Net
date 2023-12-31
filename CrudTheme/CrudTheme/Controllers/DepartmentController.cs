﻿using CrudTheme.Data;
using CrudTheme.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudTheme.Controllers
{
    public class DepartmentController : Controller
    {  
        private ApplicationDbContext _db;
         public DepartmentController(ApplicationDbContext db)
        {
            _db =db;
        }
        public IActionResult Index()
        {
            return View(_db.Departments);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public IActionResult Edit(int id)
        {
            Department  dep= _db.Departments.Find(id);
            return View(dep);

        }

        [HttpPost]
        public IActionResult Edit(Department  dep)
        {
            if (ModelState.IsValid)
            {
                Department editDepartment = _db.Departments.Find(dep.DepartmentId);
                editDepartment.DepartmentName = dep.DepartmentName;
                editDepartment.LastUpdatedAt = DateTime.Now;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dep);
        }

    }
}
