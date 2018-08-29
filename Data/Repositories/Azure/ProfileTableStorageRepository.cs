using AzureStorageService;
using DomainModel.Entities;
using DomainModel.Interfaces.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Azure
{
    public class ProfileTableStorageRepository : IProfileRepositories
    {
        private TableService _tableService = new TableService(); 

        void IProfileRepositories.Create(Profile profile)
        {
            throw new NotImplementedException();
        }

        Profile IProfileRepositories.Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}