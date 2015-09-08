﻿using ELib.BL.DtoEntities;
using ELib.BL.Services.Abstract;
using ELib.DAL.Infrastructure.Abstract;
using ELib.Domain.Entities;

namespace ELib.BL.Services.Concrete
{
    public class LanguageService : BaseService<Language, LanguageDto>, ILanguageService
    {
        public LanguageService(IUnitOfWorkFactory factory)
            : base(factory)
        {
        }
    }
}
