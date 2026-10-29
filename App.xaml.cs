using System.Windows;
using System.Windows.Threading;

namespace FitnessApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"Ups! Bir hata oluştu kanka:\n\n{e.Exception.Message}\n\nDetay: {e.Exception.InnerException?.Message}", 
                            "Hata Yakalandı", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true; // Uygulamanın kapanmasını engellemeye çalış
        }
    }
}
