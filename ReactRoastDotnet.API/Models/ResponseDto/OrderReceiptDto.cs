namespace ReactRoastDotnet.API.Models.ResponseDto;

public record OrderReceiptDto
{
    public int OrderNumber { get; init; }
    
    public required string Email { get; init; }
    
    public required List<CheckoutItem> Items { get; init; }

    public int TotalQuantity { get; init; }
    public decimal TotalPrice { get; init; }

    public DateTime OrderDate { get; init; } = DateTime.Now;
    public DateTime EstimateReadyTime { get; init; } = DateTime.Now.AddMinutes(10);
}