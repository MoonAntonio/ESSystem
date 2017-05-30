//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// SimpleCarga.cs (30/05/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Ejemplo Carga simple										\\
// Fecha Mod:		30/05/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Ejemplo Carga simple</para>
	/// </summary>
	public class SimpleCarga : MonoBehaviour 
	{
		#region Variables
		/// <summary>
		/// <para>Manager de la escena</para>
		/// </summary>
		public GameObject manager;                                          // Manager de la escena
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Carga los datos</para>
		/// </summary>
		public void Cargar()// Carga los datos
		{
			// Accedemos al manager
			ManagerTest script = manager.GetComponent<ManagerTest>();

			// Cargamos el valor de vida con el nombre vida
			script.vida = ES2.Load<int>("vida");

			// Guardamos el valor de mana con el nombre mana
			script.mana = ES2.Load<int>("mana");

			// Guardamos el valor de isAtaque con el nombre atack
			script.isAtaque = ES2.Load<bool>("atack");
		}
		#endregion
	}
}
