
namespace ModernArchitecture.ServiceBus.Contacts
{
	using System;

	using MediatR;

	public class InsertContact : RequestHandler<InsertContactRequest>
	{
		protected override void HandleCore(InsertContactRequest message)
		{
			// implement contact insert logic
		}
	}

	public class InsertContactRequest : IRequest
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public string PhoneNumber { get; set; }
	}
}