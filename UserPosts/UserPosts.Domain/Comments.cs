namespace UserPosts.Domain
{
    public class Comments:BaseEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; }
    }
}