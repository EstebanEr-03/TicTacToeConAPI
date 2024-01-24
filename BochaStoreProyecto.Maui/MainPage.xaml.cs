using BochaStoreProyecto.Maui.Models;
using BochaStoreProyecto.Maui.Services;

namespace BochaStoreProyecto.Maui
{

    public partial class MainPage : ContentPage
    {
        private APIService _apiService;
        public Resultado resultadoX;
        public Resultado resultadoO;
        public int resultadoXVictorias;
        public int resultadoOVictorias;

        public MainPage()
        {
            InitializeComponent();
            _apiService = new APIService(); // Inicializa el servicio
        }
        public async Task ObtenerResultadoAsync()
        {
            resultadoX = await _apiService.GetResultado(1);
            resultadoO = await _apiService.GetResultado(2);
            resultadoXVictorias = resultadoX.CantidadVictorias;
            resultadoXVictorias = resultadoO.CantidadVictorias;
            // Ahora puedes trabajar con resultadoObtenido, que es un objeto Resultado
        }


        bool checkForXorO = false;
        int addOneToScore = 0;
        void buttonsDisabled()
        {
            Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
        }
        void checkForWin()
        {

            if (Button1.Text == "X" && Button2.Text == "X" && Button3.Text == "X")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button2.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("Tenemos un ganador", "Jugador X gano", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();
                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    //CantidadVictorias = resultadoXVictorias+1, // Puedes ajustar esto según tus necesidades
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);

            }
            if (Button4.Text == "X" && Button5.Text == "X" && Button6.Text == "X")
            {
                Button4.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button6.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("Tenemos un ganador", "Jugador X gano", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();
                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button7.Text == "X" && Button8.Text == "X" && Button9.Text == "X")
            {
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button8.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button1.Text == "X" && Button4.Text == "X" && Button7.Text == "X")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button4.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button2.Text == "X" && Button5.Text == "X" && Button8.Text == "X")
            {
                Button2.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button8.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();
                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button3.Text == "X" && Button6.Text == "X" && Button9.Text == "X")
            {
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button6.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button1.Text == "X" && Button5.Text == "X" && Button9.Text == "X")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }
            if (Button3.Text == "X" && Button5.Text == "X" && Button7.Text == "X")
            {
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player X won this round", "OK");
                addOneToScore = int.Parse(LabelXScore.Text);
                LabelXScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "x",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelXScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(1, resultado);
            }

            // O combinations

            if (Button1.Text == "O" && Button2.Text == "O" && Button3.Text == "O")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button2.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button4.Text == "O" && Button5.Text == "O" && Button6.Text == "O")
            {
                Button4.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button6.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button7.Text == "O" && Button8.Text == "O" && Button9.Text == "O")
            {
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button8.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button1.Text == "O" && Button4.Text == "O" && Button7.Text == "O")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button4.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button2.Text == "O" && Button5.Text == "O" && Button8.Text == "O")
            {
                Button2.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button8.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button3.Text == "O" && Button6.Text == "O" && Button9.Text == "O")
            {
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button6.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button1.Text == "O" && Button5.Text == "O" && Button9.Text == "O")
            {
                Button1.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button9.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
            if (Button3.Text == "O" && Button5.Text == "O" && Button7.Text == "O")
            {
                Button3.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button5.BackgroundColor = Color.FromRgb(0, 0, 0);
                Button7.BackgroundColor = Color.FromRgb(0, 0, 0);
                DisplayAlert("We have a winner", "Player O won this round", "OK");
                addOneToScore = int.Parse(LabelOScore.Text);
                LabelOScore.Text = (addOneToScore + 1).ToString();
                buttonsDisabled();
                ObtenerResultadoAsync();

                Resultado resultado = new Resultado
                {
                    nombre = "O",
                    resultado = true,
                    CantidadVictorias = int.Parse(LabelOScore.Text), // Puedes ajustar esto según tus necesidades
                    fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
                };
                var response = _apiService.PutResultado(2, resultado);
            }
        }
        void ButtonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (!checkForXorO)
            {
                b.Text = "X";
                checkForXorO = true;
            }
            else
            {
                b.Text = "O";
                checkForXorO = false;
            }

            // Verifica si es el turno de X o de O y muestra un mensaje correspondiente
            if (checkForXorO)
            {
                DisplayAlert("Cambio de Turno", "Es el turno del Jugador O", "OK");
            }
            else
            {
                DisplayAlert("Cambio de Turno", "Es el turno del Jugador X", "OK");
            }

            checkForWin();
            b.IsEnabled = false;
        }

        void reset()
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;

            Button1.Text = "";
            Button2.Text = "";
            Button3.Text = "";
            Button4.Text = "";
            Button5.Text = "";
            Button6.Text = "";
            Button7.Text = "";
            Button8.Text = "";
            Button9.Text = "";

            Button1.Background = Brush.BlueViolet;
            Button2.Background = Brush.BlueViolet;
            Button3.Background = Brush.BlueViolet;
            Button4.Background = Brush.BlueViolet;
            Button5.Background = Brush.BlueViolet;
            Button6.Background = Brush.BlueViolet;
            Button7.Background = Brush.BlueViolet;
            Button8.Background = Brush.BlueViolet;
            Button9.Background = Brush.BlueViolet;
        }
        void ButtonResetClick(object sender, EventArgs e)
        {
            reset();
        }
        void ButtonNewGameClick(object sender, EventArgs e)
        {
            reset();
            LabelXScore.Text = "0";
            LabelOScore.Text = "0";
            Resultado resultadox = new Resultado
            {
                nombre = "X",
                resultado = false,
                CantidadVictorias = 0, // Puedes ajustar esto según tus necesidades
                fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
            };
            var responsex = _apiService.PutResultado(1, resultadox);

            Resultado resultadoy = new Resultado
            {
                nombre = "O",
                resultado = false,
                CantidadVictorias = 0, // Puedes ajustar esto según tus necesidades
                fechaResultado = DateTime.Now // Puedes ajustar esto según tus necesidades
            };
            var responsey = _apiService.PutResultado(2, resultadoy);
        }

        async Task exit()
        {
            bool answer = await DisplayAlert("Question?", "Would you like to exit?", "Yes", "No");
            if (answer)
            {
                Application.Current?.CloseWindow(Application.Current.MainPage.Window);
            }
        }
        void ButtonExitClick(object sender, EventArgs e)
        {
            exit();
        }


    }


}
