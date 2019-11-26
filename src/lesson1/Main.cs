using System;

namespace Concept.Property.Lesson1 {
    class Main {
        public void Run() {
            var h = new Human("NAME");
            Console.WriteLine($"{h.Name}");
            h.SetDefault();
            Console.WriteLine($"{h.Name}");
        }
    }
    class Human {
        public string Name { get; private set; }
        public void SetDefault() => Name = "Default";
        public Human(string name) => Name = name;
    }
}
