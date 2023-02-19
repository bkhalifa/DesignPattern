using System.ComponentModel.DataAnnotations;

namespace DP.Logic.ChainOfResponsability
{
    public class DocumentApprovedByLitigationHandler : Handler<Document>
    {
        public override void Handle(Document request)
        {
            if (!request.ApprovedByLitigation)
            {
                throw new ValidationException(new ValidationResult("Document must be approved by litigation", new List<string> { "Must Approved by litigation" }),
                    null, null);
            }
            base.Handle(request);
        }
    }
}
