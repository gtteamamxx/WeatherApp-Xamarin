using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace weatherxamarin.Behaviors
{
    public class TimeSwipAnimationBehavior  : Behavior<Image>
    {
        protected override async void OnAttachedTo(Image bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TranslationY = 300;
            await bindable.TranslateTo(0, 0, 1000);
        }
    }
}
