﻿using System.Windows.Controls;
using System.Windows.Input;

namespace Vts.Gui.Silverlight.View
{
    public partial class PositionView : UserControl
    {
        public PositionView()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var tbx = sender as TextBox;
            if (tbx != null && e.Key == Key.Enter)
                tbx.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
