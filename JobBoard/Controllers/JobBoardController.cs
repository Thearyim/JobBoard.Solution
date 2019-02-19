using Microsoft.AspNetCore.Mvc;
using JobOpenings.Models;
using System.Collections.Generic;
using System;

namespace JobOpenings.Controllers
{
  public class JobOpeningsController : Controller
  {

    [HttpGet("/jobopenings")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/jobopenings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobopenings")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      Contact myContact = new Contact(name, email, phoneNumber);
      JobOpening myJobOpening = new JobOpening(title, description, myContact);
      return View("Index", myJobOpening);
    }

  }
}
