// --------------------------------------------------------------------------
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// --------------------------------------------------------------------------

using System.Windows.Media;
using Devart.Controls;

namespace SmoothPanelSample
{
    internal class FooItem : ItemBase, IHeightMeasurer
    {
        private string _text;

        private double _estimatedHeight = -1;

        private double _estimatedWidth;

        public FooItem(string text, Color color)
        {
            Text = text;
            Brush = new SolidColorBrush(color);
        }

        public SolidColorBrush Brush { get; set; }

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
                    _estimatedHeight = -1;
                    OnPropertyChanged("Text");
                }
            }
        }

        public double GetEstimatedHeight(double width)
        {
            // Do not recalc height if text and width are unchanged
            if (_estimatedHeight < 0 || _estimatedWidth != width)
            {
                _estimatedWidth = width;
                _estimatedHeight = TextMeasurer.GetEstimatedHeight(_text, width) + 20; // Add margin
            }
            return _estimatedHeight;
        }
    }
}