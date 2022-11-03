using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers
{
    public class CalculatorController : Controller
    {
        public double Index(double a, double b, char c)
        {
            double result= a + b;
            switch (c)
            {
                case '-': result = a - b;
                    break;
                case '*': result = a * b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
