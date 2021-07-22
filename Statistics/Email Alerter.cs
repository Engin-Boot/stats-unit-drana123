
namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool IsEmailSent;

        public EmailAlert()
        {
            IsEmailSent = false;
        }
        public void Alert()
        {
            IsEmailSent = true;
        }

    }
}