
namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool IsLedGlowing;

        public LEDAlert()
        {
            IsLedGlowing = false;
        }
        public void Alert()
        {
            IsLedGlowing = true;
        }

    }
}