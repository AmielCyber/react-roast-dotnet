using ReactRoastDotnet.Data.Entities;

namespace ReactRoastDotnet.API.Extensions;

// TODO: Add filter for product types when we add other types rather than "Drinks"
public static class ProductItemsExtension
{
    public static IQueryable<ProductItem> Sort(this IQueryable<ProductItem> query, string? sortBy)
    {
        if (string.IsNullOrEmpty(sortBy))
        {
            // Short circuit. User did requested sort.
            return query;
        }

        // TODO: Add sort by price for SQL Server or change price to Long, since SQLite does not support decimal OrderBy
        query = sortBy switch
        {
            "name" => query.OrderBy(p => p.Name),
            "popular" => query.OrderBy(p => p.Id),
            _ => query
        };

        return query;
    }

    public static IQueryable<ProductItem> SearchDrink(this IQueryable<ProductItem> query, string? drinkName)
    {
        if (string.IsNullOrEmpty(drinkName))
        {
            // Short circuit. User did requested to search drinks.
            return query;
        }

        var lowerCaseDrinkName = drinkName.Trim().ToLower();

        return query.Where(i => i.Name.ToLower().Contains(lowerCaseDrinkName));
    }
}