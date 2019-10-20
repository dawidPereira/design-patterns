using System;
using DesignPatterns.Factory.AbstractFactory.Implementation;
using DesignPatterns.Factory.AbstractFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Factory.AbstractFactory
{
    public static class SchoolMemberFactoryExtension
    {
        public static ISchoolMemberFactory GetSchoolMemberFactory(SchoolMemberType schoolMemberType, IServiceProvider serviceProvider)
        {
            switch (schoolMemberType)
            {
                case SchoolMemberType.PolishStudent:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();

                case SchoolMemberType.EnglishStudent:
                    return serviceProvider.GetService<EnglishSchoolMemberFactory>();

                default:
                    return serviceProvider.GetService<PolishSchoolMemberFactory>();
            }
        }
    }
}
