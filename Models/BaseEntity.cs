namespace WebApplicationPronia.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
