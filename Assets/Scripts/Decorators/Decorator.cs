using UnityEngine;

namespace Decorators
{
    public abstract class Decorator : IDecoratableComponent
    {
        private IDecoratableComponent DecoratableComponent { get; }

        protected Decorator(IDecoratableComponent decoratableComponent)
        {
            DecoratableComponent = decoratableComponent;
        }

        public virtual void Activate(GameObject gameObject)
        {
            DecoratableComponent.Activate(gameObject);
        }
    }
}