using System;
using System.Linq;
using DJ.Corporate.Framework.Search.Lucene.Interfaces;
using DJ.Corporate.Framework.Search.Lucene.Model;
using DJ.Framework.Extension;
using Sitecore.ContentSearch.Linq;

namespace DJ.Corporate.Framework.Search.Lucene.Services
{
    public class BaseSearchService<T>: IBaseSearchService<T> where T: class 
    {
        public virtual Sitecore.ContentSearch.ISearchIndex Index { get; set; }

        public virtual SearchResponse<T> All()
        {
            using (var context = Index.CreateSearchContext())
            {
                var allResults = context.GetQueryable<T>().GetResults();

                var response = new SearchResponse<T>(allResults);

                return response;
            }
        }

        public virtual SearchResponse<T> All(int page, int perPage)
        {
            var skipNumber = page == 1 ? 0 : (perPage - 1) * perPage;

            var response = All();

            response.Results = response.Results.Skip(skipNumber).Take(perPage).ToList();

            return response;
        }

        public virtual SearchResponse<T> All(System.Data.SqlClient.SortOrder orderBy, string propertyName, int page, int perPage)
        {
            var skipNumber = page == 1 ? 0 : (perPage - 1) * perPage;

            var response = All();

            response.Results = response.Results.SortBy(orderBy, propertyName).Skip(skipNumber).Take(perPage).ToList();

            return response;
        }

        public virtual SearchResponse<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            using (var context = Index.CreateSearchContext())
            {
                var allResults = context.GetQueryable<T>().Where(filter).GetResults();

                var response = new SearchResponse<T>(allResults);

                return response;
            }
        }

        public virtual SearchResponse<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> filter, int page, int perPage)
        {
            var skipNumber = page == 1 ? 0 : (page - 1) * perPage;

            var response = Search(filter);

            response.Results = response.Results.Skip(skipNumber).Take(perPage).ToList();

            return response;
        }

        public virtual SearchResponse<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> filter, int page, int perPage, System.Data.SqlClient.SortOrder orderBy, string propertyName)
        {
            var skipNumber = page == 1 ? 0 : (page - 1) * perPage;

            var response = Search(filter);

            response.Results = response.Results.SortBy(orderBy, propertyName).Skip(skipNumber).Take(perPage).ToList();

            return response;
        }
    }
}
