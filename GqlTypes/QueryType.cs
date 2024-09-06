using AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using HotChocolate;
using HotChocolate.Data;

namespace AspNetCore.Identity.GqlTypes
{
    public class QueryType
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Cake>> AllCakesAsync([Service] ApplicationDbContext context)
        {
            return context.Cakes;
        }
    }
}
