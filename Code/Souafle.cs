using System;

namespace QFL
{	
	public class Souafle : Balle
	{
		public String type = "Souafle";
		
		public Souafle(int speed, int str, int weight, int height)
		{
			this.vitBal = speed;
			this.forceBal = str;
			this.pdsBal = weight;
			this.tailBal = height;
		}
	}
}
