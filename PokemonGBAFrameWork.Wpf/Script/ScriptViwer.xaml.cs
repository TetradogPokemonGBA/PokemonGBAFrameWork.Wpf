/*
 * Creado por SharpDevelop.
 * Usuario: Pikachu240
 * Fecha: 10/11/2017
 * Hora: 15:54
 * Licencia GNU GPL V3
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using PokemonGBAFrameWork;
namespace PokemonGBAFrameWork.Wpf
{
	/// <summary>
	/// Interaction logic for ScriptViwer.xaml
	/// </summary>
	public partial class ScriptViwer : UserControl
	{
		
		Script script;
		
		public event EventHandler GuardarScript;
		public ScriptViwer(Script script=null)
		{
			if(script==null)
				script=new Script();
			
			InitializeComponent();
			Script=script;
		}

		public Script Script {
			get {
				return script;
			}
			set {
				script = value;
				Refresh();
			}
		}
		public void Refresh()
		{
			//cargo el script
		}
	}
}