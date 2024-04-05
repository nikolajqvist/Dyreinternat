namespace Dyreinternat.wwwroot.Models
{
    public abstract class Animal
    {
        private string _name;
        private int _eyeCount;
        private int _age;
        private bool _hasLegs;
        private string _description;

        public string Name { get => _name; set => _name = value; }
        public int EyeCount { get => _eyeCount; set => _eyeCount = value; }
        public int Age { get => _age; set => _age = value; }
        public bool HasLegs { get => _hasLegs; set => _hasLegs = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
