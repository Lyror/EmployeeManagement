using acadGraph.Libs.RpcWebLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.Services
{
	class EMWebService : IWebService
	{
		[WebMethod]
		public string Echo(string text)
		{
			return text;
		}
	}
}
