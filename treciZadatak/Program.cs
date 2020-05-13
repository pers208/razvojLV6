using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItem kitchenDuties= new ToDoItem("Kitchen","Wash the dishes",DateTime.Now);
            ToDoItem homeDuties = new ToDoItem("home","sleep",DateTime.Now);
            ToDoItem schoolDuties = new ToDoItem("school", "study", DateTime.Now);

            Memento kitchenMemento=kitchenDuties.StoreState();
            Memento homeMemento = homeDuties.StoreState();
            Memento schoolMemento = schoolDuties.StoreState();

            CareTaker careTaker = new CareTaker();
            careTaker.AddState(kitchenMemento);
            careTaker.AddState(homeMemento);
            careTaker.AddState(schoolMemento);

            Console.WriteLine("before storing:");
            Console.WriteLine(kitchenDuties);
            Console.WriteLine(schoolDuties);
            Console.WriteLine(homeDuties+"\n");

            Console.WriteLine("After restoring:");
            homeDuties.RestoreState(careTaker.GetFirstState());
            schoolDuties.RestoreState(careTaker.GetState(1));
            kitchenDuties.RestoreState(careTaker.GetLastState());
            Console.WriteLine();

            Console.WriteLine(kitchenDuties);
            Console.WriteLine(schoolDuties);
            Console.WriteLine(homeDuties + "\n");
        }
    }
}
