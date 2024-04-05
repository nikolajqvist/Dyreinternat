using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternat.Pages
{
    public class AnimalOwnerModel : PageModel
    {
        private string _ownerName;
        private int _age;
        private int _id;
        private bool _newOwner;

        public AnimalOwnerModel(string ownerName, int age, int id)
        {
            _ownerName = OwnerName;
            _age = Age;
            _id = Id;
            _newOwner = NewOwner;
        }

        public string OwnerName { get => _ownerName; set => _ownerName = value; }
        public int Age { get => _age; set => _age = value; }
        public int Id { get => _id; set => _id = value; }
        public bool NewOwner { get => _newOwner; set => _newOwner = value; }
        public void OnGet()
        {
        }
    }
}
