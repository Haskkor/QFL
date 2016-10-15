using System;

namespace QFL
{
	public class Cognard : Balle
	{
		public String type = "Cognard";
		
		public Cognard(int speed, int str, int weight, int height)
		{
			this.vitBal = speed;
			this.forceBal = str;
			this.pdsBal = weight;
			this.tailBal = height;
		}
	}
}
