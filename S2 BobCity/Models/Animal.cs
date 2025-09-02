namespace Models
{
    public abstract class Animal
    {
        public string Nom { get; set; }
        protected DateTime DernierRepas;


        public abstract double DureeAvantFaim { get; }
        public abstract string SExprimer();
        public abstract decimal coutRepas { get; }

        public bool EstAffame()
        {
            return (DateTime.Now - DernierRepas).TotalHours >= DureeAvantFaim;
        }
        public void Manger()
        {
            DernierRepas = DateTime.Now;
        }
    } 
}