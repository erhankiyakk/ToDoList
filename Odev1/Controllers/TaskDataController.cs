using Odev1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev1.Controllers
{
    public class TaskDataController : Controller
    {
        // GET: TaskData
        public ActionResult ToDoView()
        {
            List<ToDo> myTask = new List<ToDo>
            {
                new ToDo
                {
                    MyTask="Check Mails"
                },
                new ToDo
                {
                    MyTask="Pay The Bills"
                },
                new ToDo
                {
                    MyTask="Shopping"
                }
            };
            return View(myTask);
        }
    }
}