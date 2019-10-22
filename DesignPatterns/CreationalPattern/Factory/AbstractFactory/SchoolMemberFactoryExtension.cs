using System;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Implementation;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Factory.AbstractFactory
{
    public static class SchoolMemberFactoryExtension
    {
        public static ISchoolMemberFactory GetSchoolMemberFactory(Language language, IServiceProvider serviceProvider)
        {
            switch (language)
            {
                case Language.Polish:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();

                case Language.English:
                    return serviceProvider.GetService<EnglishSchoolMemberFactory>();

                default:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();
            }
        }
    }
}
