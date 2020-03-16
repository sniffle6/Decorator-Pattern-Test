using System;
using Concrete_Components;
using UnityEngine;

namespace Monobehaviour
{
    public class Brick : MonoBehaviour
    {
        private IDecoratableComponent _brick = new BuildableObject("Brick");
        private const string ActivatorTag = "Activator";
        
        
        private void OnTriggerEnter(Collider other)
        {
            var creator = other.GetComponent<DecoratorCreator>();
            
            if (!creator)
                return;

            var newDecorator = creator.CreateDecorator(_brick);
            _brick = newDecorator;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag(ActivatorTag))
                return;

            _brick.Activate(other.gameObject);
        }
    }
}