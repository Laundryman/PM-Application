using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces.RepositoryInterfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class JobFolderService : IJobFolderService
    {
        private readonly IJobFolderRepository _jobFolderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<JobFolderService> _logger;
        public JobFolderService(IJobFolderRepository jobFolderRepository, IMapper mapper, ILogger<JobFolderService> logger)
        {
            _jobFolderRepository = jobFolderRepository;
            _mapper = mapper;
            _logger = logger;
        }

       public Task<IReadOnlyList<JobFolder>> GetJobFolders(JobFolderFilter filter)
        {
            var spec = new JobFolderSpecification(filter);
            var jobFolders = _jobFolderRepository.ListAsync(spec);
            return jobFolders;
        }

        public Task<IReadOnlyList<JobFolderInfo>> GetJobFolderInfos(JobFolderFilter filter)
        {
            var jobFolders = _jobFolderRepository.GetJobFolderInfos(filter);
            return jobFolders;
        }

        public Task<IReadOnlyList<JobFolderInfo>> GetFilteredJobFolders(int? page, int? pageSize, string sortBy, string sortOrder, string searchString, int? brandId)
        {
            var jobs = _jobFolderRepository.GetFilteredJobFolders(page, pageSize, sortBy, sortOrder, searchString, brandId);
            return jobs;
        }

        public Task<JobFolder> GetJobFolder(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateJobFolder(JobFolder jobFolder)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJobFolder(string id)
        {
            throw new NotImplementedException();
        }

        public Task SaveJobFolder()
        {
            throw new NotImplementedException();
        }


        public Task<JobFolder> GetJob(int id)
        {
            var jobFolder = _jobFolderRepository.GetByIdAsync(id);
            return jobFolder;
        }

    }
}
