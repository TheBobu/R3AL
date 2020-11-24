namespace R3AL.Dtos
{
    public class JobDto
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public int NumberOfGoals { get; set; }
        public int NumberOfQuizzes { get; set; }
        public int NumberOfProjects { get; set; }
        public string Requirements { get; set; }
        public int StatusProgress { get; set; }
        public int Milestones { get; set; }
        public string Status { get; set; }
    }
}