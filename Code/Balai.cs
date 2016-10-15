using System;

namespace QFL
{
	public class Balai
	{
		int vitMax;   /* VITESSE MAXIMUM. Vitesse de pointe atteinte par le balai. Nombre de cases maximum qu'un joueur peut 
		               * traverser en un tour. */
		int accel;    /* ACCELERATION. Temps mit par le balais pour atteindre 100km/h. Bonus d'initiative. */
		int maniab;   /* MANIABILITE. Facilit� qu'aura le joueur � diriger le balai. Bonus de vol. */
		int resMag;   /* RESISTANCE MAGIQUE. Efficacit� des vernis antimal�fices de s�rie. Sauvegarde contre les sorts visant
		               * le balai. */
		int resPhy;   /* RESISTANCE PHYSIQUE. Solidit� du balai. Sauvegarde contre les dommages physiques visant le balai. */
		int altMax;   /* ALTITUDE MAXIMALE. Altitude que le balai peut atteindre en restant controlable. R�duction du malus
		               * du � l'altitude. */
		int acrob;    /* Aptitude du balai � r�sister � de fortes contraintes impos�es par les mouvements du joueur. Bonus 
		               * lors des mouvements acrobatiques. */
		int stab;     /* STABILITE. Aptitude du balai � effectuer des vols stationnaires et � r�duire les vibrations en vol.
		               * Bonus de vol en vol � une main ou sans les mains et bonus de vol pour les gardiens. */
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
