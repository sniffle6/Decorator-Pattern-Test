using Monobehaviour;
using UnityEngine;

namespace Decorators
{
    public class AddForceDecorator : Decorator
    {
        public AddForceDecorator(IDecoratableComponent decoratableComponent) : base(decoratableComponent)
        {
        }

        public override void Activate(GameObject gameObject)
        {
            base.Activate(gameObject);
            Debug.Log($"Adding force to {gameObject.name}");
            var rb = gameObject.GetComponent<Rigidbody>();
            if (rb)
                rb.AddForce(Vector3.up * 100);
        }
    }
}