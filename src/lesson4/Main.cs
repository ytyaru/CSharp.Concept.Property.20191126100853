using System;
using System.ComponentModel;

namespace Concept.Property.Lesson4 {
    class Main {
        public void Run() {
            var h = new Human("NAME");
            Console.WriteLine($"{h.Name}");
        }
    }
    public class Human : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaiseRenamed([System.Runtime.CompilerServices.CallerMemberName]string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string name;
        public string Name { get => name;
            set { name = value; RaiseRenamed(); }
        }
        public Human() { PropertyChanged += OnPropertyChanged; }
        public Human(string name) { PropertyChanged += OnPropertyChanged; Name = name; }
        ~Human() { PropertyChanged -= OnPropertyChanged; }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args) {
            Console.WriteLine($"値がセットされた！: {args}");
        }
    }
}
