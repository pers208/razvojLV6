using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciZadatak
{
    class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();
        public Memento GetState(int index)
        {
            return this.mementos.ElementAt(index);
        }
        public void AddState(Memento memento)
        {
            this.mementos.Add(memento);
        }
        public Memento GetLastState()
        {
            return this.mementos.ElementAt(mementos.Count - 1);
        }
        public Memento GetFirstState()
        {
            return this.mementos.ElementAt(0);
        }
    }
}
