using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.DAO;
using Project_Group3.Models;

namespace Project_Group3.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            var instructorList = InstructorDAO.Instance.GetInstructorlist();
            return View(instructorList);
        }

        public IActionResult Detail(string instructorID)
        {
            instructorID = "1";
            if (string.IsNullOrEmpty(instructorID))
            {
                return NotFound();
            }

            var instructor = InstructorDAO.Instance.GetInstructorByID(instructorID);

            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instructor instructor){
            try{
                if(ModelState.IsValid){
                    InstructorDAO.Instance.AddNew(instructor);
                }
                return RedirectToAction(nameof(Index));
            }catch(Exception ex){
                ViewBag.Message = ex.Message;
                return View(instructor);
            }
        }

        public IActionResult Edit(string instructorID)
        {
            instructorID = "1";
            if(string.IsNullOrEmpty(instructorID)){
                return NotFound();
            }
            var instructor = InstructorDAO.Instance.GetInstructorByID(instructorID);
            if(instructor == null){
                return NotFound();
            }
            return View(instructor);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string instructorID, Instructor ins){
            try{
                if(id != car.CarId){
                    return NotFound();
                }
                if(ModelState.IsValid){
                    carRepository.UpdateCar(car);
                }
                return RedirectToAction(nameof(Index));
            }catch(Exception ex){
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}