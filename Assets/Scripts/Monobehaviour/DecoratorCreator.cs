using System;
using Decorators;
using UnityEngine;

namespace Monobehaviour
{
    public class DecoratorCreator : MonoBehaviour
    {
        public Types type;

        public IDecoratableComponent CreateDecorator(IDecoratableComponent decorator)
        {
            switch (type)
            {
                case Types.AddForce:
                    print("Created force decorator");
                    return new AddForceDecorator(decorator);
                
                case Types.IncreaseSize:
                    print("Created Size decorator");
                    return new IncreaseSizeDecorator(decorator);
                
                default:
                    return new AddForceDecorator(decorator);
            }
        }
        
        
        
        public enum Types
        {
            AddForce,
            IncreaseSize
        }
    }
}