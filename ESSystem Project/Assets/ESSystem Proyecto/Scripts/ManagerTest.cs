//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ManagerTest.cs (30/05/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control de las variables									\\
// Fecha Mod:		30/05/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace MoonAntonio
{
	public class ManagerTest : MonoBehaviour 
	{
		#region Variables
		public int vida;
		public int mana;

		public bool isAtaque;

		public Text txtVida;
		public Text txtMana;
		public Toggle atack;
		#endregion

		#region Actualizador
		private void Update()
		{
			txtVida.text = "Vida: " + vida.ToString();
			txtMana.text = "Mana: " + mana.ToString();
			if (isAtaque) atack.isOn = true;
			else atack.isOn = false;
		}
		#endregion
	}
}
