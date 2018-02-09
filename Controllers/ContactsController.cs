using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using addressBook.Models;

namespace addressBook.Models
{
  public class ContactsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View("index", allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult createForm()
    {
      return View();
    }

    [HttpPost("/contacts")]
    public ActionResult Create()
    {
      Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-address"]);
      List<Contact> allContacts = Contact.GetAll();
      return View("index",allContacts);
    }

    [HttpGet("/contacts/{id}")]
    public ActionResult Details(int id)
    {
      Contact contact = Contact.Find(id);
      return View(contact);
    }

    [HttpPost("/contacts/list/clear")]
    public ActionResult ClearList()
    {
      Contact.ClearAll();
      List<Contact> allContacts = new List<Contact> {};
      return View("index", allContacts);
    }
  }
}
