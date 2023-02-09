using Core.Entities;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
//  Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice,
//  Description alanlarını ekleyiniz. (Brand = Marka)