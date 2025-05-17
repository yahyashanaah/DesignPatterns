using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Products
{
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();

        public ICheckbox CreateCheckbox() => new DarkCheckbox();
    }
}
