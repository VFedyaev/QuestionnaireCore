using AutoMapper;
using QuestionnaireCore.Data.Entities;
using QuestionnaireCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Common.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<QuestionType, QuestionTypeModel>(MemberList.None).ReverseMap();
            CreateMap<Question, QuestionModel>(MemberList.None).ReverseMap();
            CreateMap<Answer, AnswerModel>(MemberList.None).ReverseMap();
            CreateMap<QuestionAnswer, QuestionAnswerModel>(MemberList.None).ReverseMap();
            CreateMap<SurveyGeography, SurveyGeographyModel>(MemberList.None).ReverseMap();
            CreateMap<HousingType, HousingTypeModel>(MemberList.None).ReverseMap();
            CreateMap<District, DistrictModel>(MemberList.None).ReverseMap();
            CreateMap<Interviewer, InterviewerModel>(MemberList.None).ReverseMap();
            CreateMap<Form, FormModel>(MemberList.None).ReverseMap();
            CreateMap<Family, FamilyModel>(MemberList.None).ReverseMap();
            CreateMap<QuestionnaireCore.Data.Entities.Data, DataModel>(MemberList.None).ReverseMap();
        }
    }
}
