using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Common.Interfaces
{
    public interface IPlatformInitializer
    {
        void ConfigureServices(IServiceCollection services);
    }
}
