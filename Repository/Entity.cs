using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HomeBudgetTrackingSystem.Models
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long Id { get; set; }

        [Timestamp]
        public virtual byte[] Version { get; set; }

        public virtual DateTimeOffset CreatedAt { get; set; }

        public virtual DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(true)] //using System.ComponentModel;
        public virtual bool Active { get; set; }

        [DefaultValue(false)]
        public virtual bool Deleted { get; set; }

        public virtual string CreatedBy { get; set; }

        public virtual string UpdatedBy { get; set; }

        public string GetIdentitySequenceName()
        {
            var attributes = Attribute.GetCustomAttributes(GetType());
            var sequenceNameAttribute = attributes.OfType<SequenceNameAttribute>().FirstOrDefault();
            return sequenceNameAttribute.Name;
            //return sequenceNameAttribute != null ? sequenceNameAttribute.Name : HiLoSettings.DefaultSequence;
        }
    }
}
