using System;

namespace Concept.Property.Lesson2 {
    class Main {
        public void Run() {
            var h = new Human("NAME");
            Console.WriteLine($"{h.Name}");
        }
    }
    class Human {
        private string name;
        public string Name { get => name;
            private set => name = value; }
        public Human(string name) => Name = name;
    }
}
