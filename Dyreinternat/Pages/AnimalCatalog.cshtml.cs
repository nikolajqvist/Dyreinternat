using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternat.Pages
{
    public class AnimalCatalogModel : PageModel
    {
        
            private List<Snake> _snakes;
            private List<Dog> _dogs;
            private List<Cat> _cats;

            public AnimalCatalogModel()
            {
                new List<Cat>();
                new List<Dog>();
                new List<Snake>();
            }
            public List<Snake> Snakes { get => _snakes; set => _snakes = value; }
            public List<Dog> Dogs { get => _dogs; set => _dogs = value; }
            public List<Cat> Cats { get => _cats; set => _cats = value; }
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
            #endregion
            public void OnGet()
        {
        }
    }
}
