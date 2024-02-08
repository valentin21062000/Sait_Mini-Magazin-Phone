namespace Examen
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Phone>> GetPhones(string sTrem = "", int modelId = 0);
        Task<IEnumerable<Model>> Models();
    }
}