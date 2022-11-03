using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers
{
    public class CalculatorController : Controller
    {
        public double Index(double a, double b)
        {
            return a+b;
        }
    }
}
