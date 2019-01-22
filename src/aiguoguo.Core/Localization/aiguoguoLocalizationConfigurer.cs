using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace aiguoguo.Localization
{
    public static class aiguoguoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(aiguoguoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(aiguoguoLocalizationConfigurer).GetAssembly(),
                        "aiguoguo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
