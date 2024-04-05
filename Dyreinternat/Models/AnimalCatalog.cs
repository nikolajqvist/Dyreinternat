namespace Dyreinternat.wwwroot.Models
{
    public class AnimalCatalog
    {
        private List<Snake> _snakes;
        private List<Dog> _dogs;
        private List<Cat> _cats;

        public AnimalCatalog()
        {
            new List<Cat>();
            new List<Dog>();
            new List<Snake>();
        }
        #region AddAnimalTolist
        public void AddSnake(Snake snake)
        {
            _snakes.Add(snake);
        }
        public void AddCat(Cat cat)
        {
            _cats.Add(cat);
        }
        public void AddDog(Dog dog)
        {
            _dogs.Add(dog);
        }
    }
}
