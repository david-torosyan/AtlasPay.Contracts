
namespace AtlasPay.Contracts.Events.Finance;

public sealed record TransferCompletedV1(
    Guid EventId,
    Guid TransferId,
    Guid FromAccountId,
    Guid ToAccountId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);
