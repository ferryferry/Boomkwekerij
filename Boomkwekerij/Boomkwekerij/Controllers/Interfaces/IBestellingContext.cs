using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Interfaces
{
	public interface IBestellingContext : IContext<Bestelling>
	{
		bool Remove(Bestelregel entity);
		bool Remove(Levering entity);
	}
}
