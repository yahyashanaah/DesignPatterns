using DesignPatterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractProducts
{
    public class Application
    {
        private readonly IButton button;
        private readonly ICheckbox checkbox;

        public Application(IButton button,ICheckbox checkbox)
        {
            this.button = button;
            this.checkbox = checkbox;
        }

        public void Render()
        {
            button.Render();
            checkbox.Render();
        }
    }
}
