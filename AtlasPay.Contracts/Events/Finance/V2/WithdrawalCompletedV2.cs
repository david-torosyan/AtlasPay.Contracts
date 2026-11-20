namespace AtlasPay.Contracts.Events.Finance.V2;

public sealed record WithdrawalCompletedV2(
    Guid EventId,
    Guid WithdrawalId,
    Guid AccountId,
    Guid CustomerId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);