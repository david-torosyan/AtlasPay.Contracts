namespace AtlasPay.Contracts.Events.Finance.V2;

public sealed record TransferCompletedV2(
    Guid EventId,
    Guid TransferId,
    Guid FromAccountId,
    Guid FromCustomerId,
    Guid ToAccountId,
    Guid ToCustomerId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);