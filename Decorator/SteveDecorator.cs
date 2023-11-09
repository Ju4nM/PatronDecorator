using PatronDecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.Decorator {
    public abstract class SteveDecorator: ISteve {
        protected ISteve steve;

        public SteveDecorator(ISteve steve) {
            this.steve = steve;
        }
        public abstract int TakeDamage(int damage);
    }
}
