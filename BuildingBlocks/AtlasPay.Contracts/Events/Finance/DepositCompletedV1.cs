namespace AtlasPay.Contracts.Events.Finance;

public sealed record DepositCompletedV1(
    Guid EventId,
    Guid DepositId,
    Guid AccountId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);