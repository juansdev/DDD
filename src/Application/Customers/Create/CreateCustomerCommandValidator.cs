﻿using FluentValidation;

namespace Application.Customers.Create;

public class CreateCustomerCommandValidator: AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);
        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(50)
            .WithName("Last Name");
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(255);
        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .MaximumLength(9)
            .WithName("Phone Number");
        RuleFor(x => x.Country)
            .NotEmpty()
            .MaximumLength(3);
        RuleFor(x => x.Line1)
            .NotEmpty()
            .MaximumLength(20)
            .WithName("Address Line 1");
        RuleFor(x => x.Line2)
            .NotEmpty()
            .MaximumLength(20)
            .WithName("Address Line 2");
        RuleFor(x => x.City)
            .NotEmpty()
            .MaximumLength(40);
        RuleFor(x => x.State)
            .NotEmpty()
            .MaximumLength(40);
        RuleFor(x => x.ZipCode)
            .NotEmpty()
            .MaximumLength(10)
            .WithName("Zip Code");
    }
}