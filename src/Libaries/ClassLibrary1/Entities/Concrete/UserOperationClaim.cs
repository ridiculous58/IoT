using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual int OperationClaimId { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
        public virtual User User { get; set; }
    }
}
