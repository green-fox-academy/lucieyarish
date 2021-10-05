namespace AnimalsInTheZoo
{
    public abstract class Animal
    { 
        private string name;
        private int age;
        private string gender;

        public virtual void Greet()
        {
            
        }

        public abstract void WantChild();

        public virtual void Eat()
        {
            
        }

        public virtual void Drink()
        {
            
        }
    }
}