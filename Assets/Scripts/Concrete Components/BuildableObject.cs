using UnityEngine;

namespace Concrete_Components
{
    public class BuildableObject : IDecoratableComponent
    {
        private string Name { get; }

        public BuildableObject(string name)
        {
            Name = name;
        }

        public void Activate(GameObject o)
        {
            Debug.Log($"hit {o.name} with a {Name}!");
        }
    }
}