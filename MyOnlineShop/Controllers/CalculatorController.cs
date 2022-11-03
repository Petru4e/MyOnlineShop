using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, char c)
        {
            if (c == '\0') c = '+';
            switch (c)
            {
                case '+':
                    return $"{a} + {b} = {a + b}";
                case '-':
                    return $"{a} - {b} = {a - b}";
                case '*':
                    return $"{a} * {b} = {a * b}";
                case '/':
                    return $"{a} / {b} = {a / b}";
                default: return "Не верный символ";
            }
        }
    }
}
