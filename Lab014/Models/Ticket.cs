namespace Lab014.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int PassId { get; set; }
        public int TrainId { get; set; }
        public int Railcar { get; set; }
        public int Seat { get; set; }
        public string StartPlace { get; set; }
        public string FinalPlace { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
