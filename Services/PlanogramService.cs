using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class PlanogramService : IPlanogramService
    {
        private readonly IAsyncRepositoryLong<Part> _partRepository;
        private readonly IAsyncRepositoryLong<Planogram> _planogramRepository;
        private readonly IPartRepository _partRepositorySync;
        private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IAsyncRepositoryLong<PlanogramShelf> _planogramShelfRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public PlanogramService(IAsyncRepositoryLong<Part> partRepository, IPartRepository partRepositorySync, IAsyncRepositoryLong<Planogram> planogramRepository, IAsyncRepositoryLong<PlanogramPart> planogramPartRepository, IMapper mapper, ILogger<PartService> logger, IAsyncRepositoryLong<PlanogramShelf> planogramShelfRepository)
        {
            _partRepository = partRepository;
            _partRepositorySync = partRepositorySync;
            _planogramRepository = planogramRepository;
            _planogramPartRepository = planogramPartRepository;
            _mapper = mapper;
            _logger = logger;
            _planogramShelfRepository = planogramShelfRepository;
        }

        public async Task<IEnumerable<Planogram>> GetPlanograms(PlanogramFilter filter)
        {
            try
            {
                var spec = new PlanogramSpecification(filter);
                var planograms = await _planogramRepository.ListAsync(spec);
                return planograms;

            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new NotImplementedException("Method not implemented yet.", ex);
            }
        }


        public async Task<Planogram> GetPlanogram(long id)
        {
            try
            {
                return await _planogramRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error getting planogram: " + ex.Message);
                throw;
            }
        }


        public Task<IEnumerable<PlanogramLock>> GetLockedPlanograms()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanogramNote> GetPlanogramNotes(string userId, int brandId, int countryId, int regionId, int planogramID)
        {
            throw new NotImplementedException();
        }


        public void CreatePlanogram(Planogram planogram)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogram(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsLocked(int id, CurrentUser user)
        {
            throw new NotImplementedException();
        }

        public void SavePlanogram()
        {
            throw new NotImplementedException();
        }

        public PlanogramNote GetNote(long noteId)
        {
            throw new NotImplementedException();
        }

        public void CreatePlanogramNote(PlanogramNote planogramNote)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogramNote(int id)
        {
            throw new NotImplementedException();
        }

        public void SavePlanogramNote()
        {
            throw new NotImplementedException();
        }

        public ScratchPad GetScratchPad(int scratchPadId)
        {
            throw new NotImplementedException();
        }

        public void CreateScratchPad(ScratchPad scratchPad)
        {
            throw new NotImplementedException();
        }

        public void DeleteScratchPad(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveScratchPad()
        {
            throw new NotImplementedException();
        }

        public PlanogramShelf GetPlanogramShelf(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanogramShelf> GetPlanogramShelves(int planogramId)
        {
            throw new NotImplementedException();
        }

        public void CreatePlanogramShelf(PlanogramShelf shelf)
        {
            throw new NotImplementedException();
        }

        public async Task DeletePlanogramShelf(long id)
        {
            var shelf = await _planogramShelfRepository.GetByIdAsync(id);
            if (shelf != null)
            {
                await _planogramShelfRepository.DeleteAsync(shelf);
                SavePlanogramShelf();
            }
        }

        public void SavePlanogramShelf()
        {
            throw new NotImplementedException();
        }

        public PlanogramPart GetPlanogramPart(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<PlanogramPart>> GetPlanogramParts(PlanogramPartFilter filter)
        {
            var spec = new PlanogramPartFilterSpecification(filter);
            var parts = await _planogramPartRepository.ListAsync(spec);
            return parts;
        }

        public void CreatePlanogramPart(PlanogramPart part)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogramPart(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeletePlanogramPart(long id)
        {
            var part = await _planogramPartRepository.GetByIdAsync(id);
            await _planogramPartRepository.DeleteAsync(part);
            SavePlanogramPart();
        }

        public void SavePlanogramPart()
        {
            throw new NotImplementedException();
        }

        public PlanogramPartFacing GetPlanogramPartFacing(long id)
        {
            throw new NotImplementedException();
        }

        public void CreatePlanogramPartFacing(PlanogramPartFacing partFacing)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogramPartFacing(long id)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogramPartFacing(int id)
        {
            throw new NotImplementedException();
        }

        public void SavePlanogramPartFacing()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanogramPartFacing> GetPlanogramPartFacings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PartFacingDto> GetPlanogramPartFacings(int ppartId)
        {
            throw new NotImplementedException();
        }

        public PlanogramStatus GetPlanogramStatus(int id)
        {
            throw new NotImplementedException();
        }


        public void CreatePlanogramPartFactice(PlanogramPart part)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanogramPartFactice(int id)
        {
            throw new NotImplementedException();
        }

        public void SavePlanogramPartFactice()
        {
            throw new NotImplementedException();
        }
    }
}
