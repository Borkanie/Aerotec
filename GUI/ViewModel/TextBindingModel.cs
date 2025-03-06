// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using System.ComponentModel;

namespace Aerotec.ViewModel
{
    /// <summary>
    /// A viewModel that allows property binding in winforms.
    /// </summary>
    public class TextBindingModel : INotifyPropertyChanged
    {
        private string _myTextProperty;

        public string Content
        {
            get { return _myTextProperty; }
            set
            {
                if (_myTextProperty != value)
                {
                    _myTextProperty = value;
                    OnPropertyChanged(nameof(Content));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
