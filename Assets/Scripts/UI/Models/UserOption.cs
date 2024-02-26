using UnityEngine;

namespace UI.Models
{
    [CreateAssetMenu(fileName = "UserOption", menuName = "UI/Models/UserOption")]
    public class UserOption : BaseModel
    {
        public string optionName;
        public int damageAmount;
    }
}