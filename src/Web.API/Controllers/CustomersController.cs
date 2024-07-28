using Application.Customers.Create;
using Application.Customers.Delete;
using Application.Customers.GetAll;
using Application.Customers.GetById;
using Application.Customers.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[Route("customers")]
public class CustomersController: ApiController
{
    private readonly ISender _mediator;
    public CustomersController(ISender mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
    {
        var createCustomerResult = await _mediator.Send(command);
        return createCustomerResult.Match<IActionResult>(
            customer => Ok(),
            errors => Problem(createCustomerResult.Errors)
        );
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCustomerCommand command)
    {
        var deleteCustomerResult = await _mediator.Send(command);
        return deleteCustomerResult.Match<IActionResult>(
            customer => Ok(),
            errors => Problem(deleteCustomerResult.Errors)
        );
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCustomerCommand command)
    {
        var updateCustomerResult = await _mediator.Send(command);
        return updateCustomerResult.Match<IActionResult>(
            customer => Ok(),
            errors => Problem(updateCustomerResult.Errors)
        );
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var getAllCustomerResult = await _mediator.Send(new GetAllCustomersQuery { });
        return getAllCustomerResult.Match(
            customer => Ok(getAllCustomerResult.Value),
            errors => Problem(getAllCustomerResult.Errors)
        );
    }

    [Route("getById")]
    [HttpGet]
    public async Task<IActionResult> GetById(GetCustomerByIdQuery query)
    {
        var getByIdCustomerResult = await _mediator.Send(query);
        return getByIdCustomerResult.Match<IActionResult>(
            customer => Ok(getByIdCustomerResult.Value),
            errors => Problem(getByIdCustomerResult.Errors)
        );
    }
}