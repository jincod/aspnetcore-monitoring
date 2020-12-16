using System;
using System.Collections.Generic;
using Serilog.Sinks.Loki.Labels;

namespace web
{
	public class LogLabelProvider : DefaultLogLabelProvider
	{
		public LogLabelProvider(string appName)
			: base(new List<LokiLabel>
			{
				new LokiLabel("app", appName),
				new LokiLabel("environment", Environment.GetEnvironmentVariable("APP_ENVIRONMENT") ?? "development")
			})
		{
		}
	}
}
