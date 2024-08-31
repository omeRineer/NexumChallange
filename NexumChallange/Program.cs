namespace NexumChallange
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ExceptionHandle);

            ApplicationConfiguration.Initialize();
            Application.Run(new Mars());

        }

        static void ExceptionHandle(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;

            MessageBox.Show(e.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}