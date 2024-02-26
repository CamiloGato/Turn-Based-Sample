using UnityEngine;

namespace UI.Components
{
    public abstract class BaseComponent : MonoBehaviour
    {
        public abstract void Activate();
        public abstract void Deactivate();
    }
}