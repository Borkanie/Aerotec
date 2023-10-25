namespace Aerotec.Data.Services
{
    /// <summary>
    /// A <see cref="static"/> <see cref="class"/> dealing with writing to a Log.Txt file in the same directory as the executable.
    /// When Debug will be set to true The mockup will be used instead of the real IClientService.
    /// </summary>
    public static class Log
    {
        public static bool DEBUG = false;
        private static string file = "Log.txt";

        /// <summary>
        /// Appends  anew line to the Log.txt file.
        /// </summary>
        /// <param name="text">The text form the line.</param>
        public static void WriteLine(string text)
        {
            if (DEBUG)
            {
                if (!File.Exists(file))
                {
                    _ = File.Create(file);
                }

                try
                {
                    using (StreamWriter sw = new(file, true))
                    {
                        // true argument specifies that we want to append to the file
                        sw.WriteLine(text);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
