using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace portfolio
{
	public class OGItemProject
	{
		OGIRestService restService;

		public TodoItemManager(OGIRestService service)
		{
			restService = service;
		}

		public Task<List<OGItemProject>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

		public Task SaveTaskAsync(OGItemProject item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync(item, isNewItem);
		}

		public Task DeleteTaskAsync(OGItemProject item)
		{
			return restService.DeleteTodoItemAsync(item.ID);
		}
	}
}

