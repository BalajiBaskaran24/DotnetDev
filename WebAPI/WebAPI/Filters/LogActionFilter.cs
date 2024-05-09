using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Code to execute before the action executes
            Console.WriteLine("Action executing...");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Code to execute after the action executes
            Console.WriteLine("Action executed...");
        }
    }

}
