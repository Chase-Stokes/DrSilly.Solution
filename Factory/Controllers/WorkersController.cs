using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class WorkersController : Controller
  {
    private readonly FactoryContext _db;

    public WorkersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
        return View(_db.Workers.ToList());
    }

    public ActionResult Create()
    {
        ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Worker worker, int MachineId)
    {
        _db.Workers.Add(worker);
        _db.SaveChanges();
        if (MachineId != 0)
        {
            _db.WorkerMachine.Add(new WorkerMachine() { MachineId = MachineId, WorkerId = worker.WorkerId });
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisWorker = _db.Workers
        .Include(worker => worker.JoinEntities)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(worker => worker.WorkerId == id);
        return View(thisWorker);
    }

    public ActionResult Edit(int id)
    {
        var thisWorker = _db.Workers.FirstOrDefault(worker => worker.WorkerId == id);
        ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
        return View(thisWorker);
    }

    [HttpPost]
    public ActionResult Edit(Worker worker, int MachineId)
    {
      if (MachineId != 0)
      {
        _db.WorkerMachine.Add(new WorkerMachine() { MachineId = MachineId, WorkerId = worker.WorkerId });
      }
      _db.Entry(worker).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
        var thisWorker = _db.Workers.FirstOrDefault(worker => worker.WorkerId == id);
        ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
        return View(thisWorker);
    }

    [HttpPost]
    public ActionResult AddMachine(Worker worker, int MachineId)
    {
        if (MachineId != 0)
        {
          _db.WorkerMachine.Add(new WorkerMachine() { MachineId = MachineId, WorkerId = worker.WorkerId });
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisWorker = _db.Workers.FirstOrDefault(worker => worker.WorkerId == id);
        return View(thisWorker);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisWorker = _db.Workers.FirstOrDefault(worker => worker.WorkerId == id);
        _db.Workers.Remove(thisWorker);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
        var joinEntry = _db.WorkerMachine.FirstOrDefault(entry => entry.WorkerMachineId == joinId);
        _db.WorkerMachine.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}