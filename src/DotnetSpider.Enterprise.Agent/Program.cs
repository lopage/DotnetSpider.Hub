﻿namespace DotnetSpider.Enterprise.Agent
{
	public class Program
	{
		static void Main(string[] args)
		{
			var agent = new AgentClient();
			agent.Run();
		}
	}
}
