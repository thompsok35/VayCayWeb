namespace VayCayPlannerWeb.Data.Models
{
    public class Package : BaseEntity
    {
        //public int Id { get; set; }
        //public int TripId { get; set; }
        //public int BudgetId { get; set; }
        public string? PackageName { get; set; }
        public string? CompanyName { get; set; }
        public string? PackageLink { get; set; }
        public bool isAllinclusive { get; set; }
        public string? BookingNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Guests { get; set; }
        public decimal? PackageCost { get; set; }
        public DateTime? PackageDueDate { get; set; }
        public decimal? InsuranceCost { get; set; }
        public DateTime? InsuranceDueDate { get; set; }
        public decimal? ExtensionsCost { get; set; }
        public DateTime? ExtensionDueDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? PackageTypeId { get; set; }
    }
}
