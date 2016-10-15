using System;

namespace QFL
{
	public class DecorStatique : ObjetsTerrain
	{
		/* 'limite';    Limites du terrain.
		 * 'poteau';    Poteaux de but.
		 * 'but';       Cercles de but.
		 * 'enbut';     Ligne d'en but.
		 * 'mediane';   S�paration m�diane.
		 * 'centre';    Centre du terrain. */
		
		public String typeDecor;
		
		public DecorStatique(String typeDec)
		{
			this.typeDecor = typeDec;
		}
	}
}
