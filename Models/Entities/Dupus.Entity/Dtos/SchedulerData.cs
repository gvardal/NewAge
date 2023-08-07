namespace Models.Entities.Dupus.Entity.Dtos
{
    public class SchedulerData
    {
        public int id { get; set; }
        public string? subject { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
