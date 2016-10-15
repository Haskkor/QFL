using System;

namespace QFL
{
	public class VifDor : Balle
	{
		public String type = "Vif d'or";
		
		public VifDor(int speed, int str, int weight, int height)
		{
			this.vitBal = speed;
			this.forceBal = str;
			this.pdsBal = weight;
			this.tailBal = height;
		}
	}
}
