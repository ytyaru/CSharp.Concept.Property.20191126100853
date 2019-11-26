using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Concept.Property.Lesson3 {
    class Main {
        public void Run() {
            var h = new Human("NAME");
            Console.WriteLine($"{h.Name}");
            Write(h);
        }
        private void Write(Human h) {
            System.Xml.Serialization.XmlSerializer writer =   
                new System.Xml.Serialization.XmlSerializer(h.GetType());  
            using (System.IO.FileStream file = System.IO.File.Create("Human.xml")) {
                writer.Serialize(file, h);  
            }
        }
    }
    public class Human {
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public int Id { get; set; }

        public Human(){}
        public Human(string name) => Name = name;
    }
}
