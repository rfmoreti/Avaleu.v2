﻿using Avaleu.Dao;
using Avaleu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaleu.Services
{
	public class TimeService : GenericService<Time>
	{
		public TimeService(DataContext context) : base(context)
		{

		}
	}
}
