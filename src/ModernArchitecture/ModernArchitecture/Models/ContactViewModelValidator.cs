﻿
namespace ModernArchitecture.Models
{
	using System;

	using FluentValidation;

	public class ContactViewModelValidator : AbstractValidator<ContactViewModel>
	{
		public ContactViewModelValidator()
		{
			RuleFor(x => x.Name).NotNull();
			RuleFor(x => x.Email).NotNull().EmailAddress();
			RuleFor(x => x.DateOfBirth).NotNull().LessThanOrEqualTo(DateTime.Today);
			RuleFor(x => x.PhoneNumber).NotNull().Matches(@"\d{3}-\d{3}-\d{4}");
		}
	}
}