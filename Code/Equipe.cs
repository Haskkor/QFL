using System;

namespace QFL
{
	public class Equipe
	{
		public Joueur[] equipe = new Joueur[7];     // EQUIPE. Tableau de joueurs représentant l'équipe.
		public String nomEqui;						// NOM DE L'EQUIPE.
		public int positionJoueur;				    /* POSITION DU JOUEUR. 
		                                   			 * 0 - Gardien.
		                                   			 * 1 - 2 - 3 - Poursuiveurs.
		                                   			 * 4 - 5 - Batteurs
		                                   			 * 6 - Attrapeur. */
		
		public Equipe(String name)
		{
			this.nomEqui = name;
		}
		
		public void remplirEquipe(Joueur player, int pos)
		{
			equipe[pos] = player;
		}
	}
}
