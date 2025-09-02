namespace Models
{
	public class Chien : Animal
	{
		public override double DureeAvantFaim => 8;
		public override string SExprimer() => "Wouff";
		public override decimal coutRepas => 8.0m;
	}
}