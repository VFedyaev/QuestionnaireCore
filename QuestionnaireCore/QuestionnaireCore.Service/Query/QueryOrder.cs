using QuestionnaireCore.Service.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Query
{
    public class QueryOrder<TOrderType>
    {
        public TOrderType OrderType { get; set; }
        public SortDirectionType Direction { get; set; }
        public int Order { get; set; }
    }
}
