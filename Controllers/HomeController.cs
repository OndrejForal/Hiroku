using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDbExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstDbExercise.Controllers
{
    public class HomeController : Controller
    {
        public ToDoService service;
        public AsigneeService asignee;
        public HomeController(ToDoService service, AsigneeService asignee)
        {
            this.service = service;
            this.asignee = asignee;
        }

        [HttpGet("list")]
        public IActionResult List()
        {

            return View(service.ReadFromDb());
        }

        [HttpGet("add")]
        public IActionResult AddToDatabase()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult SaveToDatabase(string title, string description)
        {
            service.SaveToDb(title, description);
            return RedirectToAction("List", "Home");
        }

        [HttpGet("delete")]
        public IActionResult DeleteFromDatabase(int id)
        {
            service.DeteteFromDb(id);
            return RedirectToAction("List", "Home");
        }

        [HttpGet("edit")]
        public IActionResult EditInDatabase(int id)
        {
            var model = new IndexViewModel();
            model.Todo = service.LoadByID(id);
            model.Asignees = asignee.ReadAssFromDb();


                return View(model);
        }

        [HttpPost("edit")]
        public IActionResult SaveEditInDatabase(ToDo todo)
        {
            service.UpdateInDatabase(todo);
            return RedirectToAction("List", "Home");
        }

        [HttpPost("search")]
        public IActionResult SearchInDB(string searchedText)
        {

            return View(service.SearchInDb(searchedText));
        }

        [HttpGet("listOfAss")]
        public IActionResult ListOfAssignes()
        {

            return View(asignee.ReadAssFromDb());
        }

        [HttpGet("addAss")]
        public IActionResult AddAssToDatabase()
        {
            return View();
        }

        [HttpPost("addAss")]
        public IActionResult SaveAssToDatabase(string name, string email)
        {
            asignee.SaveAssToDb(name, email);

            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("deleteASS")]
        public IActionResult DeleteAssFromDatabase(int id)
        {
            asignee.DeteteAssFromDb(id);
            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("update")]
        public IActionResult UpdateAssInDB(string name, string email)
        {
           
            return View(asignee.context.Asignees.FirstOrDefault(d => d.Name == name && d.Email == email));
        }

        [HttpPost("update")]
        public IActionResult SaveUpdateInDatabase(Asignee ass)
        {
            asignee.UpdateAssInDatabase(ass);
            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("asignedList")]
        public IActionResult ShowAsignedList(int id)
        {
            
            return View(service.ReadAsignedToDoFromDb(id));
        }
    }
}
