
namespace AtlasPay.Contracts.Events.Finance.V1;

public sealed record TransferCompletedV1(
    Guid EventId,
    Guid TransferId,
    Guid FromAccountId,
    Guid ToAccountId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);
