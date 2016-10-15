using System;

namespace QFL
{
	public class Balai
	{
		int vitMax;   /* VITESSE MAXIMUM. Vitesse de pointe atteinte par le balai. Nombre de cases maximum qu'un joueur peut 
		               * traverser en un tour. */
		int accel;    /* ACCELERATION. Temps mit par le balais pour atteindre 100km/h. Bonus d'initiative. */
		int maniab;   /* MANIABILITE. Facilité qu'aura le joueur à diriger le balai. Bonus de vol. */
		int resMag;   /* RESISTANCE MAGIQUE. Efficacité des vernis antimaléfices de série. Sauvegarde contre les sorts visant
		               * le balai. */
		int resPhy;   /* RESISTANCE PHYSIQUE. Solidité du balai. Sauvegarde contre les dommages physiques visant le balai. */
		int altMax;   /* ALTITUDE MAXIMALE. Altitude que le balai peut atteindre en restant controlable. Réduction du malus
		               * du à l'altitude. */
		int acrob;    /* Aptitude du balai à résister à de fortes contraintes imposées par les mouvements du joueur. Bonus 
		               * lors des mouvements acrobatiques. */
		int stab;     /* STABILITE. Aptitude du balai à effectuer des vols stationnaires et à réduire les vibrations en vol.
		               * Bonus de vol en vol à une main ou sans les mains et bonus de vol pour les gardiens. */
		int pd;       /* POINTS DE DEGATS. Seuil de dommages au dela duquel le balai ne sera plus utilisable. */
		
		public Balai(int speedMax, int acceleration, int manageability, int resMagic, int resPhysical, int maxHeight, 
		             int acrobatics, int stability, int damagePts)
		{
			this.vitMax = speedMax;
			this.accel = acceleration;
			this.maniab = manageability; 
			this.resMag = resMagic;
			this.resPhy = resPhysical;
			this.altMax = maxHeight;
			this.acrob = acrobatics;
			this.stab = stability;
			this.pd = damagePts;
		}
	}
}
