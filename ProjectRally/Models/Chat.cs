namespace Rally.Models;
public class Chat
{
    public int Id { get; set; }
    public string Message { get; set; }
    public Member Member { get; set; }
}
