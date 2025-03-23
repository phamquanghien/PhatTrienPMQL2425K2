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
4. Buổi 2
   - Nộp bài thực hành HTML, CSS (Boostrap/W3.css), bao gồm các thư mục: HTML, CSS, DemoMVC
   - Tích hợp thư viện CSS và trong project DemoMVC: Views/Shared/_Layout.cshtml
   - Chạy project: dotnet watch run
   - Gặp lỗi: "Could not find a MSBuild project file in" => Bị nhầm thư mục gốc chứa project => cần cd tới thư mục chứa project
5. Buổi 3: Làm việc với Models, Views, Controllers
   - Tạo controller, Tạo Action (Chú ý namespace, ví dụ Project_Name.Folder_Name)
   - Gặp thông báo: "InvalidOperationException: The view 'Contact' was not found. The following locations were searched" => Cần tạo View tương ứng
   - Gửi dữ liệu từ View lên Controller => Sử dụng Form trên HTML, chú ý "name" của các thẻ input
   - Controller nhận dữ liệu từ View gửi lên: chú ý [HttpPost], Parameter
   - Gửi dữ liệu từ Controller về View và hiển thị trên view: Sử dụng ViewBag/ViewData/ViewTemplate
6. Buổi 4
   - Bài 1: Tính chỉ số BMI: Tạo Model (có các thuộc tính liên quan đến tính chỉ số BMI),  Tạo form gửi dữ liệu bao gồm các chỉ số từ View lên Controller,Nhận và tính toán dữ liệu gửi lên sau đó gửi thông báo về view (ViewBag)
   - Bài 2: Tính điểm môn học dựa trên điểm thành phần A, B, C
   - Bài 3: Tính tiền hoá đơn dựa trên số lượng và đơn giá
7. Buổi 5: Làm việc với cơ sở dữ liệu
   - Sử dụng SQL Server qua docker: tải và cài đặt docker (https://www.docker.com/products/docker-desktop/)
      + Tải image docker: docker pull mcr.microsoft.com/mssql/server:2019-latest 
      + Tạo container: docker run -d --name sql_server_container -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourStrong!Passw0rd' -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest
   - Làm việc với SQLite: cần tải Dbeaver (https://dbeaver.io/download/)
   - Cài đặt các package (tham khảo slide hoặc link: https://learn.microsoft.com/vi-vn/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-9.0&tabs=visual-studio-code)
   - Xây dựng chức năng CRUD dữ liệu (Tạo controller và view)
8. Buổi 6: Sinh mã tự động Controller và View dựa trên Model
   - Sinh mã nguồn tự động: dotnet aspnet-codegenerator controller -name PersonController -m Person -dc DemoMVC.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
   - Kế thừa: Giả sử class Employee (10 thuộc tính) kế thừa từ class Person (5 thuộc tính) => Employee : Person => Employee có 15 thuộc tính
   - Cơ chế validate dữ liệu với Model
9.  Buổi 7:
   - Chạy debug chương trình (Xem mã nguồn file Debug.txt).
   - Kế thừa trong C#
   - Nhập xuất dữ liệu Excel với thư viện EPPLUS
10. 