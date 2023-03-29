using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TriangleAPI.Controllers
{
    public class TriangleController : ControllerBase
    {
        [HttpGet("zavd1")]
        public ActionResult CalculateTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return Ok(area);
        }
        
        
        [HttpGet("zavd2")]
        public ActionResult Get(double a, int n)
        {
            double sum = 0;
            double term = 2 / a;

            for (int i = 1; i <= n; i++)
            {
                sum += term;
                term *= (a + i) / (i + 1);
            }

            return Ok(sum);
        }
    }
}
