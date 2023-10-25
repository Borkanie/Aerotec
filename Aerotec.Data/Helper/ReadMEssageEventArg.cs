// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.Data.Helper
{
    /// <summary>
    /// A message has been read from the fileinterface.Used in mockup.
    /// </summary>
    public class ReadMEssageEventArg : EventArgs
    {
        public string Text { get; }
        public ReadMEssageEventArg(string text)
        {
            Text = text;
        }
    }
}