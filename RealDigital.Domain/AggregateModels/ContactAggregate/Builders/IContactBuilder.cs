using RealDigital.Domain.SeedWork;

namespace RealDigital.Domain.AggregateModels.ContactAggregate.Builders
{
    public interface IContactBuilder<TSetBuilder, TBuild> : IBuilder
    {
        TSetBuilder Set();
        TBuild Build();
    }
}
