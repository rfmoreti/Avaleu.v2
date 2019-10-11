using Avaleu.Dao;
using Avaleu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaleu.Services
{
	public class AvaliacaoService : GenericService<Avaliacao>
	{
		public AvaliacaoService(DataContext context) : base(context)
		{

		}
	}
}
