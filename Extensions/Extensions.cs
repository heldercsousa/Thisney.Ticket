using AgileObjects.AgileMapper;
using System.Collections.Generic;
using System.Linq;

namespace Thisney.Ticket.Mapping
{
    public static class Extensions
    {
        public static T Project<TS,T>(this TS source) where T: class where TS: class
        {
            if (source == null)
            {
                return null as T;
            }
            var rLst = new[] { source }.AsQueryable().Project().To<T>();
            return rLst.Single();
        }

        public static IEnumerable<T> Project<TS,T>(this IQueryable<TS> sourceList) where T : class where TS : class
        {
            if (sourceList == null)
            {
                return Enumerable.Empty<T>();
            }
            return sourceList.Project().To<T>();
        }
    }
}
