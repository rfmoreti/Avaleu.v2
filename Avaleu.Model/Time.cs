using Avaleu.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Avaleu.Model
{
	public class Time : GenericModel
	{
		[Required, StringLength(30)]
		public string Nome{ get; set; }
		
		//[ForeignKey("Student")]
		//public int StudentID { get; set; }
		//public virtual User Student{ get; set; }

		public virtual IList<Usuario> Alunos{ get; set; }
		public virtual IList<Projeto> Projetos { get; set; }
	}
}
