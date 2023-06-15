using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using Day1.Services;

namespace Day1.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository studentService;//= new StudentRepository();
        IDepartmentRepository deptService;// = new DepartmentRepository();
        //DI 
        //IOC container ==ServiceProvider
        public StudentController(IStudentRepository _stdPro,IDepartmentRepository _deptRepo)
        {
            //intial
            studentService = _stdPro;
            deptService = _deptRepo;
        }

        //ITIEnitities context = new ITIEnitities();
        public IActionResult TestAjax()
        {
            return View();
        }
        public IActionResult testPArtial(int stdid)
        {
            return PartialView("_StudentCard", studentService.getById(stdid));
            //return View("Details", context.Student.FirstOrDefault()) ;
        }
        public IActionResult NameExist(string Name,int id,int Age)
        {
            //case Add NEw Student Add id=0;
            if (id == 0)
            {
                Student std = studentService.getByNAme(Name);
                if (std == null)//name not exist
                    return Json(true);//new {name="ahemd,age=22}
                else //name already exist
                    return Json(false);
            }
            else //edit\3
            {
                Student std = studentService.getByNAme(Name);
                if (std == null)
                    return Json(true);//update name with new value not exist befor
                else
                {
                    //object id==id parmeter true
                    if (std.ID == id)//name not change
                        return Json(true);
                    else
                        return Json(false);//chaged in name with value alread found
                }
            }
        }
        public IActionResult Add()
        { 
            List<Department> departments = deptService.getAll();
            ViewData["Depts"] = departments;
            return View();
        }
        [HttpPost]
        public IActionResult SaveAdd(Student std)
        {
            if (ModelState.IsValid == true)
            {
                studentService.Create(std);
                return RedirectToAction("Index");
            }else if(std.Name != "ITI")
            {
                ModelState.AddModelError("myName", "NAme Must Be ITI");//not relate to specific model property
            }
            List<Department> departments = deptService.getAll();
            ViewData["Depts"] = departments;
            return View("Add", std);
        }
        
        
        public IActionResult Index()
        {
            return View(studentService.getAll());
        }
        //student/edit/1?age=33 ==Form get or anchor tage
        public IActionResult Edit(int id )
        {
            List<Department> departments = deptService.getAll();
            ViewData["Depts"] = departments;
            Student std = studentService.getById(id);
            return View(std);//+all DEpt action==>view
        }
        public IActionResult DEtails(int id)
        {
            Student std = studentService.getById(id);
            return View(std);
        }

        //call db
        //student/edit/1
        //[HttpGet]//link or form method="get
        [HttpPost]//<form method="post">
        public IActionResult SaveEdit([FromRoute]int id,Student newStudent)
        {
            if (ModelState.IsValid)
            {
                studentService.Update(id, newStudent);
                return RedirectToAction("Index");
            }
            List<Department> departments = deptService.getAll();
            ViewData["Depts"] = departments;
            return View("Edit",newStudent);
        }


        public IActionResult Delete(int id)
        {
            try
            {
                studentService.Delete(id);
                return RedirectToAction("index");
            }catch(Exception ex)
            {
                ModelState.AddModelError("Exception", ex.InnerException.Message);//
                //exception client
                return View("Details");
            }
        }
    }
}
