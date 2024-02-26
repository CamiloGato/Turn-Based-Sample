using UI.Components;
using UnityEngine;

namespace UI.Views
{
    public class InformationView : BaseView
    {
        [SerializeField] private TextComponent nameComponent;
        [SerializeField] private TextComponent lifeComponent;
        [SerializeField] private ImageComponent imageComponent;
        
        public override void Initialize()
        {
            nameComponent.Activate();
            lifeComponent.Activate();
        }

        public override void Close()
        {
            nameComponent.Deactivate();
            lifeComponent.Deactivate();
        }

        public void UpdateName(string newName)
        {
            string text = $"Name: {newName}";
            nameComponent.ChangeText(text);
        }

        public void UpdateImage(Sprite sprite)
        {
            imageComponent.ChangeSprite(sprite);
        }

        public void UpdateLife(int amount)
        {
            string text = $"Life: {amount}/{20}";
            lifeComponent.ChangeText(text);
        }
        
    }
}