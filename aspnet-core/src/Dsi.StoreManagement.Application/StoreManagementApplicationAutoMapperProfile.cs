using AutoMapper;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Products;
using Dsi.StoreManagement.Units;

namespace Dsi.StoreManagement;

public class StoreManagementApplicationAutoMapperProfile : Profile
{
    public StoreManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<Document, DocumentDto>();
        CreateMap<CreateUpdateDocumentDto, Document>();
        CreateMap<Operation, OperationDto>();
        CreateMap<CreateUpdateOperationDto, Operation>();
        CreateMap<Marque, MarqueDto>();
        CreateMap<CreateUpdateMarqueDto, Marque>();
        CreateMap<Model, ModelDto>();
        CreateMap<CreateUpdateModelDto, Model>();
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();
        CreateMap<Unit, UnitDto>();
        CreateMap<CreateUpdateUnitDto, Unit>();
        CreateMap<Color, ColorDto>();
        CreateMap<CreateUpdateColorDto, Color>();
    }
}
