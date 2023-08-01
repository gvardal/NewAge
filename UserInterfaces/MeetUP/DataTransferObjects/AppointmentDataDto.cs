namespace MeetUP.DataTransferObjects
{
    public class AppointmentDataDto
    {
        public int Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; } = false;
        public string RecurrenceRule { get; set; } = string.Empty;
        public int? RecurrenceID { get; set; }
        public string RecurrenceException { get; set; } = string.Empty;
        public string AppointmentStatus { get; set; }
        public string CssClass { get; set;} = string.Empty;
    }
}
