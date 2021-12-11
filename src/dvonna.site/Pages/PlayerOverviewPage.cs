using System;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using dvonna.Shared;
using dvonna.Site.Services;
using dvonna.Site.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace dvonna.Site.Pages
{
    public class PlayerOverviewPage : ComponentBase, IDisposable
    {
        private Timer _countdown;

        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Inject]
        public IUserPreferences UserPreferences { get; set; }

        [Inject]
        public IStringLocalizer<LocalizedStrings> Loc { get; set; }

        public IOrderedEnumerable<PlayerDetails> Players { get; set; }

        public string SelectedPlayerId { get; set; }

        public string PlayerSavedMessage { get; private set; }

        public bool PlayerSavedMessageVisible { get; private set; }

        public PlayerDetails SelectedPlayer
        {
            get
            {
                return GetSelectedPlayer();
            }
        }

        private PlayerDetails GetSelectedPlayer()
        {
            if (int.TryParse(SelectedPlayerId, out int selectedPlayerId))
            {
                return Players.SingleOrDefault(p => p.Id == selectedPlayerId);
            }

            return null;
        }

        protected override async Task OnInitializedAsync()
        {
            Players = await GetPlayersOrderedByNameAsync();
            SelectedPlayerId = await LoadSelectedPlayerIdAsync();
        }

        private async Task<IOrderedEnumerable<PlayerDetails>> GetPlayersOrderedByNameAsync()
        {
            var players = await PlayerService.GetPlayersAsync();
            return players.OrderBy(p => p.Name);
        }

        private async Task<string> LoadSelectedPlayerIdAsync()
        {
            var savedPlayerId = await UserPreferences.GetSavedPlayerIdAsync();
            return savedPlayerId?.ToString();
        }

        public async Task SaveSelectedPlayer()
        {
            if (int.TryParse(SelectedPlayerId, out int selectedPlayerId))
            {
                await UserPreferences.SavePlayerIdAsync(selectedPlayerId);

                var savedPlayerName = Players.Single(p => p.Id == selectedPlayerId).Name;
                ShowPlayerSavedMessage(string.Format(@Loc["PlayerSavedSuccessfully"], savedPlayerName));
            }
            else
            {
                await UserPreferences.RemoveSavedPlayerIdAsync();
                ShowPlayerSavedMessage(@Loc["Saved player has been cleared successfully"]);
            }
        }

        private void ShowPlayerSavedMessage(string message)
        {
            StartCountdown();

            PlayerSavedMessage = message;
            PlayerSavedMessageVisible = true;
        }

        private void StartCountdown()
        {
            if (_countdown == null)
            {
                _countdown = new Timer(5000);
                _countdown.Elapsed += HidePlayerSavedMessage;
                _countdown.AutoReset = false;
            }

            if (_countdown.Enabled)
            {
                _countdown.Stop();
                _countdown.Start();
            }
            else
            {
                _countdown.Start();
            }
        }

        private void HidePlayerSavedMessage(object sender, ElapsedEventArgs e)
        {
            InvokeAsync(() =>
            {
                PlayerSavedMessageVisible = false;
                PlayerSavedMessage = "";
                StateHasChanged();
            });
        }

        public void Dispose()
        {
            _countdown?.Dispose();
        }
    }
}
