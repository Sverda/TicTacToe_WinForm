using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace TicTacToe
{
    class GameView
    {
        public GameView()
        {
            game = new Game();
            emptyField = new Uri("ms-appx:///Assets/Fields/emptyField.jpg");
            firstPlayerField = new Uri("ms-appx:///Assets/Fields/OField.jpg");
            secondPlayerField = new Uri("ms-appx:///Assets/Fields/XField.jpg");
        }
        private Game game;
        public Uri emptyField;
        private Uri firstPlayerField;
        private Uri secondPlayerField;
        public string WhosturnString
        {
            get
            {
                if (!game.Whosturn)
                    return "Player 1 has turn. ";
                else
                    return "Player 2 has turn. ";
            }
        }

        public BitmapImage Field0x0//first '0' is a collumn, second is a row
        {
            get
            {
                if (game.Fields[0, 0] != null)
                {
                    if (game.Fields[0, 0] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field0x1 
        {
            get
            {
                if (game.Fields[0, 1] != null)
                {
                    if (game.Fields[0, 1] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field0x2 
        {
            get
            {
                if (game.Fields[0, 2] != null)
                {
                    if (game.Fields[0, 2] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field1x0 
        {
            get
            {
                if (game.Fields[1, 0] != null)
                {
                    if (game.Fields[1, 0] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field1x1 
        {
            get
            {
                if (game.Fields[1, 1] != null)
                {
                    if (game.Fields[1, 1] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field1x2 
        {
            get
            {
                if (game.Fields[1, 2] != null)
                {
                    if (game.Fields[1, 2] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field2x0 
        {
            get
            {
                if (game.Fields[2, 0] != null)
                {
                    if (game.Fields[2, 0] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field2x1 
        {
            get
            {
                if (game.Fields[2, 1] != null)
                {
                    if (game.Fields[2, 1] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }
        public BitmapImage Field2x2 
        {
            get
            {
                if (game.Fields[2, 2] != null)
                {
                    if (game.Fields[2, 2] == false)
                        return new BitmapImage(firstPlayerField);
                    else
                        return new BitmapImage(secondPlayerField);
                }
                else
                    return new BitmapImage(emptyField);
            }
        }

        public void FieldPressed(int x, int y)
        {
            game.PlayerDidTurn(x, y);
            OnPropertyChanged("Field0x0");
            OnPropertyChanged("Field0x1");
            OnPropertyChanged("Field0x2");
            OnPropertyChanged("Field1x0");
            OnPropertyChanged("Field1x1");
            OnPropertyChanged("Field1x2");
            OnPropertyChanged("Field2x0");
            OnPropertyChanged("Field2x1");
            OnPropertyChanged("Field2x2");
            OnPropertyChanged("WhosturnString");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
