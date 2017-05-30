//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// SimpleGuardado.cs (30/05/2017)												\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Ejemplo Guardado simple										\\
// Fecha Mod:		30/05/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Ejemplo Guardado simple</para>
	/// </summary>
	public class SimpleGuardado : MonoBehaviour 
	{
		#region Variables
		/// <summary>
		/// <para>Manager de la escena</para>
		/// </summary>
		public GameObject manager;											// Manager de la escena
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Guarda los datos</para>
		/// </summary>
		public void Guardar()// Guarda los datos
		{
			// Accedemos al manager
			ManagerTest script = manager.GetComponent<ManagerTest>();

			// Guardamos el valor de vida con el nombre vida
			ES2.Save(script.vida, "vida");

			// Guardamos el valor de mana con el nombre mana
			ES2.Save(script.mana, "mana");

			// Guardamos el valor de isAtaque con el nombre atack
			ES2.Save(script.isAtaque, "atack");
		}
		#endregion
	}
}
