using acadGraph.Libs.RpcWebLib;
using acadGraph.Libs.RpcWebLib.Services;
using HttpServer.HttpModules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer
{
	public class DispatcherModule : IHttpModule
	{
		public static string BASE_DIR;

		acadGraph.Libs.RpcWebLib.FileModule frontendModule;

		RpcModule rpcModule;

		static DispatcherModule()
		{
			var uri = new Uri(typeof(DispatcherModule).Assembly.CodeBase);
			BASE_DIR = Path.GetDirectoryName(uri.LocalPath);
		}


		public DispatcherModule(List<SimpleWebServiceDescriptor> classList)
		{

			frontendModule = new acadGraph.Libs.RpcWebLib.FileModule("/RpcTest", Path.Combine(BASE_DIR, "RpcTest"));
			frontendModule.AddDefaultMimeTypes();

			var serviceFactory = new WebServiceFactory();

			var webServices = new List<IWebServiceDescriptor>()
			{
				//new SimpleWebServiceDescriptor("qooxdoo.test", new HelloWorld()),
				new SimpleWebServiceDescriptor("EventService", new EventService()),
				new SimpleWebServiceDescriptor("Publisher", new PublisherService()),
				new SimpleWebServiceDescriptor("EMWebService", new Services.EMWebService())
			};

			webServices.AddRange(classList);

			serviceFactory.InitWebServices(webServices);

			rpcModule = new RpcModule("/rpc", serviceFactory);
		}

		public bool Process(IHttpRequest request, IHttpResponse response, IHttpSession session)
		{

			bool handled = false;

			if (!handled)
			{
				handled = rpcModule.Process(request, response, session);
			}

			if (!handled)
			{
				handled = frontendModule.Process(request, response, session);
			}

			if (!handled)
			{

				StreamWriter writer = new StreamWriter(response.Body);
				writer.Write("<html>\n<head>\n");
				writer.Write("<title>" + "Page not found" + "</title>\n");
				writer.Write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n");
				writer.Write("</head>\n");
				writer.Write("<body>\n<h2>Page not found</h2>\n");

				writer.Write("\n</body>\n</html>\n");
				writer.Flush();

				handled = true;
			}
			return handled;
		}
	}
}
