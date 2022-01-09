using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyCV.html.Controllers
{
    [HttpController]
    public class MyCVhtmlControllersBase
    {
    }

    [HttpController]

    public class MyCVhtmlControllers : ControllerBase
    {
       new public virtual AcceptedResult Accepted()
        {
            return base.Accepted();
        }

        new public virtual AcceptedResult Accepted([ActionResultObjectValue] object value)
        {
            return base.Accepted(value);
        }

        new public virtual AcceptedResult Accepted(Uri uri)
        {
            return base.Accepted(uri);
        }

        new public virtual AcceptedResult Accepted(string uri)
        {
            return base.Accepted(uri);
        }

        new public virtual AcceptedResult Accepted(string uri, [ActionResultObjectValue] object value)
        {
            return base.Accepted(uri, value);
        }


        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName)
        {
            return base.AcceptedAtAction(actionName);
        }

        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName)
        {
            return base.AcceptedAtAction(actionName, controllerName);
        }

        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName, [ActionResultObjectValue] object value)
        {
            return base.AcceptedAtAction(actionName, value);
        }

        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName, [ActionResultObjectValue] object routeValues)
        {
            return base.AcceptedAtAction(actionName, controllerName, routeValues);
        }

        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.AcceptedAtAction(actionName, routeValues, value);
        }

        new public virtual AcceptedAtActionResult AcceptedAtAction(string actionName, string controllerName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.AcceptedAtAction(actionName, controllerName, routeValues, value);
        }

        new public virtual AcceptedAtRouteResult AcceptedAtRoute([ActionResultObjectValue] object routeValues)
        {
            return base.AcceptedAtRoute(routeValues);
        }

        new public virtual AcceptedAtRouteResult AcceptedAtRoute(string routeName)
        {
            return base.AcceptedAtRoute(routeName);
        }

        new public virtual AcceptedAtRouteResult AcceptedAtRoute(string routeName, object routeValues)
        {
            return base.AcceptedAtRoute(routeName, routeValues);
        }

        new public virtual AcceptedAtRouteResult AcceptedAtRoute(object routeValues, [ActionResultObjectValue] object value)
        {
            return base.AcceptedAtRoute(routeValues, value);
        }

        new public virtual AcceptedAtRouteResult AcceptedAtRoute(string routeName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.AcceptedAtRoute(routeName, routeValues, value);
        }

        new public virtual BadRequestResult BadRequest()
        {
            return base.BadRequest();
        }

        new public virtual BadRequestObjectResult BadRequest([ActionResultObjectValue] object error)
        {
            return base.BadRequest(error);
        }

        new public virtual BadRequestObjectResult BadRequest([ActionResultObjectValue] ModelStateDictionary modelState)
        {
            return base.BadRequest(modelState);
        }

        new public virtual ChallengeResult Challenge()
        {
            return base.Challenge();
        }

        new public virtual ChallengeResult Challenge(params string[] authenticationSchemes)
        {
            return base.Challenge(authenticationSchemes);
        }

        new public virtual ChallengeResult Challenge(AuthenticationProperties properties)
        {
            return base.Challenge(properties);
        }

        new public virtual ChallengeResult Challenge(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.Challenge(properties, authenticationSchemes);
        }

        new public virtual ConflictResult Conflict()
        {
            return base.Conflict();
        }

        new public virtual ConflictObjectResult Conflict([ActionResultObjectValue] object error)
        {
            return base.Conflict(error);
        }

        new public virtual ConflictObjectResult Conflict([ActionResultObjectValue] ModelStateDictionary modelState)
        {
            return base.Conflict(modelState);
        }

        new public virtual ContentResult Content(string content)
        {
            return base.Content(content);
        }

        new public virtual ContentResult Content(string content, string contentType)
        {
            return base.Content(content, contentType);
        }

        new public virtual ContentResult Content(string content, string contentType, Encoding contentEncoding)
        {
            return base.Content(content, contentType, contentEncoding);
        }

        new public virtual ContentResult Content(string content, MediaTypeHeaderValue contentType)
        {
            return base.Content(content, contentType);
        }

        new public virtual CreatedResult Created(string uri, [ActionResultObjectValue] object value)
        {
            return base.Created(uri, value);
        }

        new public virtual CreatedResult Created(Uri uri, [ActionResultObjectValue] object value)
        {
            return base.Created(uri, value);
        }

        new public virtual CreatedAtActionResult CreatedAtAction(string actionName, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtAction(actionName, value);
        }

        new public virtual CreatedAtActionResult CreatedAtAction(string actionName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtAction(actionName, routeValues, value);
        }

       new  public virtual CreatedAtActionResult CreatedAtAction(string actionName, string controllerName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtAction(actionName, controllerName, routeValues, value);
        }

       new public virtual CreatedAtRouteResult CreatedAtRoute(string routeName, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtRoute(routeName, value);
        }

       new public virtual CreatedAtRouteResult CreatedAtRoute(object routeValues, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtRoute(routeValues, value);
        }

       new public virtual CreatedAtRouteResult CreatedAtRoute(string routeName, object routeValues, [ActionResultObjectValue] object value)
        {
            return base.CreatedAtRoute(routeName, routeValues, value);
        }

       new public virtual bool Equals(object obj)
        {
            return base.Equals(obj);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType)
        {
            return base.File(fileContents, contentType);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, bool enableRangeProcessing)
        {
            return base.File(fileContents, contentType, enableRangeProcessing);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName)
        {
            return base.File(fileContents, contentType, fileDownloadName);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, bool enableRangeProcessing)
        {
            return base.File(fileContents, contentType, fileDownloadName, enableRangeProcessing);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(fileContents, contentType, lastModified, entityTag);
        }

        new public virtual FileContentResult File(byte[] fileContents, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(fileContents, contentType, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(fileContents, contentType, fileDownloadName, lastModified, entityTag);
        }

       new public virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(fileContents, contentType, fileDownloadName, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType)
        {
            return base.File(fileStream, contentType);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType, bool enableRangeProcessing)
        {
            return base.File(fileStream, contentType, enableRangeProcessing);
        }

        new public virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName)
        {
            return base.File(fileStream, contentType, fileDownloadName);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName, bool enableRangeProcessing)
        {
            return base.File(fileStream, contentType, fileDownloadName, enableRangeProcessing);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(fileStream, contentType, lastModified, entityTag);
        }

        new public virtual FileStreamResult File(Stream fileStream, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(fileStream, contentType, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(fileStream, contentType, fileDownloadName, lastModified, entityTag);
        }

       new public virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(fileStream, contentType, fileDownloadName, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual VirtualFileResult File(string virtualPath, string contentType)
        {
            return base.File(virtualPath, contentType);
        }

       new public virtual VirtualFileResult File(string virtualPath, string contentType, bool enableRangeProcessing)
        {
            return base.File(virtualPath, contentType, enableRangeProcessing);
        }

        new public virtual VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName)
        {
            return base.File(virtualPath, contentType, fileDownloadName);
        }

        new public virtual VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, bool enableRangeProcessing)
        {
            return base.File(virtualPath, contentType, fileDownloadName, enableRangeProcessing);
        }

       new public virtual VirtualFileResult File(string virtualPath, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(virtualPath, contentType, lastModified, entityTag);
        }

        new public virtual VirtualFileResult File(string virtualPath, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(virtualPath, contentType, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.File(virtualPath, contentType, fileDownloadName, lastModified, entityTag);
        }

        new public virtual VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.File(virtualPath, contentType, fileDownloadName, lastModified, entityTag, enableRangeProcessing);
        }

        new public virtual ForbidResult Forbid()
        {
            return base.Forbid();
        }

        new public virtual ForbidResult Forbid(params string[] authenticationSchemes)
        {
            return base.Forbid(authenticationSchemes);
        }

        new public virtual ForbidResult Forbid(AuthenticationProperties properties)
        {
            return base.Forbid(properties);
        }

       new public virtual ForbidResult Forbid(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.Forbid(properties, authenticationSchemes);
        }

        new public virtual int GetHashCode()
        {
            return base.GetHashCode();
        }

        new public virtual LocalRedirectResult LocalRedirect(string localUrl)
        {
            return base.LocalRedirect(localUrl);
        }

        new public virtual LocalRedirectResult LocalRedirectPermanent(string localUrl)
        {
            return base.LocalRedirectPermanent(localUrl);
        }

        new public virtual LocalRedirectResult LocalRedirectPermanentPreserveMethod(string localUrl)
        {
            return base.LocalRedirectPermanentPreserveMethod(localUrl);
        }

        new public virtual LocalRedirectResult LocalRedirectPreserveMethod(string localUrl)
        {
            return base.LocalRedirectPreserveMethod(localUrl);
        }

       new public virtual NoContentResult NoContent()
        {
            return base.NoContent();
        }

       new public virtual NotFoundResult NotFound()
        {
            return base.NotFound();
        }

       new public virtual NotFoundObjectResult NotFound([ActionResultObjectValue] object value)
        {
            return base.NotFound(value);
        }

       new public virtual OkResult Ok()
        {
            return base.Ok();
        }

       new public virtual OkObjectResult Ok([ActionResultObjectValue] object value)
        {
            return base.Ok(value);
        }

        new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType)
        {
            return base.PhysicalFile(physicalPath, contentType);
        }

        new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, bool enableRangeProcessing)
        {
            return base.PhysicalFile(physicalPath, contentType, enableRangeProcessing);
        }

        new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName)
        {
            return base.PhysicalFile(physicalPath, contentType, fileDownloadName);
        }

       new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, bool enableRangeProcessing)
        {
            return base.PhysicalFile(physicalPath, contentType, fileDownloadName, enableRangeProcessing);
        }

        new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.PhysicalFile(physicalPath, contentType, lastModified, entityTag);
        }

       new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.PhysicalFile(physicalPath, contentType, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag)
        {
            return base.PhysicalFile(physicalPath, contentType, fileDownloadName, lastModified, entityTag);
        }

       new public virtual PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName, DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing)
        {
            return base.PhysicalFile(physicalPath, contentType, fileDownloadName, lastModified, entityTag, enableRangeProcessing);
        }

       new public virtual ObjectResult Problem(string detail = null, string instance = null, int? statusCode = null, string title = null, string type = null)
        {
            return base.Problem(detail, instance, statusCode, title, type);
        }

       new public virtual RedirectResult Redirect(string url)
        {
            return base.Redirect(url);
        }

       new public virtual RedirectResult RedirectPermanent(string url)
        {
            return base.RedirectPermanent(url);
        }

       new public virtual RedirectResult RedirectPermanentPreserveMethod(string url)
        {
            return base.RedirectPermanentPreserveMethod(url);
        }

        new public virtual RedirectResult RedirectPreserveMethod(string url)
        {
            return base.RedirectPreserveMethod(url);
        }

        new public virtual RedirectToActionResult RedirectToAction()
        {
            return base.RedirectToAction();
        }

        new public virtual RedirectToActionResult RedirectToAction(string actionName)
        {
            return base.RedirectToAction(actionName);
        }

         new public virtual RedirectToActionResult RedirectToAction(string actionName, object routeValues)
        {
            return base.RedirectToAction(actionName, routeValues);
        }

        new public virtual RedirectToActionResult RedirectToAction(string actionName, string controllerName)
        {
            return base.RedirectToAction(actionName, controllerName);
        }

        new public virtual RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues)
        {
            return base.RedirectToAction(actionName, controllerName, routeValues);
        }

        new public virtual RedirectToActionResult RedirectToAction(string actionName, string controllerName, string fragment)
        {
            return base.RedirectToAction(actionName, controllerName, fragment);
        }

       new public virtual RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues, string fragment)
        {
            return base.RedirectToAction(actionName, controllerName, routeValues, fragment);
        }

       new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName)
        {
            return base.RedirectToActionPermanent(actionName);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName, object routeValues)
        {
            return base.RedirectToActionPermanent(actionName, routeValues);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName)
        {
            return base.RedirectToActionPermanent(actionName, controllerName);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, string fragment)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, fragment);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, routeValues);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, routeValues, fragment);
        }

        new public virtual RedirectToActionResult RedirectToActionPermanentPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToActionPermanentPreserveMethod(actionName, controllerName, routeValues, fragment);
        }

       new public virtual RedirectToActionResult RedirectToActionPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToActionPreserveMethod(actionName, controllerName, routeValues, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName)
        {
            return base.RedirectToPage(pageName);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName, object routeValues)
        {
            return base.RedirectToPage(pageName, routeValues);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName, string pageHandler)
        {
            return base.RedirectToPage(pageName, pageHandler);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues)
        {
            return base.RedirectToPage(pageName, pageHandler, routeValues);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName, string pageHandler, string fragment)
        {
            return base.RedirectToPage(pageName, pageHandler, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment)
        {
            return base.RedirectToPage(pageName, pageHandler, routeValues, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanent(string pageName)
        {
            return base.RedirectToPagePermanent(pageName);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues)
        {
            return base.RedirectToPagePermanent(pageName, routeValues);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, string fragment)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues, string fragment)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler, routeValues, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPagePermanentPreserveMethod(string pageName, string pageHandler = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToPagePermanentPreserveMethod(pageName, pageHandler, routeValues, fragment);
        }

        new public virtual RedirectToPageResult RedirectToPagePreserveMethod(string pageName, string pageHandler = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToPagePreserveMethod(pageName, pageHandler, routeValues, fragment);
        }

        new public virtual RedirectToRouteResult RedirectToRoute(string routeName)
        {
            return base.RedirectToRoute(routeName);
        }

        new public virtual RedirectToRouteResult RedirectToRoute(object routeValues)
        {
            return base.RedirectToRoute(routeValues);
        }

        new public virtual RedirectToRouteResult RedirectToRoute(string routeName, object routeValues)
        {
            return base.RedirectToRoute(routeName, routeValues);
        }

        new public virtual RedirectToRouteResult RedirectToRoute(string routeName, string fragment)
        {
            return base.RedirectToRoute(routeName, fragment);
        }

        new public virtual RedirectToRouteResult RedirectToRoute(string routeName, object routeValues, string fragment)
        {
            return base.RedirectToRoute(routeName, routeValues, fragment);
        }

        new public virtual RedirectToRouteResult RedirectToRoutePermanent(string routeName)
        {
            return base.RedirectToRoutePermanent(routeName);
        }

        new public virtual RedirectToRouteResult RedirectToRoutePermanent(object routeValues)
        {
            return base.RedirectToRoutePermanent(routeValues);
        }

        new public virtual RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues)
        {
            return base.RedirectToRoutePermanent(routeName, routeValues);
        }

        new public virtual RedirectToRouteResult RedirectToRoutePermanent(string routeName, string fragment)
        {
            return base.RedirectToRoutePermanent(routeName, fragment);
        }

        new public virtual RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues, string fragment)
        {
            return base.RedirectToRoutePermanent(routeName, routeValues, fragment);
        }

       new public virtual RedirectToRouteResult RedirectToRoutePermanentPreserveMethod(string routeName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToRoutePermanentPreserveMethod(routeName, routeValues, fragment);
        }

       new public virtual RedirectToRouteResult RedirectToRoutePreserveMethod(string routeName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToRoutePreserveMethod(routeName, routeValues, fragment);
        }

       new public virtual SignInResult SignIn(ClaimsPrincipal principal)
        {
            return base.SignIn(principal);
        }

        new public virtual SignInResult SignIn(ClaimsPrincipal principal, string authenticationScheme)
        {
            return base.SignIn(principal, authenticationScheme);
        }

        new public virtual SignInResult SignIn(ClaimsPrincipal principal, AuthenticationProperties properties)
        {
            return base.SignIn(principal, properties);
        }

        new public virtual SignInResult SignIn(ClaimsPrincipal principal, AuthenticationProperties properties, string authenticationScheme)
        {
            return base.SignIn(principal, properties, authenticationScheme);
        }

        new public virtual SignOutResult SignOut()
        {
            return base.SignOut();
        }

        new public virtual SignOutResult SignOut(AuthenticationProperties properties)
        {
            return base.SignOut(properties);
        }

        new public virtual SignOutResult SignOut(params string[] authenticationSchemes)
        {
            return base.SignOut(authenticationSchemes);
        }

        new public virtual SignOutResult SignOut(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.SignOut(properties, authenticationSchemes);
        }

        new public virtual StatusCodeResult StatusCode([ActionResultStatusCode] int statusCode)
        {
            return base.StatusCode(statusCode);
        }

        new public virtual ObjectResult StatusCode([ActionResultStatusCode] int statusCode, [ActionResultObjectValue] object value)
        {
            return base.StatusCode(statusCode, value);
        }

        new public virtual string ToString()
        {
            return base.ToString();
        }

        public override Task<bool> TryUpdateModelAsync<TModel>(TModel model)
        {
            return base.TryUpdateModelAsync(model);
        }

        public override Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix)
        {
            return base.TryUpdateModelAsync(model, prefix);
        }

        public override Task<bool> TryUpdateModelAsync<TModel>(TModel model, string prefix, IValueProvider valueProvider)
        {
            return base.TryUpdateModelAsync(model, prefix, valueProvider);
        }

        new public virtual Task<bool> TryUpdateModelAsync(object model, Type modelType, string prefix)
        {
            return base.TryUpdateModelAsync(model, modelType, prefix);
        }

        new public virtual bool TryValidateModel(object model)
        {
            return base.TryValidateModel(model);
        }

        new public virtual bool TryValidateModel(object model, string prefix)
        {
            return base.TryValidateModel(model, prefix);
        }

        new public virtual UnauthorizedResult Unauthorized()
        {
            return base.Unauthorized();
        }

        new public virtual UnauthorizedObjectResult Unauthorized([ActionResultObjectValue] object value)
        {
            return base.Unauthorized(value);
        }

        new public virtual UnprocessableEntityResult UnprocessableEntity()
        {
            return base.UnprocessableEntity();
        }

        new public virtual UnprocessableEntityObjectResult UnprocessableEntity([ActionResultObjectValue] object error)
        {
            return base.UnprocessableEntity(error);
        }

        new public virtual UnprocessableEntityObjectResult UnprocessableEntity([ActionResultObjectValue] ModelStateDictionary modelState)
        {
            return base.UnprocessableEntity(modelState);
        }

        new public virtual ActionResult ValidationProblem([ActionResultObjectValue] ValidationProblemDetails descriptor)
        {
            return base.ValidationProblem(descriptor);
        }

        new public virtual ActionResult ValidationProblem([ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            return base.ValidationProblem(modelStateDictionary);
        }

        new public virtual ActionResult ValidationProblem()
        {
            return base.ValidationProblem();
        }

        new public virtual ActionResult ValidationProblem(string detail = null, string instance = null, int? statusCode = null, string title = null, string type = null, [ActionResultObjectValue] ModelStateDictionary modelStateDictionary = null)
        {
            return base.ValidationProblem(detail, instance, statusCode, title, type, modelStateDictionary);
        }
    }
}

namespace web_MYCV.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class Web_MyCVController : ControllerBase
    {

        private readonly ILogger<Web_MyCVController> _logger;

        public Web_MyCVController(ILogger<Web_MyCVController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Web_MyCV[] Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Web_MyCV
            {

                Date = DateTime.Now.AddDays(index),



            })
            .ToArray();
        }
    }
}


