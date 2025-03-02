using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    // MVC Controller
    public class MovieController : Controller
    {
        //    // Action : Public non-static method
        //    // Actions : Have Special Return Types
        //    // ActionResult
        //    public ContentResult GetMovie(int id) 
        //    {
        //        var contentResult = new ContentResult()
        //        {
        //            Content = $"Get Movie With {id}",
        //            //ContentType = "text/html",
        //            ContentType = "object/pdf",
        //            StatusCode = 200 // Success

        //        };
        //        return contentResult;
        //    }



        //    public RedirectResult RedirectMovie(int id)
        //    {
        //        var redirectResult = new RedirectResult("https:/www.google.com/");
        //        return redirectResult;
        //    }


        //    public RedirectToActionResult RedirectToAction(int id)
        //    {
        //        var redirectResult = new RedirectToActionResult("AddMovie","Movie",new{ id =10 });
        //        return redirectResult;
        //    }


        //    //public ActionResult GetMovie2(int id)
        //    // It is recommended to Depend on the interface not the concret Class
        //    [ActionName("GetMovie2")]
        //    [HttpPost]
        //    public IActionResult GetMovie2(int id)
        //    {
        //        if (id == 1)
        //        {
        //            //return new ContentResult() { Content = $"Movie with {id}", ContentType = "text/html" };
        //            return  Content($"Movie with {id}", "text/html");
        //        }
        //        else if (id == 2)
        //        {
        //            // return new ContentResult() { Content = $"Movie with id: {id}", ContentType = "object/pdf" };
        //            return Content($"Movie with id: {id}", "object/pdf" );
        //        }
        //        else if (id == 3)
        //        {
        //           // return new RedirectResult("https://www.google.com/");
        //            return Redirect("https://www.google.com/");
        //        }
        //        else
        //        {
        //            return  RedirectToAction("AddMovie", "Movie", new { id = 6 });
        //        }


        //    }


        // Action Parameter Binding
        // 1. Form 
        // 2. Segment 
        // 3. Query Params
        // 4. Files

        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Get Movie with Id: {movie.Id} , Name: {movie.Name} ", "text/html");
        }
    }
}
