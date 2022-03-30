using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options) :base(options)
    {

    }
    protected override async void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Message>()
      .HasData(
        new Message{MessageId = 1, Title ="Test 1", MessageBody="This is a test", Group="Recipes",MessageDate = new DateTime(2000, 11, 17), UserName = "user2@test.com"},
        new Message{MessageId = 2, Title ="Test 2", MessageBody="This is another test", Group="Giveaways",MessageDate = new DateTime(2002, 12, 24), UserName = "user@test.com"},
        new Message{MessageId = 3, Title ="Test 3", MessageBody="This is another another test", Group="Random",MessageDate = new DateTime(2003, 12, 25), UserName = "user2@test.com"},
        new Message{MessageId = 4, Title ="Test 4", MessageBody="This is a title", Group="Recipes",MessageDate = new DateTime(2004, 11, 17), UserName = "user2@test.com"},
        new Message{MessageId = 5, Title ="Test 5", MessageBody="This is another title", Group="Giveaways",MessageDate = new DateTime(2005, 12, 24), UserName = "user@test.com"},
        new Message{MessageId = 6, Title ="Test 6", MessageBody="This is another another title", Group="Random",MessageDate = new DateTime(2006, 12, 25), UserName = "user2@test.com"},
        new Message{MessageId = 7, Title ="Test 1", MessageBody="This is a test", Group="Recipes",MessageDate = new DateTime(2000, 11, 17), UserName = "user2@test.com"},
        new Message{MessageId = 8, Title ="Test 2", MessageBody="This is another test", Group="Giveaways",MessageDate = new DateTime(2002, 12, 24), UserName = "user@test.com"},
        new Message{MessageId = 9, Title ="Test 3", MessageBody="This is another another test", Group="Random",MessageDate = new DateTime(2003, 12, 25), UserName = "user2@test.com"},
        new Message{MessageId = 10, Title ="Test 4", MessageBody="This is a title", Group="Recipes",MessageDate = new DateTime(2004, 11, 17), UserName = "user2@test.com"},
        new Message{MessageId = 11, Title ="Test 5", MessageBody="This is another title", Group="Giveaways",MessageDate = new DateTime(2005, 12, 24), UserName = "user@test.com"},
        new Message{MessageId = 12, Title ="Test 6", MessageBody="This is another another title", Group="Random",MessageDate = new DateTime(2006, 12, 25), UserName = "user2@test.com"}
      );
    }
    public DbSet<Message> Messages { get; set; }
  }
}