namespace AtlasPay.Contracts.Events.Identity.V1;

public sealed record IdentityUserRegisteredV1(
    Guid EventId,
    Guid UserId,
    Guid CustomerId,
    string Email,
    DateTime OccurredAt);