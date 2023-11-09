using PatronDecorator.Component;
using PatronDecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.ConcreteDecorator {
    public class ChestplateDecorator: SteveDecorator {
        public ChestplateDecorator(ISteve steve) : base(steve) { }
        public override int TakeDamage(int damage) {
            int newDamage = damage - Convert.ToInt32(damage * 0.32);
            return steve.TakeDamage(newDamage);
        }
    }
}
