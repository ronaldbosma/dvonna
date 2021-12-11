using System;
using System.Timers;

namespace dvonna.Site.Services
{
    /// <summary>
    /// Component for displaying toast notifications.
    /// </summary>
    /// <remarks>
    /// Source: https://chrissainty.com/blazor-toast-notifications-using-only-csharp-html-css/
    /// </remarks>
    public class ToastService : IToastService
    {
        public event Action<string, ToastLevel> OnShow;
        public event Action OnHide;
        private Timer Countdown;
        private const int NumberOfMillisecondsBeforeHidingToast = 5000;

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
            StartCountdown();
        }

        private void StartCountdown()
        {
            SetCountdown();

            if (Countdown.Enabled)
            {
                Countdown.Stop();
                Countdown.Start();
            }
            else
            {
                Countdown.Start();
            }
        }

        private void SetCountdown()
        {
            if (Countdown == null)
            {
                Countdown = new Timer(NumberOfMillisecondsBeforeHidingToast);
                Countdown.Elapsed += HideToast;
                Countdown.AutoReset = false;
            }
        }

        private void HideToast(object source, ElapsedEventArgs args)
        {
            OnHide?.Invoke();
        }

        public void Dispose()
        {
            Countdown?.Dispose();
        }
    }
}
