
using System;
namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public string Title { get; set; }
    public string MessageBody { get; set; }
    public string Group {get; set;}
    public DateTime MessageDate {get; set;}
    public string UserName {get;set;}
    public virtual ApplicationUser User {get;set;}
  }
}