using System.Collections.Generic;
using Portal.Domain.Common;

namespace Portal.Domain.Entities
{
	public class PollAnswer : BaseEntity
	{
        public int PollId { get; set; }

        public virtual Poll Poll { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    
        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
    }
}