using Microsoft.AspNetCore.Mvc;
using baitapbuoi6.Models;

namespace baitapbuoi6.Controllers
{
    public class PhoneController : Controller
    {
        // Dữ liệu giả lập mặc định
        private static List<Phone> phones = new List<Phone>
        {
            new Phone { Id = 1, ModelName = "Galaxy S24 Ultra", Brand = "Samsung", Price = 1299, Stock = 15 },
            new Phone { Id = 2, ModelName = "Galaxy Z Fold5", Brand = "Samsung", Price = 1799, Stock = 8 },
            new Phone { Id = 3, ModelName = "Galaxy A55", Brand = "Samsung", Price = 450, Stock = 30 }
        };

        // 1. Danh sách (List)
        public IActionResult Index()
        {
            return View(phones);
        }

        // 2. Chi tiết (Detail)
        public IActionResult Detail(int id)
        {
            var phone = phones.FirstOrDefault(p => p.Id == id);
            if (phone == null) return NotFound();
            return View(phone);
        }

        // 3. Thêm mới (Create)
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            if (ModelState.IsValid)
            {
                phone.Id = phones.Any() ? phones.Max(p => p.Id) + 1 : 1;
                phones.Add(phone);
                TempData["Success"] = "Thêm điện thoại thành công!";
                return RedirectToAction("Index");
            }
            return View(phone);
        }

        // 4. Sửa (Edit)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var phone = phones.FirstOrDefault(p => p.Id == id);
            if (phone == null) return NotFound();
            return View(phone);
        }

        [HttpPost]
        public IActionResult Edit(Phone updatedPhone)
        {
            if (ModelState.IsValid)
            {
                var phone = phones.FirstOrDefault(p => p.Id == updatedPhone.Id);
                if (phone != null)
                {
                    phone.ModelName = updatedPhone.ModelName;
                    phone.Brand = updatedPhone.Brand;
                    phone.Price = updatedPhone.Price;
                    phone.Stock = updatedPhone.Stock;
                    TempData["Success"] = "Cập nhật thông tin thành công!";
                }
                return RedirectToAction("Index");
            }
            return View(updatedPhone);
        }

        // 5. Xóa (Delete)
        public IActionResult Delete(int id)
        {
            var phone = phones.FirstOrDefault(p => p.Id == id);
            if (phone != null)
            {
                phones.Remove(phone);
                TempData["Success"] = "Đã xóa điện thoại khỏi danh sách!";
            }
            return RedirectToAction("Index");
        }
    }
}