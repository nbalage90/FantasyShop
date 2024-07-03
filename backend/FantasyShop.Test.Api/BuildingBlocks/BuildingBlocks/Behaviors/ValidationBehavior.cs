using BuildingBlocks.CQRS;
using FluentValidation;
using MediatR;

namespace BuildingBlocks.Behaviors;

public sealed class ValidationBehavior<TRequest, TResponse>(IEnumerable<IValidator<TResponse>> validators) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class, ICommand<TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!validators.Any())
            return await next();

        var validationContext = new ValidationContext<TRequest>(request);

        var errorsDictionary = validators
            .Select(v => v.Validate(validationContext))
            .SelectMany(v => v.Errors);

        if (errorsDictionary != null)
            throw new ValidationException(errorsDictionary);

        return await next();
    }
}
