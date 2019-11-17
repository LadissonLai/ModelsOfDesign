using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_第六章_装饰模式
{
    class Decorator : Component
    {
        private Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if(component != null)
            {
                component.Show();
            }

        }
    }
}
