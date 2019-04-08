using RealDigital.Domain.SeedWork;
using System;

namespace RealDigital.Domain.AggregateModels.ContactAggregate.Builders
{
    public class BuilderFactory<TSetBuilder, TBuild> where TSetBuilder : class, IBuilder where TBuild : class, IEntity
    {
        public static IContactBuilder<TSetBuilder, TBuild> Create()
        {
            return (IContactBuilder<TSetBuilder, TBuild>)Activator.CreateInstance(typeof(TSetBuilder));
        }
    }
}
