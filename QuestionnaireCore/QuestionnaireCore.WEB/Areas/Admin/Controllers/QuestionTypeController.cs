using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireCore.WEB.Areas.Admin.Controllers
{
    public class QuestionTypeController : BaseController
    {
        public QuestionTypeController(IQuestionTypeService questionTypeService, IMapper mapper) : base(questionTypeService, mapper)
        {
        }

        public IActionResult Index(string quesry = null)
        {
            return View();
        }

        public async Task<JsonResukt> GetData()
        {
            var questionTypes = await _questionTypeService.GetAsync(new QueryRequest<PostSortType>
                Includes = new[]
                {
                    "QuestionTypes"
                },
                OrderQueries = new[]
                {
                    new QueryOrder<PostSortType>
                    {
                        Direction = SortDirectionType.Descending,
                        OrderType = PostSortType.Name
                    }
                });
            return Json(new { questionTypes.Data });
        }

        public JsonResult Create(string name)
        {
            var questionType = new QuestionTypeModel()
            {
                Name = name
            };
            _questionTypeService.AddQuestionType(questionType);
            return Json(new { data = "success" });
        }

        public JsonResult Delete(string id)
        {
            try
            {
                _questionTypeService.Delete(id);
            }
            catch (Exception)
            {
                return Json(new { data = "failed" });
            }
        }
    }
}
