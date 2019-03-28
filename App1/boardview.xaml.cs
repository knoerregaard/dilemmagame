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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class boardview : Page
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int[,] Path { get; set; }
        Player player;
        List<Player> players;
        public boardview()
        {
            
            this.InitializeComponent();

            //Start position
            this.X = 0;
            this.Y = 0;

            //Steps or Path
            this.Path = new int[,] { { 0, 0 },{ 40, 50 }, { 95, 45 }, {130,0 }, { 110,-60 }, { 60, -100 }, { 0,-140 }, { -40, -200 }, { -30,-280 }};

            // New player
            player = new Player(this.Path);
        }


        private void ThrowDie_Click(object sender, RoutedEventArgs e)
        {
            //Die returns a number
            int eyes = Die.ThrowDice();

            //Write eyes to view
            die.Content = eyes;

            //Move the Player
            player.MovePlayer(eyes);

            //Animate the player movement
            this.AnimatePlayerMovement(player, eyes);

        }

        private void AnimatePlayerMovement(Player player, int eyes)
        {
            //This will hold hour animation
            Piece.RenderTransform = new CompositeTransform();

            //New storyboard
            Storyboard storyboard = new Storyboard();

            //New DoubleAnimation - Y
            DoubleAnimation translateYAnimation = new DoubleAnimation();
            translateYAnimation.From = this.Path[player.position - eyes , 1];
            translateYAnimation.To = this.Path[player.position , 1];

            translateYAnimation.EasingFunction = new ExponentialEase();
            translateYAnimation.EasingFunction.EasingMode = EasingMode.EaseOut;
            translateYAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(500));
            Storyboard.SetTarget(translateYAnimation, Piece);
            Storyboard.SetTargetProperty(translateYAnimation, "(UIElement.RenderTransform).(CompositeTransform.TranslateY)");
            storyboard.Children.Add(translateYAnimation);

            //New DoubleAnimation - X 
            DoubleAnimation translateXAnimation = new DoubleAnimation();

            translateXAnimation.From = this.Path[player.position - eyes, 0];
            translateXAnimation.To = this.Path[player.position, 0];

            //translateXAnimation.From = this.Path[player.position - eyes, 0];
            //translateXAnimation.To = this.Path[player.position, 0];
            translateXAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(500));

            Storyboard.SetTarget(translateXAnimation, Piece);
            Storyboard.SetTargetProperty(translateXAnimation, "(UIElement.RenderTransform).(CompositeTransform.TranslateX)");

            storyboard.Children.Add(translateXAnimation);

            //executing the storyboard
            storyboard.Begin();
            

      
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            //New list of plaers
            players = new List<Player>();
            if (PlayerNumb != null)
            {
                //Start game
                for (int i = 0; i < Int32.Parse(PlayerNumb.Text); i++)
                {
                    this.players.Add(new Player(this.Path));

                }

            }
            //Place markers on the board

            //Start game

            // New up x numbers of players
            // Animate marker for each player
            // Set player 1 start
        }
    }
}
