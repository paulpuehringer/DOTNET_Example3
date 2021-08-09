using System.Collections.Generic;
using DOTNET_Example.Models;

namespace DOTNET_Example
{
    public interface IDataAccessProvider
    {
        void AddPizza(Pizza pizza);  
        void UpdataPizza(Pizza pizza);  
        void DeletePizza(string id);  
        Pizza GetPizzaSingleRecord(string id);  
        List<Pizza> GetPizzaRecords();  
    }
}