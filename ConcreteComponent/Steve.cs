using PatronDecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.ConcreteComponent {
    public class Steve: ISteve {
        private int _health = 20;
        public int TakeDamage(int damage) {
            return _health - damage < 0 ? 0 : _health - damage;
        }
       
    }
}
