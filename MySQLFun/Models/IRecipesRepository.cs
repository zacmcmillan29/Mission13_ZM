using System;
using System.Linq;

namespace MySQLFun.Models
{
    public interface IRecipesRepository
    {
        IQueryable <Recipe> Recipes { get;}
    }
}
