using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Products
{
    public class LightThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new LightButton();

        public ICheckbox CreateCheckbox() => new LightCheckbox();
    }
}
