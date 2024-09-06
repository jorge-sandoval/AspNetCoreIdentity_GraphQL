using AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Identity.GqlTypes
{
    public class MutationType
    {
        public async Task<Cake> SaveCakeAsync(
            [Service] ApplicationDbContext context,
            Cake newCake
        )
        {
            context.Cakes.Add( newCake );
            await context.SaveChangesAsync();
            return newCake;
        }

        public async Task<Cake> UpdateCakeAsync(
            [Service] ApplicationDbContext context,
            Cake updateCake
        )
        {
            context.Cakes.Update(updateCake);
            await context.SaveChangesAsync();
            return updateCake;
        }

        public async Task<bool> DeleteCakeAsync(
            [Service] ApplicationDbContext context,
            int id
        )
        {
            var deleted = false;

            var cake = await context.Cakes.FirstOrDefaultAsync(c => c.Id == id);
            if (cake != null)
            {
                context.Cakes.Remove( cake );
                await context.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
