using UI.Models;
using UI.Views;
using UnityEngine;

namespace UI.Controllers
{
    public class InformationController : BaseController
    {
        [SerializeField] private InformationView informationView;
        [SerializeField] private InformationModel informationModel;
        
        public override void Activate()
        {
            informationView.Initialize();
            informationView.UpdateName(informationModel.userName);
            informationView.UpdateImage(informationModel.userImage);
            informationView.UpdateLife(informationModel.amountLife);
        }

        public override void Deactivate()
        {
            informationView.Close();
        }
    }
}