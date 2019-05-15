using Microsoft.AspNetCore.Mvc;
using QuestionnaireCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireCore.WEB.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        protected readonly IQuestionTypeService _questionTypeService;
        protected readonly IMapper _mapper;
    }
}
