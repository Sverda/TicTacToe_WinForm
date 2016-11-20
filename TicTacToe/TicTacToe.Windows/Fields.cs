using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace TicTacToe
{
    class Fields
    {
        public Fields(Uri firstPlayerField, Uri secondPlayerField, Uri emptyField)
        {
            this.firstPlayerField = firstPlayerField;
            this.secondPlayerField = secondPlayerField;
            this.emptyField = emptyField;
        }
        Uri firstPlayerField;
        Uri secondPlayerField;
        Uri emptyField;
    }
}
