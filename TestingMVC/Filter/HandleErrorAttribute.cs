using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TestingMVC.Filter
{
    public class HandleErrorAttribute : Attribute, IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = context.Exception.Message;
            //context.Result= contentResult;

            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Error";
            context.Result = viewResult;
        }
    }
}
