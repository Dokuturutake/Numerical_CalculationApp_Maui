namespace Numerical_CalculationApp_Maui.Pages.Animations
{
    public class SlideAction : TriggerAction<VisualElement>
    {
        public double X { get; set; } = 2;
        public double Y { get; set; } = 2;
        public Easing Easing { get; set; } = Easing.Linear;
        public int Length { get; set; } = 250;
        private long _time = 1;

        protected override void Invoke(VisualElement visual)
        {
            visual.TranslateTo(X, Y * _time, (uint)Length, Easing);
            _time++;
        }
    }
}
