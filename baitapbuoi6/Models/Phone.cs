using System.ComponentModel.DataAnnotations;

namespace baitapbuoi6.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên máy không được để trống")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "Hãng sản xuất không được để trống")]
        public string Brand { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 0")]
        public int Stock { get; set; }
    }
}