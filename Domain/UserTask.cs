namespace ConsoleApp.Domain
{
    public class UserTask
    {

        public int? ExternalUserId { get; set; }
        public int? ExternalTaskId { get; set; }

        public User User { get; set; }
        public Task Task { get; set; }
    }
}
