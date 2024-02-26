using UnityEngine;
using UnityEngine.UI;

namespace UI.Components
{
    public class ImageComponent : BaseComponent
    {
        [SerializeField] private Image image;
        
        public override void Activate()
        {
            image.gameObject.SetActive(true);
        }

        public override void Deactivate()
        {
            image.gameObject.SetActive(false);
        }

        public void ChangeSprite(Sprite newSprite)
        {
            image.sprite = newSprite;
        }
    }
}