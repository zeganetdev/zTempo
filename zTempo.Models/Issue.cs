namespace zTempo.Models
{
    public class Issue
    {
        public string Id { get; set; }
        public string ProjectId { get; set; }
        public string Key { get; set; }
        public Field Fields { get; set; }

        public override string ToString()
        {
            return $"{Fields.Summary}";
        }
    }
}