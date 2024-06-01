using System;
using System.Drawing;
using System.Windows.Forms;

namespace Memoria
{
    public class PlaceHolder : TextBox
    {
        private string _placeholderText;
        private bool _isPlaceholder;

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                SetPlaceholder();
            }
        }

        public PlaceHolder()
        {
            GotFocus += RemovePlaceholder;
            LostFocus += SetPlaceholder;
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                _isPlaceholder = true;
                Text = _placeholderText;
                ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (_isPlaceholder)
            {
                _isPlaceholder = false;
                Text = "";
                ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(Text))
            {
                _isPlaceholder = true;
                Text = _placeholderText;
                ForeColor = Color.Gray;
            }
        }
    }
}
