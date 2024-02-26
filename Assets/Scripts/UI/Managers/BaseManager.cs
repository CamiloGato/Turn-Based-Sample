using UI.Controllers;
using UnityEngine;

namespace UI.Managers
{
    public class BaseManager : MonoBehaviour
    {
        [SerializeField] private InformationController informationController;
        
        private void Start()
        {
            informationController.Activate();
        }

        private void OnApplicationQuit()
        {
            informationController.Deactivate();
        }
    }
}