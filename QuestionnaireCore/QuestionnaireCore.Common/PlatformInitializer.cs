using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestionnaireCore.Common.Interfaces;
using QuestionnaireCore.Data;
using QuestionnaireCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Common
{
    public class PlatformInitializer : IPlatformInitializer
    {
        protected IConfiguration _configuration;

        public PlatformInitializer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // configure database
            ConfigureDatabase(services);

            // add singletone instances
            services.AddSingleton(Mapping.Configuration.CreateDefaultMapper());

            // add scoped registrations
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IChannelService, ChannelService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }

        protected virtual void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<DbContext, QuestionnaireCoreContext>(options =>
               options.UseSqlServer(
                   _configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
