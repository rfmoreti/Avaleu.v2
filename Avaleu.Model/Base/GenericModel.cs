using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Avaleu.Model.Base
{
	public class GenericModel : IGenericModel
	{
		[Key]
		public int Id { get; set; }

		public bool Ativo { get; set; }
		
	}
}
