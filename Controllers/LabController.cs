using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcSkeleton.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcSkeleton.Controllers
{
    public class LabController : Controller
    {
        public IActionResult Index()
        {
            LabList labs = LabList.getInstance();
            return View(labs.Labs);
        }

        public IActionResult About() 
        {
            return View();
        }

        public IActionResult Details(int? id) 
        {
            LabList labs = LabList.getInstance();
            Lab lab = (from l in labs
                       where l.id == id
                       select l).FirstOrDefault();
            if (lab != null)
                return View(lab);
            else
                return NotFound();
        }

        public IActionResult Labs() 
        {
            LabList labs = LabList.getInstance();
            return View(labs.Labs);
        }

        //----< gets form to edit a specific course via id >---------
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            LabList labs = LabList.getInstance();
            Lab lab = (from l in labs
                       where l.id == id
                       select l).FirstOrDefault();
            if (lab != null)
                return View(lab);
            else
                return NotFound();
        }

        //----< posts back edited results for specific course >------
        [HttpPost]
        public IActionResult Edit(int id, Lab newlab)
        {
            LabList labs = LabList.getInstance();
            int index = labs.Select((l, i) => new {l, i}).Where(v => v.l.id == id).Select(u=>u.i).FirstOrDefault();
            labs[index] = newlab;
            return RedirectToAction("details", new { id = id});
        }

        public IActionResult Delete(int id)
        {
            LabList labs = LabList.getInstance();
            int index = labs.Select((l, i) => new { l, i }).Where(v => v.l.id == id).Select(u => u.i).FirstOrDefault();
            labs.delete(index);
            return RedirectToAction("labs");
        }

        //----< gets form for creating a course >--------------------

        [HttpGet]
        public IActionResult Create(int id)
        {
            LabList labs = LabList.getInstance();

            var model = new Lab();
            model.id = labs.Last().id + 1;
            return View(model);
        }
        //----< posts back new courses details >---------------------

        [HttpPost]
        public IActionResult Create(int id, Lab lab)
        {
            LabList labs = LabList.getInstance();
            labs.add(lab);
            return RedirectToAction("labs");
        }
    }



}
