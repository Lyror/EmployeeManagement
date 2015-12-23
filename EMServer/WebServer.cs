using acadGraph.Libs.RpcWebLib;
using acadGraph.Libs.RpcWebLib.HttpServerWrapper;
using HttpServer;
using HttpServer.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EMServer
{
	internal class WebServer
	{
		internal String ConnectionString { get; set; }

		private static HttpServer.HttpServer core;

		internal void Start()
		{
			core = GetCore();
			core.Start(IPAddress.Any, 8081);
		}

		internal void Stop()
		{
			core = GetCore();
			core.Stop();
		}

		internal HttpServer.HttpServer GetCore()
		{
			if(core == null)
			{
				// create my dispatcher module
				var testModule = new DispatcherModule(GetClassList());

				// create session handling
				var customComponents = new ComponentProvider();
				var sessionStore = new MemorySessionStore();
				sessionStore.ExpireTime = 5;

				customComponents.AddInstance<IHttpSessionStore>(sessionStore);

				core = new HttpServer.HttpServer(customComponents);
				core.Add(new HttpModuleWrapper(testModule));
			}
			return core;
		}
		
		internal List<SimpleWebServiceDescriptor> GetClassList()
		{
			return new List<SimpleWebServiceDescriptor>()
			{
				new SimpleWebServiceDescriptor("Test", new SQL.EmployeeSQL(ConnectionString))
			};
		}
	}
}
