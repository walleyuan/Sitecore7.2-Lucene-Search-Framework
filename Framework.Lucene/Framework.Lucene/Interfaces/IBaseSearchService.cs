using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Framework.Lucene.Model;
using Sitecore.ContentSearch;

namespace Framework.Lucene.Interfaces
{
    public interface IBaseSearchService<T> where T : class
    {
        ISearchIndex Index { get; }

        /// <summary>
        /// Get All Items In the Index File
        /// </summary>
        /// <returns></returns>
        SearchResponse<T> All();

        /// <summary>
        /// Get specified Items on specified page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        SearchResponse<T> All(int page, int perPage);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="propertyName"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        SearchResponse<T> All(SortOrder orderBy, string propertyName, int page, int perPage);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        SearchResponse<T> Search(Expression<Func<T, bool>> filter);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        SearchResponse<T> Search(Expression<Func<T, bool>> filter, int page, int perPage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="orderBy"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        SearchResponse<T> Search(Expression<Func<T, bool>> filter, int page, int perPage, SortOrder orderBy, string propertyName);

    }
}
