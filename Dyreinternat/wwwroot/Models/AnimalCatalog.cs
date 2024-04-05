namespace Dyreinternat.wwwroot.Models
{
    public class AnimalCatalog
    {
        private List<SnakeModel> _snakes;
        private List<DogModel> _dogs;
        private List<CatModel> _cats;

        public AnimalCatalog()
                new List<CatModel>();
                new List<DogModel>();
                new List<SnakeModel>();
            }
    #region AddAnimalTolist
    public void AddSnake(SnakeModel snake)
    {
        _snakes.Add(snake);
    }
    public void AddCat(CatModel cat)
    {
        _cats.Add(cat);
    }
    public void AddDog(DogModel dog)
    {
        _dogs.Add(dog);
    }
}
}
