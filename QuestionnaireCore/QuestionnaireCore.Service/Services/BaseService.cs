using AutoMapper;
using QuestionnaireCore.Data.Interfaces;
using QuestionnaireCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Services
{
    public class BaseService : IBaseService
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _uow;

        public BaseService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
