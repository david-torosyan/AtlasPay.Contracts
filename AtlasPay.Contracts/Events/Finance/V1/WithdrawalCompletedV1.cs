
namespace AtlasPay.Contracts.Events.Finance.V1;

public sealed record WithdrawalCompletedV1(
    Guid EventId,
    Guid WithdrawalId,
    Guid AccountId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);
