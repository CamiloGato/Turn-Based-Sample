using UnityEngine;

namespace UI.Models
{
    [CreateAssetMenu(fileName = "UserInformationSo", menuName = "UI/Models/UserInformation")]
    public class InformationModel : BaseModel
    {
        public Sprite userImage;
        public string userName;
        public int amountLife;
    }
}