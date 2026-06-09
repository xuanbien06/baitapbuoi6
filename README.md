# Dự án: Quản lý điện thoại (Phone Management) - Bài Tập Tổng Hợp

## 1. Mô tả chủ đề đã chọn
Dự án này chọn chủ đề **Quản lý danh mục điện thoại** (Phone Management System). Đây là một ứng dụng Web mini được xây dựng dựa trên kiến trúc **ASP.NET Core MVC** nhằm mục đích mô phỏng hệ thống quản lý sản phẩm cho một đại lý hoặc cửa hàng kinh doanh thiết bị di động. 

Để giao diện và dữ liệu mang tính thực tế, hệ thống sử dụng kho dữ liệu giả lập ban đầu (tải sẵn trong danh sách `static List`) tập trung vào các dòng điện thoại thông minh tiêu biểu của thương hiệu **Samsung** (bao gồm các phân khúc cao cấp như Galaxy S24 Ultra, Galaxy Z Fold5 và phân khúc cận cao cấp như Galaxy A55).

## 2. Các chức năng cốt lõi (CRUD)
Hệ thống hoàn thành trọn vẹn mạch xử lý dữ liệu khép kín bao gồm:
* **Danh sách sản phẩm (Index):** Hiển thị trực quan toàn bộ các mẫu điện thoại dưới dạng bảng kèm theo thông số chi tiết (ID, Tên máy, Hãng sản xuất, Giá bán, Số lượng tồn kho).
* **Xem chi tiết (Detail):** Cho phép người dùng truy cập sâu để xem thông tin toàn diện của từng thiết bị cụ thể thông qua Route ID `/Phone/Detail/{id}`.
* **Thêm mới (Create):** Cung cấp giao diện biểu mẫu (Form) để nhập và lưu trữ các mẫu điện thoại mới vào bộ nhớ hệ thống.
* **Chỉnh sửa thông tin (Edit):** Cho phép người quản trị cập nhật linh hoạt các thông số như tên, giá bán hoặc số lượng máy khi có biến động kho.
* **Xóa sản phẩm (Delete):** Loại bỏ hoàn toàn một bản ghi thiết bị khỏi danh sách quản lý hiện hành.

## 3. Các tính năng mở rộng và kỹ thuật áp dụng
Để tối ưu hóa trải nghiệm người dùng và đạt tiêu chuẩn đánh giá cao, dự án tích hợp thêm các kỹ thuật:
1. **Kiểm tra dữ liệu nghiêm ngặt (Validation):** Sử dụng *Data Annotation* ở tầng Model (`[Required]`, `[Range]`) kết hợp *ModelState* ở Controller để ngăn chặn các hành vi nhập rác (bỏ trống tên sản phẩm, nhập giá tiền bé hơn hoặc bằng 0, hoặc nhập số lượng tồn kho âm).
2. **Xác nhận trước khi xóa (Delete Confirmation):** Sử dụng mã JavaScript tương tác (`onclick="return confirm(...)"`) tại giao diện danh sách để cảnh báo và yêu cầu xác nhận từ người dùng, ngăn ngừa rủi ro mất mát dữ liệu do vô tình bấm nhầm nút Xóa.
3. **Thông báo trạng thái trực quan (Success Alerts):** Sử dụng bộ lưu trữ tạm thời `TempData` phối hợp với các cấu phần thông báo (Alerts) của framework Bootstrap để bung ra các dải banner màu xanh thông báo "Thành công" ngay khi các thao tác Thêm, Sửa, Xóa được hệ thống xử lý hoàn tất.
