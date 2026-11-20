namespace AtlasPay.Contracts.Events.Finance.V2;

public sealed record DepositCompletedV2(
    Guid EventId,
    Guid DepositId,
    Guid AccountId,
    Guid CustomerId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);