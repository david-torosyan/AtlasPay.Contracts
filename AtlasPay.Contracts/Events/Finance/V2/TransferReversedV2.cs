namespace AtlasPay.Contracts.Events.Finance.V2;

public sealed record TransferReversedV2(
    Guid EventId,
    Guid ReversalId,
    Guid OriginalTransferId,
    Guid FromAccountId,
    Guid FromCustomerId,
    Guid ToAccountId,
    Guid ToCustomerId,
    decimal Amount,
    string Currency,
    DateTime OccurredAt);