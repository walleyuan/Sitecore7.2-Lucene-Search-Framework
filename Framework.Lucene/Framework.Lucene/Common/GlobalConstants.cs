using Sitecore.ContentSearch;

namespace Framework.Lucene.Common
{
      public static class GlobalConstants
      {
            public static class Indexing
            {
                  /// <summary>
                  ///  Content Index contains all content pages for site search
                  /// </summary>
                  public static ISearchIndex CorporateContent
                  {
                        get { return ContentSearchManager.GetIndex("contents"); }
                  }
            }
      }
}
