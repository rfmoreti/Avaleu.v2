using Avaleu.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Avaleu.Model
{
	public class Projeto : GenericModel
	{
		[Required, StringLength(30)]		
		public string ProjectName { get; set; }

		[Required, DataType(DataType.MultilineText)]
		public string Descricao { get; set; }

		[ForeignKey("Time")]
		public int CodigoTime { get; set; }

		public virtual Time Time { get; set; }

		[StringLength(300)]
		public string Arquivo { get; set; }

		public DateTime DataLimite { get; set; }

		public DateTime DataPostagem { get; set; }

		public virtual IList<Avaliacao> Avaliacoes { get; set; }
	}
}
