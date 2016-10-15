using System;

namespace QFL
{
	public class Terrain
	{
		// TERRAIN DE QUIDDITCH. 153 de longueur, 55 de largeur, 50 de hauteur.  
		public ObjetsTerrain[,,] terrain = new ObjetsTerrain[153,55,50];
		
		/* Remplissage du terrain avec les limites, la zone d'en but, la séparation médiane, le centre de départ et les 
		 *  poteaux pour marquer. */
		public Terrain()
		{
				int iMax = this.terrain.GetLength(0);  // Longeur maximale du terrain.
				int jMax = this.terrain.GetLength(1);  // Largeur maximale du terrain.
				int kMax = this.terrain.GetLength(2);  // Hauteur maximale du terrain.

				// PLACEMENT DE LA LIGNE MEDIANE.
				this.placerPlrsObj('Y', 0, jMax, iMax/2, 0, 0, "mediane");

				// PLACEMENT DU CENTRE DU TERRAIN.
				this.terrain[iMax/2,jMax/2,0] = new DecorStatique("centre");
				
				// PLACEMENT DES POTEAUX ET DES BUTS.
				// Poteau du milieu (15 mètres).
				// Gauche.
				this.placerPlrsObj('Z', 0, 15, 9, jMax/2, 0, "poteau");
				this.terrain[9,jMax/2,15] = new DecorStatique("but");
				// Droite.
				this.placerPlrsObj('Z', 0, 15, iMax-10, jMax/2, 0, "poteau");
				this.terrain[iMax-10,jMax/2,15] = new DecorStatique("but");
				// Poteau du haut (9 mètres).
				// Gauche.
				this.placerPlrsObj('Z', 0, 9, 9, jMax/2-10, 0, "poteau");
				this.terrain[9,jMax/2-10,9] = new DecorStatique("but");
				// Droite.
				this.placerPlrsObj('Z', 0, 9, iMax-10, jMax/2-10, 0, "poteau");
				this.terrain[iMax-10,jMax/2-10,15] = new DecorStatique("but");
				// Poteau du haut (12 mètres).
				// Gauche.
				this.placerPlrsObj('Z', 0, 12, 9, jMax/2+10, 0, "poteau");
				this.terrain[9,jMax/2+10,12] = new DecorStatique("but");
				// Droite.
				this.placerPlrsObj('Z', 0, 12, iMax-10, jMax/2+10, 0, "poteau");
				this.terrain[iMax-10,jMax/2+10,15] = new DecorStatique("but");
				
				// PLACEMENT DES ZONES D'EN-BUT.
				/* En partant de l'extremité haute du quart supérieur gauche, en symétrie selon l'axe X, puis axe Y et de 
				 * nouveau axe X. */
				int x = 24;
				int y = 5;
				this.terrain[x,y,0] = new DecorStatique("enbut");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("enbut");
				this.terrain[iMax-x-2,jMax-y-1,0] = new DecorStatique("enbut");
				this.terrain[x,y,0] = new DecorStatique("enbut");
				x++; y++;
				this.placerPlrsObj('Y', y, y+2, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, iMax-x-1, 0, 0, "enbut");
				this.placerPlrsObj('Y', y, y+2, iMax-x-1, 0, 0, "enbut");
				x++; y += 2;
				this.placerPlrsObj('Y', y, y+3, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-3, jMax-y, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-3, jMax-y, iMax-x-1, 0, 0, "enbut");
				this.placerPlrsObj('Y', y, y+3, iMax-x-1, 0, 0, "enbut");
				x++; y += 3;
				this.placerPlrsObj('Y', y, y+3, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-3, jMax-y, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-3, jMax-y, iMax-x-1, 0, 0, "enbut");
				this.placerPlrsObj('Y', y, y+3, iMax-x-1, 0, 0, "enbut");
				x++; y += 3;
				this.placerPlrsObj('Y', y, y+4, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-4, jMax-y, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', jMax-y-4, jMax-y, iMax-x-1, 0, 0, "enbut");
				this.placerPlrsObj('Y', y, y+4, iMax-x-1, 0, 0, "enbut");
				x++; y += 4;
				this.placerPlrsObj('Y', y, y+19, x, 0, 0, "enbut");
				this.placerPlrsObj('Y', y, y+19, iMax-x-1, 0, 0, "enbut");
				
				//PLACEMENT DES LIMITES DU TERRAIN.
				/* En partant de l'extrémité basse du quart supérieur gauche, en symétrie selon l'axe X, puis axe Y et de
				 * nouveau axe X. */
				x = 0;
				y = 21;
				this.placerPlrsObj('Y', y, y+13, x, 0, 0, "limite");
				this.placerPlrsObj('Y', y, y+13, iMax-x-1, 0, 0, "limite");
				x++; y -= 2;
				this.placerPlrsObj('Y', y, y+2, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, iMax-x-1, 0, 0, "limite");
				this.placerPlrsObj('Y', y, y+2, iMax-x-1, 0, 0, "limite");
				x++; y -= 2;
				this.placerPlrsObj('Y', y, y+2, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, iMax-x-1, 0, 0, "limite");
				this.placerPlrsObj('Y', y, y+2, iMax-x-1, 0, 0, "limite");
				x++; y--;
				this.terrain[x,y,0] = new DecorStatique("limite");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,y,0] = new DecorStatique("limite");
				x++; y -= 2;
				this.placerPlrsObj('Y', y, y+2, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, x, 0, 0, "limite");
				this.placerPlrsObj('Y', jMax-y-2, jMax-y, iMax-x-1, 0, 0, "limite");
				this.placerPlrsObj('Y', y, y+2, iMax-x-1, 0, 0, "limite");
				x++; y--;
				this.terrain[x,y,0] = new DecorStatique("limite");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,y,0] = new DecorStatique("limite");
				x++; y--;
				this.terrain[x,y,0] = new DecorStatique("limite");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,y,0] = new DecorStatique("limite");
				x++; y--;
				this.terrain[x,y,0] = new DecorStatique("limite");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,y,0] = new DecorStatique("limite");
				x++; y--;
				this.terrain[x,y,0] = new DecorStatique("limite");
				this.terrain[x,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,jMax-y-1,0] = new DecorStatique("limite");
				this.terrain[iMax-x-1,y,0] = new DecorStatique("limite");
				x++; y--;
				this.placerPlrsObj('X', x, x+2, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+2, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, y, 0, "limite");
				x += 2; y--;
				this.placerPlrsObj('X', x, x+2, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+2, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, y, 0, "limite");
				x += 2; y--;
				this.placerPlrsObj('X', x, x+2, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+2, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, y, 0, "limite");
				x += 2; y--;
				this.placerPlrsObj('X', x, x+2, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+2, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-2, iMax-x, 0, y, 0, "limite");
				x += 2; y--;
				this.placerPlrsObj('X', x, x+3, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+3, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-3, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-3, iMax-x, 0, y, 0, "limite");
				x += 3; y--;
				this.placerPlrsObj('X', x, x+4, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+4, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-4, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-4, iMax-x, 0, y, 0, "limite");
				x += 4; y--;
				this.placerPlrsObj('X', x, x+6, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+6, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-6, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-6, iMax-x, 0, y, 0, "limite");
				x += 6; y--;
				this.placerPlrsObj('X', x, x+16, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+16, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-16, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-16, iMax-x, 0, y, 0, "limite");
				x += 16; y--;
				this.placerPlrsObj('X', x, x+18, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+18, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-18, iMax-x, 0, jMax-y-1, 0, "limite");
				this.placerPlrsObj('X', iMax-x-18, iMax-x, 0, y, 0, "limite");
				x += 18; y--;
				this.placerPlrsObj('X', x, x+25, 0, y, 0, "limite");
				this.placerPlrsObj('X', x, x+25, 0, jMax-y-1, 0, "limite");
		}
		
		// Permet de placer des objets consécutivement.
		public void placerPlrsObj(char deplac, int debIter, int finIter, int coordLong, int coordLarg, int coordHaut, 
		                          String objAPlacer)
		{
			// Les objets à placer sont sur l'axe horizontal.
			if (deplac == 'X')
			{
				for (int iter = debIter; iter < finIter; iter++)
				{
					this.terrain[iter,coordLarg,coordHaut] = new DecorStatique(objAPlacer);
				}	
			}
			// Les objets à placer sont sur l'axe vertical.
			else if (deplac == 'Y')
			{
				for (int iter = debIter; iter < finIter; iter++)
				{
					this.terrain[coordLong,iter,coordHaut] = new DecorStatique(objAPlacer);
				}	
			}
			// Les objets à placer sont sur l'axe de la profondeur.
			else if (deplac == 'Z')
			{
				for (int iter = debIter; iter < finIter; iter++)
				{
					this.terrain[coordLong,coordLarg,iter] = new DecorStatique(objAPlacer);
				}	
			}
		}
	}
}
