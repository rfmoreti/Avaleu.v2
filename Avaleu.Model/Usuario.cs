using Avaleu.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Avaleu.Model
{
	public class Usuario : GenericModel
	{
		[Required, StringLength(50)]
		public string Nome { get; set; }

		[Required, StringLength(100), DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required, StringLength(32), DataType(DataType.Password)]
		public string Senha { get; set; }

		[DataType(DataType.PhoneNumber), StringLength(20)]
		public string Telefone { get; set; }

		public bool Professor { get; set; }

		[ForeignKey("Time")]
		public int? CodigoTime { get; set; }

		public virtual Time Time { get; set; }

		public virtual IList<Avaliacao> Avaliacoes { get; set; }

		public Usuario()
		{
			Ativo = true;
		}
	}
}
