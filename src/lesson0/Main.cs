using System;

namespace Concept.Property.Lesson0 {
    class Main {
        public void Run() {
            var h = new Human("NAME");
            Console.WriteLine($"{h.Name}");
//            h.SetDefault();
//            Console.WriteLine($"{h.Name}");
        }
    }
    class Human {
        public string Name { get; }
//        public void SetDefault() => Name = "Default"; // error CS0200
        public Human(string name) => Name = name;
    }
}
