using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller  //controller sınıfındaki tüm herşey artık employeeCotnrollerde de kullanıalbilir.
    {
        public IActionResult Index1(){
            string message = $"rumeysa is writing, {DateTime.Now.ToString()}";
            return View("Index1",message);  // 2 parametre bekler ilk olan view, ikinci olan da içerik
        }

        public ViewResult Index2(){
            var arr = new String[]{
                "test-1",
                "test-2",
                "test-3"
            };
            return View(arr);
        }

        public IActionResult Index3(){
            var list = new List<Employee>(){ // bu bir class olduğu için örnek bekliyor
                new Employee(){Id=1,FirstName="Rumeysa", LastName="yuk", Age=24},
                new Employee(){Id=2,FirstName="ADs", LastName="test", Age=23},
                new Employee(){Id=3,FirstName="test", LastName="test-asd", Age=20},
            };
            return View("Index3",list);
        }
    }
}