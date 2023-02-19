namespace DP.Logic.ChainOfResponsability
{
    public class Document
    {
        public string Title { get; set; }
        public DateTimeOffset LastModifier { get; set; }
        public bool  ApprovedByLitigation { get; set; }
        public bool ApprovedByManagement { get; set; }

        public Document(string title, DateTimeOffset lastModifier, bool approvedByLitigation, bool approvedByManagement)
        {
            Title = title;
            LastModifier = lastModifier;
            ApprovedByLitigation = approvedByLitigation;
            ApprovedByManagement = approvedByManagement;
        }

    }
}
