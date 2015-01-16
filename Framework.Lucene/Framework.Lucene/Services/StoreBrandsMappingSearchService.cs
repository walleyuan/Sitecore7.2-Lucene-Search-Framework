using DJ.Corporate.Framework.Search.Lucene.Common;
using DJ.Corporate.Framework.Search.Lucene.Interfaces;
using DJ.Corporate.Framework.Search.Lucene.Model;
using Sitecore.ContentSearch;

namespace DJ.Corporate.Framework.Search.Lucene.Services
{
    public class StoreBrandsMappingSearchService : BaseSearchService<StoreBrandsMappingIndexItem>, IStoreBrandsMappingSearchService
    {
        public override ISearchIndex Index { get { return GlobalConstants.Indexing.CategoryToBrand; } }
    }
}
