using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpDz.Models
{
    public class AbpDzMessagingInfo : CreationAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public AbpDzMessagingInfo() { }
        public AbpDzMessagingInfo(bool createKey = true)
        {
            if (createKey)
            {
                this.Id = Guid.NewGuid();
            }
        }
        public AbpDzMessagingInfo(Guid id)
        {

            this.Id = id;

        }
        public virtual Guid? TenantId { get; protected set; }

        /// <summary>
        /// Application code for the Messaging.
        /// </summary>
        public int Code { get; set; }
        public virtual Guid? SenderId
        {
            get;
            set;
        }

        public virtual Guid? RecipientId
        {
            get;
            set;
        }
        public virtual Guid? RecipientRoleId
        {
            get;
            set;
        }
        public DateTime? ExpireAt { get; set; }

        [StringLength(AbpDzConsts.MaxNotificationNameLength)]
        public virtual string DetailUrl
        {
            get;
            set;
        }
        public byte? DetailUrlType { get; set; }
        [StringLength(AbpDzConsts.MaxNotificationNameLength)]
        public virtual string RecipientPermission
        {
            get;
            set;
        }

        /// <summary>
        /// Unique Messaging name.
        /// </summary>
        [Required]
        [StringLength(AbpDzConsts.MaxNotificationNameLength)]
        public virtual string MessagingName { get; set; }

        /// <summary>
        /// Messaging data as JSON string.
        /// </summary>
        [StringLength(AbpDzConsts.MaxDataLength)]
        public virtual string Data { get; set; }

        /// <summary>
        /// Messaging content string.
        /// </summary>
        [StringLength(AbpDzConsts.MaxDataLength)]
        public virtual string Content { get; set; }

        /// <summary>
        /// Type of the JSON serialized <see cref="Data"/>.
        /// It's AssemblyQualifiedName of the type.
        /// </summary>
        [StringLength(AbpDzConsts.MaxDataTypeNameLength)]
        public virtual string DataTypeName { get; set; }

        /// <summary>
        /// Gets/sets entity type name, if this is an entity level Messaging.
        /// It's FullName of the entity type.
        /// </summary>
        [StringLength(AbpDzConsts.MaxEntityTypeNameLength)]
        public virtual string EntityTypeName { get; set; }

        /// <summary>
        /// AssemblyQualifiedName of the entity type.
        /// </summary>
        [StringLength(AbpDzConsts.MaxEntityTypeAssemblyQualifiedNameLength)]
        public virtual string EntityTypeAssemblyQualifiedName { get; set; }

        /// <summary>
        /// Gets/sets primary key of the entity, if this is an entity level Messaging.
        /// </summary>
        [StringLength(AbpDzConsts.MaxEntityIdLength)]
        public virtual string EntityId { get; set; }


        /// <summary>
        /// Gets/sets primary key of the entity, if this is an entity level Messaging.
        /// </summary>
        [StringLength(AbpDzConsts.MaxEntityIdLength)]
        public virtual string ExternalId { get; set; }

        /// <summary>
        /// Messaging severity.
        /// </summary>
        public virtual AbpDzSeverity Severity { get; set; }

        /// <summary>
        /// Messaging state.
        /// </summary>
        public virtual AbpDzMessageState State { get; set; }


    }
}

