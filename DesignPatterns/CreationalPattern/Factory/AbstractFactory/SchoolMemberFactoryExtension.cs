using System;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Implementation;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Factory.AbstractFactory
{
    public static class SchoolMemberFactoryExtension
    {
        public static ISchoolMemberFactory GetSchoolMemberFactory(SchoolMemberLanguage schoolMemberLanguage, IServiceProvider serviceProvider)
        {
            switch (schoolMemberLanguage)
            {
                case SchoolMemberLanguage.PolishStudent:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();

                case SchoolMemberLanguage.EnglishStudent:
                    return serviceProvider.GetService<EnglishSchoolMemberFactory>();

                default:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();
            }
        }
    }
}
