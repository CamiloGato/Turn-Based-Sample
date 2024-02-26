using TMPro;
using UnityEngine;

namespace UI.Components
{
    public class TextComponent : BaseComponent
    {
        [SerializeField] private TMP_Text textTmp;

        public override void Activate()
        {
            textTmp.gameObject.SetActive(true);
        }

        public override void Deactivate()
        {
            textTmp.gameObject.SetActive(false);
        }

        public void ChangeText(string newText)
        {
            textTmp.text = newText;
        }
        
    }
}