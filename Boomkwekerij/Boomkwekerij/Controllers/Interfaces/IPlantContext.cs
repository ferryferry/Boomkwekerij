using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Interfaces
{
	public interface IPlantContext : IContext<Plant>
	{
		bool Update(Voorraad entity);
	}
}
