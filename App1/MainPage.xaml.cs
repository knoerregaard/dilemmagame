using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public List<Dilemma> DilemmaList;
        BoardGame boardGame;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ThrowDie_Click(object sender, RoutedEventArgs e)
        {
        }
        private void MovePiece_Click(object sender, RoutedEventArgs e)
        {
        }

        private void AnimatePlayerMovement(Player player, int eyes)
        {
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            boardGame = new BoardGame(PlayerNumb.Text);
            //InitializeDilemmas();
            //AnimateNewPlayerPiece();
        }
        private void InitPiece() { }
    }
}
