using UnityEngine;

namespace Decorators
{
    public class IncreaseSizeDecorator : Decorator
    {
        public IncreaseSizeDecorator(IDecoratableComponent decoratableComponent) : base(decoratableComponent)
        {
        }

        public override void Activate(GameObject gameObject)
        {
            base.Activate(gameObject);

            Debug.Log($"Increasing size of {gameObject.name}");
            gameObject.transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
        }
    }
}