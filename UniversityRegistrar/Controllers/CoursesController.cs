using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityRegistrar.Models;

namespace UniversityRegistrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public CoursesController(UniversityRegistrarContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Courses.ToList());
    }

    public ActionResult Create()
    {
        ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Course course, int StudentId)
    {
        _db.Courses.Add(course);
        if (StudentId != 0)
        {
            _db.StudentCourse.Add(new StudentCourse() { StudentId = StudentId, CourseId = course.CourseId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisCourse = _db.Courses
            .Include(course => course.Students)
            .ThenInclude(join => join.Student)
            .FirstOrDefault(course => course.CourseId == id);
        return View(thisCourse);
    }

    public ActionResult Delete(int id)
    {
        var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
        return View(thisCourse);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
        _db.Courses.Remove(thisCourse);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
        ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
        return View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course, int StudentId)
    {
      if (StudentId != 0)
      {
        _db.StudentCourse.Add(new StudentCourse() { StudentId = StudentId, CourseId = course.CourseId });
      }
      _db.Entry(course).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddStudent(int id)
    {
        var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
        ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
        return View(thisCourse);
    }

    [HttpPost]
    public ActionResult AddStudent(Course course, int StudentId)
    {
        if (StudentId != 0)
        {
        _db.StudentCourse.Add(new StudentCourse() { StudentId = StudentId, CourseId = course.CourseId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteStudent(int joinId)
    {
        var joinEntry = _db.StudentCourse.FirstOrDefault(entry => entry.StudentCourseId == joinId);
        _db.StudentCourse.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}