// --------------------------------------------------------------------------
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// --------------------------------------------------------------------------

using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Devart.Controls;

namespace SmoothPanelSample
{
    internal class BarItem : ItemBase, IHeightMeasurer
    {
        private string _text;

        public BarItem(string text)
        {
            Text = text;
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        public double GetEstimatedHeight(double width)
        {
            return 16;
        }
    }
}