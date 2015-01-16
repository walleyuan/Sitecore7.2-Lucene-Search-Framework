using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Links;

namespace Framework.Lucene.ComputedFields.Contents
{
      public class ItemUrl : IComputedIndexField
      {
            public object ComputeFieldValue(IIndexable indexable)
            {
                  var indexItem = indexable as SitecoreIndexableItem;

                  if (indexItem == null)
                  {
                        return null;
                  }

                  return LinkManager.GetItemUrl(indexItem);
            }

            public string FieldName { get; set; }
            public string ReturnType { get; set; }
      }
}
