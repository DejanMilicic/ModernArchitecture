
namespace ModernArchitecture.Controllers
{
	using System.Net;
	using System.Web.Mvc;

	using MediatR;

	using ModernArchitecture.Models;
	using ModernArchitecture.ServiceBus.Contacts;

	public class ContactsController : Controller
	{
		private readonly IMediator mediator;

		public ContactsController(IMediator mediator)
		{
			this.mediator = mediator;
		}

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
			mediator.Send(new InsertContactRequest
			              {
				              Name = "John",
							  DateOfBirth = null,
							  Email = "john@doe.com",
							  PhoneNumber = "(401) 555-6666"
			              });

			return new HttpStatusCodeResult(HttpStatusCode.OK);
		}
	}
}