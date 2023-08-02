namespace MeetUP.DataTransferObjects
{
    public class AppointmentDataDto
    {
        public Guid Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; } = false;
        public string RecurrenceRule { get; set; } = string.Empty;
        public int? RecurrenceID { get; set; }
        public string RecurrenceException { get; set; } = string.Empty;
        public string AppointmentStatus { get; set; } = string.Empty;
        public string CssClass { get; set;} = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public int OwnerId { get; set; }
    }
}
