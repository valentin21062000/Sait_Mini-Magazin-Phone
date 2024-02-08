namespace Examen.Models.DTOs
{
    public class PhoneDisplayModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<Model> Models { get; set; }
        public string STerm { get; set; } = "";
        public int ModelId { get; set; } = 0;
    }
}
