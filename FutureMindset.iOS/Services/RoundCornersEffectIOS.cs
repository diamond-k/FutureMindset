using System;

[assembly: ExportEffect(typeof(RoundCornersEffectIOS), nameof(RoundCornersEffect))]
namespace FutureMindset.iOS
{
    public class RoundCornersEffectIOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            PrepareContainer();
            SetCornerRadius();
        }

        protected override void OnDetached()
        {
            Container.Layer.CornerRadius = new nfloat(0);
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == RoundCornersEffect.CornerRadiusProperty.PropertyName)
                SetCornerRadius();
        }

        private void PrepareContainer()
        {
            Container.ClipsToBounds = true;
            Container.Layer.AllowsEdgeAntialiasing = true;
            Container.Layer.EdgeAntialiasingMask = CAEdgeAntialiasingMask.All;
        }

        private void SetCornerRadius()
        {
            var cornerRadius = RoundCornersEffect.GetCornerRadius(Element);
            Container.Layer.CornerRadius = new nfloat(cornerRadius);
        }
    }
}