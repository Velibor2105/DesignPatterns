using Agathas.Storefront.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agathas.Storefront.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterRemoved(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void Commit();
    }
}
