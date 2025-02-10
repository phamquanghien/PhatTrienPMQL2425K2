Phát triển Phần mềm quản lý - Nhóm 01
1. Môi trường lập trình
   - C#, .Net, MVC
   - Visual Studio Code/Visual Studio (C# Dev Kit, C#, IntelliCode for C# Dev Kit...)
   - Git + Github (git add, git commit, git push, git pull, git branch...)
2. Nội dung học
   - Phát triển ứng dụng quản lý trên .net MVC
   - Tìm hiểu mô hình MVC, Cách thức hoạt động của Model, View, Controller
   - Nắm được cách gửi nhận dữ liệu giữa Model, View, Controller
   - Kế thừa... => Đủ điều kiện đạt
   - Làm việc với Excel, phân trang dữ liệu
   - Authentication và Authorization
   - HTML, CSS (W3.css/Bootstrap)
   - C# Code First, Entity Framework
3. Đánh giá kết quả học phần
   - Thi điểm A: Vấn đáp
   - Điểm B: Dựa vào điểm thi + Bài thực hành + Bài kiểm tra
   - Điểm C: Điểm danh + Làm bài thực hành
BÀI THỰC HÀNH SỐ 1: tạo dự án MVC đầu tiên và đẩy lên github
   - dotnet new mvc -o PROJECT_NAME
4. Ngày 13/01
   - Nộp bài thực hành HTML, CSS (Boostrap/W3.css), bao gồm các thư mục: HTML, CSS, DemoMVC
   - Tích hợp thư viện CSS và trong project DemoMVC: Views/Shared/_Layout.cshtml
   - Chạy project: dotnet watch run
   - Gặp lỗi: "Could not find a MSBuild project file in" => Bị nhầm thư mục gốc chứa project => cần cd tới thư mục chứa project
5. Ngày 10/02: Làm việc với Models, Views, Controllers
   - Tạo controller, Tạo Action (Chú ý namespace, ví dụ Project_Name.Folder_Name)
   - Gặp thông báo: "InvalidOperationException: The view 'Contact' was not found. The following locations were searched" => Cần tạo View tương ứng
   - Gửi dữ liệu từ View lên Controller => Sử dụng Form trên HTML, chú ý "name" của các thẻ input
   - Controller nhận dữ liệu từ View gửi lên: chú ý [HttpPost], Parameter
   - Gửi dữ liệu từ Controller về View và hiển thị trên view: Sử dụng ViewBag/ViewData/ViewTemplate