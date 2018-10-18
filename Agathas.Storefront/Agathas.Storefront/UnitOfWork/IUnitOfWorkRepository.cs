using Agathas.Storefront.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agathas.Storefront.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        void PersistCreationOf(IAggregateRoot entity);
        void PersistUpdateOf(IAggregateRoot entity);
        void PersistDeletionOf(IAggregateRoot entity);
    }
}
