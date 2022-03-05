using System;
using System.Threading.Tasks;
using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Units;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dsi.StoreManagement
{
    public class DsiStoreDataSeederContributor
      : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Marque, Guid> _marqueRepository;
        private readonly IRepository<Model, Guid> _modelRepository;
        private readonly IRepository<Category, Guid> _categoryRepository;
        private readonly IRepository<Unit, Guid> _unitRepository;
        private readonly IRepository<Color, Guid> _colorRepository;

        public DsiStoreDataSeederContributor(IRepository<Color, Guid> colorRepository, IRepository<Unit, Guid> unitRepository, IRepository<Marque, Guid> marqueRepository, IRepository<Model, Guid> modelRepository, IRepository<Category, Guid> categoryRepository)
        {
            _marqueRepository = marqueRepository;
            _modelRepository = modelRepository;
            _categoryRepository = categoryRepository;
            _unitRepository = unitRepository;
            _colorRepository = colorRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _marqueRepository.GetCountAsync() <= 0)
            {
                await _marqueRepository.InsertAsync(
                    new Marque
                    {
                        DisplayFr = "HP",
                        DisplayAr = "HP",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _marqueRepository.InsertAsync(
                    new Marque
                    {
                        DisplayFr = "ACER",
                        DisplayAr = "ACER",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _marqueRepository.InsertAsync(
                    new Marque
                    {
                        DisplayFr = "LENOVO",
                        DisplayAr = "LENOVO",
                        Description = "-",
                    },
                    autoSave: true
              );
            }
            if (await _colorRepository.GetCountAsync() <= 0)
            {
                await _colorRepository.InsertAsync(
                    new Color
                    {
                        DisplayFr = "Blanc",
                        DisplayAr = "Blanc",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _colorRepository.InsertAsync(
                    new Color
                    {
                        DisplayFr = "Black",
                        DisplayAr = "Black",
                        Description = "-",
                    },
                    autoSave: true
              );
            }
            if (await _unitRepository.GetCountAsync() <= 0)
            {
                await _unitRepository.InsertAsync(
                    new Unit
                    {
                        DisplayFr = "Piece",
                        DisplayAr = "Piece",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _unitRepository.InsertAsync(
                    new Unit
                    {
                        DisplayFr = "Ram",
                        DisplayAr = "Ram",
                        Description = "-",
                    },
                    autoSave: true
              );
            }
            if (await _modelRepository.GetCountAsync() <= 0)
            {
                await _modelRepository.InsertAsync(
                    new Model
                    {
                        DisplayFr = "MODEL_1",
                        DisplayAr = "MODEL_1",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _modelRepository.InsertAsync(
                    new Model
                    {
                        DisplayFr = "MODEL_2",
                        DisplayAr = "MODEL_2",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _modelRepository.InsertAsync(
                    new Model
                    {
                        DisplayFr = "MODEL_3",
                        DisplayAr = "MODEL_3",
                        Description = "-",
                    },
                    autoSave: true
              );
            }
            if (await _categoryRepository.GetCountAsync() <= 0)
            {
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        DisplayFr = "Ordinateur Portable",
                        DisplayAr = "Ordinateur Portable",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        DisplayFr = "Unite Centrale",
                        DisplayAr = "Unite Centrale",
                        Description = "-",
                    },
                    autoSave: true
              );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        DisplayFr = "Ecran",
                        DisplayAr = "Ecran",
                        Description = "-",
                    },
                    autoSave: true
              );
            }
        }
    }
}