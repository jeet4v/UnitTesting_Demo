using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class DataService
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public DataService(IRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public string ProcessData(int id)
        {
            var data = _repository.GetData(id);

            if (string.IsNullOrEmpty(data))
            {
                _logger.Log($"No data found for id {id}");
                return "No Data";
            }

            _logger.Log($"Data found: {data}");
            return $"Processed: {data}";
        }
    }
}
