using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Products
{
    public class DarkButton : IButton
    {
        public void Render() => Console.WriteLine("Dark Button");
    }
}
