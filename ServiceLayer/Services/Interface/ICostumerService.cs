using DomainLayer.Models;


namespace ServiceLayer.Services.Interface
{
    public interface ICostumerService
    {
        int GetCostumerCountByFiltered();
        Costumer[] GetCostumerByFiltered(int starAge,int endAge);
        double GetCostumersAverageByAges();
    }
}
