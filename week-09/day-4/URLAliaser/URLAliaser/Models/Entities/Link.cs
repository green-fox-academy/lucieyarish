namespace URLAliaser.Models.Entities
{
    public class Link
    {
        public long Id { get; set; }
        public string LinkURL { get; set; }
        public string Alias { get; set; }
        public int SecretCode { get; set; }
    }
}