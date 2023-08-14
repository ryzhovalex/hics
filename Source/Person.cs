namespace Slimebones.Hics {
    public class Person {
        private string name;
        private int age;
        public event EventHandler AgeChanged;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public int Age {
            get {
                return age;
            }
            set {
                if (value < 0) {
                    throw new Exception(String.Format(
                        "cannot set negative age <{0}>",
                        value
                    ));
                }

                age = value;

                try {
                    AgeChanged(this, new EventArgs());
                } catch (NullReferenceException) {
                    return;
                }
            }
        }
    }
}
