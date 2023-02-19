using System.ComponentModel.DataAnnotations;

namespace DP.Logic.ChainOfResponsability
{
    public class DocumentLastModifiedHandler : IHandler<Document>
    {
        private IHandler<Document>? _handler;
        public void Handle(Document document)
        {
           if(document.LastModifier < DateTime.UtcNow.AddDays(-30))
            {
                throw new ValidationException(
                     new ValidationResult("Document must be modified in the last 30 days", new List<string> { "Last modified"}), null, null);          
            }
           
           _handler?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _handler = successor;
            return _handler;
        }
    }
}
