using System;

namespace dvonna.Site.Services
{
    public interface IToastService : IDisposable
    {
        event Action<string, ToastLevel> OnShow;
        event Action OnHide;

        void ShowToast(string message, ToastLevel level);
    }
}
