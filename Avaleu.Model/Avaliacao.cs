using Avaleu.Model.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avaleu.Model
{
	public class Avaliacao : GenericModel
	{
		[ForeignKey("Projeto")]
		public int CodigoProjeto { get; set; }
		public virtual Projeto Projeto { get; set; }

		[ForeignKey("Professor")]
		public int CodigoProfessor { get; set; }
		public virtual Usuario Professor { get; set; }

		[DataType(DataType.MultilineText)]
		public string Comentario { get; set; }

		[Required, StringLength(20)]
		//Pedro quis colocar rating
		public string Situacao { get; set; }
	}
}
