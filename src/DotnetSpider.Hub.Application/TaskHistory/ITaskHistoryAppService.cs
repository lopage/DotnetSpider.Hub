﻿using DotnetSpider.Hub.Application.TaskHistory.Dtos;
using DotnetSpider.Hub.Core;

namespace DotnetSpider.Hub.Application.TaskHistory
{
	public interface ITaskHistoryAppService
	{
		PaginationQueryDto Query(PaginationQueryTaskHistoryInput input);
		void Add(AddTaskHistoryInput taskHistory);
	}
}
