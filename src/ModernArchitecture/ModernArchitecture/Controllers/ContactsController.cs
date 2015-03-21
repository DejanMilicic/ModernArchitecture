
namespace ModernArchitecture.Controllers
{
	using System.Net;
	using System.Web.Mvc;

	using ModernArchitecture.Models;

	public class ContactsController : Controller
	{
		// GET: Contacts
		public ActionResult Index()
		{
			return View();
		}

		public ViewResult Add()
		{
			return View();
		}

		[HttpPost]
		public HttpStatusCodeResult Add(ContactViewModel model)
		{
			return new HttpStatusCodeResult(HttpStatusCode.OK);
		}
	}
}