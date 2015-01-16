using System.Collections.Generic;
using Framework.Lucene.Extensions;
using Sitecore.ContentSearch.Linq;

namespace Framework.Lucene.Model
{
      public class SearchResponse<T>
      {
            /// <summary>
            /// 
            /// </summary>
            public int TotalResults { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public IList<T> Results { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public FacetResults Facets { get; set; }

            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="results"></param>
            public SearchResponse(SearchResults<T> results)
            {
                  TotalResults = results.TotalSearchResults;
                  Results = results.GetDocuments();
                  Facets = results.Facets;
            }
      }
}
