using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Exceptions
{
	public class DatabaseCouldNotBeFoundException : Exception
	{
		public DatabaseCouldNotBeFoundException(string message) : base(message)
		{

		}
	}
}
