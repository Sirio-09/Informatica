namespace lesson
{
    public partial class FrmMain : Form
    {
        //global variables
        static string[] cards = {"berry.jpg", "cherry.jpg", "stars.png", "tree.jpg"};
        static string bomb = "bomb.jpg";

        //Ci sere per posizionare le carte in manieora casuale
        static Random rnd = new Random();

        static int GRID_SIZE = 3;

        //game state
        int remainingErrors;
        string[,] gameMatrix;

        private void GenerateGameGrid()
        {
            gameMatrix = new string[GRID_SIZE, GRID_SIZE];

            //prima metto la bomba in una cella casuale
            //
            //successivamente scorro card e metto 2 volta la
            //singola card in una posizione casuale.
            int x = rnd.Next(0, GRID_SIZE);
            int y = rnd.Next(0, GRID_SIZE);
            gameMatrix[x, y] = bomb;

            foreach(string card in cards)
            {
                for(int i = 0; i < 2; i++)
                {
                    //genero una singola card in una posizione
                    //casuale
                    do
                    {
                        x = rnd.Next(0, GRID_SIZE);
                        y = rnd.Next(0, GRID_SIZE);

                    } while (gameMatrix[x, y] != null);
                }
            }
        }

        public void ResetGame()
        {
            remainingErrors = 3;
            GenerateGameGrid();
        }

        public void ResetGameUI()
        {
            //quando comincia una nuova partita:
            //-disabilito il bottone nuova partita
            btn_partita.Enabled = false;
            //-abilito tutte le picturebox
            for(int i = 0; i < GRID_SIZE; i++)
            {
                for(int j = 0; j < GRID_SIZE; j++)
                {
                    PictureBox pbCard = (PictureBox)Controls[$"pcb_card{i}"];
                    pbCard.Enabled = true;
                    pbCard.Image = null;
                }
            }
            //-inizializzo la label con il valore corretto
            lbl_error.Text = $"Errori Rimanenti: {remainingErrors}";
            //-mostro la label
            lbl_error.Visible = true;
        }

        private void pcb_card_click(object sender, EventArgs e)
        {

        }

        private void FlipCard(PictureBox flippedCard)
        {
            if(lastCard == null)
            {
                lastCard = flippedCard;    
            }
            else
            {
                int x = flippedCard.Name[7] - '0';
                int y = flippedCard.Name[8] - '0';
            }
        }


        public FrmMain()
        {
            InitializeComponent();
        }

        private void lbl_error_Click(object sender, EventArgs e)
        {

        }

        private void btn_partita_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pcb_card3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
