using Avaleu.Dao;
using Avaleu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaleu.Services
{
	class ProjetoService : GenericService<Projeto>
	{
		public ProjetoService(DataContext context) : base(context)
		{

		}
	}
}
