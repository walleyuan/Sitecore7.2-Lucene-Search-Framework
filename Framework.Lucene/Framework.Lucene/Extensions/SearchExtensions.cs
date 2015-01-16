using System.Collections.Generic;
using System.Linq;
using Sitecore.ContentSearch.Linq;

namespace Framework.Lucene.Extensions
{
    public static class SearchExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchResults"></param>
        /// <returns></returns>
        public static IList<T> GetDocuments<T>(this SearchResults<T> searchResults)
        {
            return searchResults.Hits.Select(h => h.Document).ToList();
        }
    }
}
