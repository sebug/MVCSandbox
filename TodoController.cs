using Microsoft.AspNet.Mvc;
using Models;

// Insert lame joke about the millions of TODO applications built in Rails.
public class TodoController : Controller
{
  public ActionResult Index()
  {
    var todoItem = new TodoItem 
      {
	Description = "Fix indentation."
      };
    return Json(todoItem);
  }
}

