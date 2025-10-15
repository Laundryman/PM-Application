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
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;
        public JobService(IJobRepository jobRepository, IMapper mapper, ILogger<PartService> logger)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
            _logger = logger;
        }

       public Task<IReadOnlyList<Job>> GetJobs(JobFilter filter)
        {
            var spec = new JobSpecification(filter);
            var jobs = _jobRepository.ListAsync(spec);
            return jobs;
        }

        public Task<IReadOnlyList<JobInfo>> GetFilteredJobs(int? page, int? pageSize, string sortBy, string sortOrder, string searchString, int? brandId)
        {
            var jobs = _jobRepository.GetFilteredJobs(page, pageSize, sortBy, sortOrder, searchString, brandId);
            return jobs;
        }
        public Task<IReadOnlyList<JobInfo>> GetJobFolderJobs(int jobFolderId)
        {
            var jobs = _jobRepository.GetJobFolderJobs(jobFolderId);
            return jobs;
        }

        public Task<Job> GetJob(int id)
        {
            var job = _jobRepository.GetByIdAsync(id);
            return job;
        }

        public Task CreateJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveJob()
        {
            throw new NotImplementedException();
        }
    }
}
