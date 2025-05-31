using ReactiveUI; // For ReactiveObject and ReactiveCommand
using System.Reactive; // For Unit (used with ReactiveCommand)

// CORRECTED: Namespace should match your project name and folder structure
namespace StringLengthCounterGUI.ViewModels // <--- CHANGE IS HERE
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string? _inputString;
        public string? InputString
        {
            get => _inputString;
            set => this.RaiseAndSetIfChanged(ref _inputString, value);
        }

        private string _resultString = "Length: (enter text)";
        public string ResultString
        {
            get => _resultString;
            set => this.RaiseAndSetIfChanged(ref _resultString, value);
        }

        public ReactiveCommand<Unit, Unit> CalculateLengthCommand { get; }

        public MainWindowViewModel()
        {
            CalculateLengthCommand = ReactiveCommand.Create(CalculateLength);
        }

        private void CalculateLength()
        {
            if (string.IsNullOrWhiteSpace(InputString))
            {
                ResultString = "Length: 0 (no input)";
            }
            else
            {
                ResultString = $"Length: {InputString.Length}";
            }
        }
    }
}