namespace HomeLibraryApp.Model
{
    public class Progress
    {
        public Progress(int amt)
        {
            progressAmmount = amt;
        }
        private int progressAmmount;
        public int ProgressAmmount
        {
            get { return progressAmmount; }
            set {
                //for now we want to validate as a backup making sure we are between 0-100
                if (value > 100)
                {
                    progressAmmount = 100;
                }
                else if (value < 0)
                {
                    progressAmmount = 0;
                }
                else
                {
                    progressAmmount = value;
                }
                   
            }
        }

    }
}