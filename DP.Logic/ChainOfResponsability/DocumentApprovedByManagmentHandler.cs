using System.ComponentModel.DataAnnotations;

namespace DP.Logic.ChainOfResponsability
{
    public class DocumentApprovedByManagmentHandler : IHandler<Document>
    {
        private IHandler<Document>? _handler;
        public void Handle(Document request)
        {
            if (!request.ApprovedByManagement)
            {
                throw new ValidationException(new ValidationResult("Document must by approved by management", new List<string> { "ApprovedByManagement" }), null, null);
            }
            _handler?.Handle(request);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _handler = successor;
            return _handler;
        }
    }
}
