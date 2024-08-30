using Mapster;

namespace royaltjänstflytt.Common.Mapping
{
    public class ProductMapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            //config.NewConfig<Matgare.product.Domain.ProductAggregate.ValueObject.Product, ProductDto>()
            //    .Map(des=>des.ProductId, src=>src.Id);
            //config.NewConfig<CreateProductCommand, ProductDto>();
            //config.NewConfig<CreateOrUpdataProductDto, CreateProductCommand>();
        }
    }
}
