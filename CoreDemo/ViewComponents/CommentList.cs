using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComments>
            {
                new UserComments
                {
                    ID = 1,
                    UserName = "Emrah"
                },
                new UserComments
                {
                    ID = 2,
                    UserName = "Merve"
                },
                new UserComments
                {
                    ID = 3,
                    UserName = "Mesut"
                }
            };
            return View(commentvalues);
        }
    }
}
