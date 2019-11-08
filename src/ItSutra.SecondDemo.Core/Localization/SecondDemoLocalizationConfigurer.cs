using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ItSutra.SecondDemo.Localization
{
    public static class SecondDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SecondDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SecondDemoLocalizationConfigurer).GetAssembly(),
                        "ItSutra.SecondDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
