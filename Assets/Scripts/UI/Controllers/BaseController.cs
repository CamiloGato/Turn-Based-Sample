using UnityEngine;

namespace UI.Controllers
{
    public abstract class BaseController : MonoBehaviour
    {
        public abstract void Activate();
        public abstract void Deactivate();
    }
}