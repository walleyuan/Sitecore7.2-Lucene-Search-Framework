using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;

namespace Framework.Lucene.Model
{
      /// <summary>
      /// ContentIndexItem for all content pages
      /// </summary>
      public class ContentIndexItem : SearchResultItem
      {
            [IndexField("title")]
            public string Title { get; set; }

            [IndexField("heading")]
            public string Heading { get; set; }

            [IndexField("summary")]
            public string Summary { get; set; }

            [IndexField("content")]
            public string ContentField { get; set; }

      }
}
