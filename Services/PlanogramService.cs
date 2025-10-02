using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models;
using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Enums;
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
        private readonly IPlanogramRepository _planogramRepositorySync;
        private readonly IAsyncRepositoryLong<Cluster> _clusterRepository;
        private readonly IAsyncRepositoryLong<ScratchPad> _scratchPadRepository;
        private readonly IPartRepository _partRepositorySync;
        private readonly IAsyncRepositoryLong<PlanogramPart> _planogramPartRepository;
        private readonly IAsyncRepositoryLong<PlanogramShelf> _planogramShelfRepository;
        private readonly IAsyncRepositoryLong<PlanogramNote> _noteRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public PlanogramService(IAsyncRepositoryLong<Part> partRepository, IPartRepository partRepositorySync, IAsyncRepositoryLong<Planogram> planogramRepository, IAsyncRepositoryLong<PlanogramPart> planogramPartRepository, IMapper mapper, ILogger<PartService> logger, IAsyncRepositoryLong<PlanogramShelf> planogramShelfRepository, IAsyncRepositoryLong<Cluster> clusterRepository, IAsyncRepositoryLong<PlanogramNote> planogramNoteRepository, IAsyncRepositoryLong<ScratchPad> scratchPadRepository)
        {
            _partRepository = partRepository;
            _partRepositorySync = partRepositorySync;
            _planogramRepository = planogramRepository;
            _planogramPartRepository = planogramPartRepository;
            _mapper = mapper;
            _logger = logger;
            _planogramShelfRepository = planogramShelfRepository;
            _clusterRepository = clusterRepository;
            _scratchPadRepository = scratchPadRepository;
            _noteRepository = planogramNoteRepository;
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

        public async Task<IReadOnlyList<Sku>> GetSkuList(long id, string userId, bool hasColumns)
        {
            var skus = await _planogramRepositorySync.GetSkuList(id, userId, hasColumns);
        }


        public async Task<long> CreatePlanogramFromCluster(int clusterId, string name, CurrentUser userInfo)
        {
            Cluster cluster = await _clusterRepository.GetByIdAsync(clusterId);

            Planogram planogram = new Planogram();

            planogram.Cluster = cluster;
            planogram.ClusterId = cluster.Id;
            planogram.CurrentVersion = 1;
            planogram.DateCreated = DateTime.Now;
            planogram.DateUpdated = DateTime.Now;
            planogram.DateSubmitted = null;
            planogram.Name = name;
            planogram.Stand = cluster.Stand;
            planogram.StandId = cluster.Stand.Id;
            //planogram.Status = 1;
            planogram.StatusId = 1;
            planogram.Template = false; //this is not a template (yet at least)
            planogram.UserId = userInfo.Id;
            planogram.CountryId = userInfo.DiamCountryId;
            planogram.UserName = userInfo.DisplayName;
            planogram.LubName = userInfo.GivenName + " " + userInfo.Surname;
            planogram.LastUpdatedBy = userInfo.Id;
            //planogram.CountryId = (int)oauthService.GetUserProfile(userId).CountryId;

            CreatePlanogram(planogram);

            //Add Shelves
            foreach (ClusterShelf shelf in cluster.ClusterShelves)
            {
                PlanogramShelf pShelf = new PlanogramShelf();
                pShelf.Column = shelf.Column;
                pShelf.Height = shelf.Height;
                pShelf.PositionX = shelf.PositionX;
                pShelf.PositionY = shelf.PositionY;
                pShelf.Row = shelf.Row;
                pShelf.Width = shelf.Width;
                pShelf.Planogram = planogram;
                pShelf.PlanogramId = planogram.Id;
                pShelf.Part = shelf.Part;

                pShelf.ShelfTypeId = shelf.Part.PartType.Id;
                CreatePlanogramShelf(pShelf);
            }

            //Add Promos > now accessories

            foreach (ClusterPart part in cluster.ClusterParts)
            {
                PlanogramPart pPart = new PlanogramPart();
                pPart.Part = part.Part;
                pPart.PlanogramId = planogram.Id;
                pPart.PositionX = part.PositionX;
                pPart.PositionY = part.PositionY;
                pPart.Part = part.Part;
                CreatePlanogramPart(pPart);


            }


            SavePlanogram(planogram);
            return planogram.Id;
        }

        public async Task<long> ClonePlanogram(int planogramId, string name, CurrentUser userProfile)
        {
            var newPlanoId = await ClonePlanogram(planogramId, name, userProfile, false);
            return newPlanoId;
        }

        public async Task<long> ClonePlanogram(int planogramId, string name, CurrentUser userProfile, bool isUpdate)
        {
            Planogram originalPlanogram = await _planogramRepository.GetByIdAsync(planogramId);

            Planogram newPlanogram = new Planogram();

            newPlanogram.Cluster = originalPlanogram.Cluster;
            newPlanogram.ClusterId = originalPlanogram.ClusterId;
            newPlanogram.CurrentVersion = 1;
            newPlanogram.DateCreated = DateTime.Now;
            newPlanogram.DateUpdated = DateTime.Now;
            newPlanogram.DateSubmitted = null;
            newPlanogram.Name = name;
            newPlanogram.Stand = originalPlanogram.Stand;
            newPlanogram.StandId = originalPlanogram.StandId;
            newPlanogram.StatusId = 1;
            newPlanogram.Template = false; //this is not a template (yet at least)
            newPlanogram.UserId = userProfile.Id;
            newPlanogram.LastUpdatedBy = userProfile.Id;
            newPlanogram.UserName = userProfile.DisplayName;
            newPlanogram.LubName = userProfile.GivenName + " " + userProfile.Surname;
            var countryId = userProfile.DiamCountryId;
            var regionId = 1;
            //var userProfile = oauthService.GetUserProfile(userId);
            newPlanogram.CountryId = countryId; // userProfile.CountryId;
            //await CreatePlanogram(newPlanogram);
            await _planogramRepository.AddAsync(newPlanogram);

            try
            {
                if (isUpdate)
                {
                    DuplicatePlanogramNotes(userProfile.Id, originalPlanogram.Stand.BrandId, newPlanogram.CountryId ?? 0,
                        regionId, planogramId, newPlanogram.Id);
                }
            }
            catch (Exception ex)
            {

            }
            var scratchPadId = originalPlanogram.ScratchPadId;
            if (isUpdate & scratchPadId != null)
            {
                //we need to clone the scratchpad too.
                scratchPadId = await CloneScratchPad(originalPlanogram.Id, newPlanogram.Id);
            }

            //NEED TO HANDLE PLANOGRAMS THAT HAVE NO SHELVES
            if ((originalPlanogram.Stand.standType.ParentStandTypeId == (int)StandTypeEnum.Bergerie) || (originalPlanogram.Stand.standType.ParentStandTypeId == (int)StandTypeEnum.NEO))
            {
                foreach (PlanogramPart part in originalPlanogram.PlanogramParts)
                {
                    if ((PartTypeEnum)part.Part.PartType.Id != PartTypeEnum.Accessory && part.ScratchPadId == null)
                    {
                        PlanogramPart newPart = new PlanogramPart();
                        newPart.Part = part.Part;
                        newPart.PlanogramId = newPlanogram.Id;
                        //newPart.PlanogramShelf = newShelf;
                        //newPart.PlanogramShelfId = newShelf.PlanogramShelfId;
                        newPart.PositionX = part.PositionX;
                        newPart.PositionY = part.PositionY;
                        newPart.Products = part.Products;
                        newPart.DateUpdated = DateTime.Now;
                        newPart.DateCreated = DateTime.Now;
                        newPart.PartStatusId = (int)PlanoItemStatusEnum.NotChanged;
                        if (isUpdate)
                        {
                            newPart.PartStatusId = part.PartStatusId;
                            newPart.Notes = part.Notes;
                            if (newPart.PositionX == 0 && newPart.PositionY == 0)
                            {
                                newPart.ScratchPadId = scratchPadId;
                            }
                        }

                        CreatePlanogramPart(newPart);
                        foreach (PlanogramPartFacing partFacing in part.PlanogramPartFacings)
                        {
                            PlanogramPartFacing newPartFacing = new PlanogramPartFacing();
                            newPartFacing.PlanogramId = newPlanogram.Id;
                            newPartFacing.PlanogramPart = newPart;
                            newPartFacing.Position = partFacing.Position;
                            newPartFacing.ProductId = partFacing.ProductId;
                            newPartFacing.Shade = partFacing.Shade;
                            newPartFacing.StockCount = partFacing.StockCount;
                            newPartFacing.FacingStatusId = (int)PlanoItemStatusEnum.NotChanged;

                            if (isUpdate)
                            {
                                newPartFacing.FacingStatusId = partFacing.FacingStatusId;
                            }
                            CreatePlanogramPartFacing(newPartFacing);
                            newPart.PlanogramPartFacings.Add(newPartFacing);
                        }
                        SavePlanogramPart();
                    }
                }

            }
            else
            {

                //Add Shelves
                foreach (PlanogramShelf shelf in originalPlanogram.PlanogramShelves.Where(ps => ps.ScratchPadId == null || ps.ScratchPadId == 0))
                {
                    PlanogramShelf newShelf = new PlanogramShelf();
                    newShelf.Column = shelf.Column;
                    newShelf.Height = shelf.Height;
                    newShelf.PositionX = shelf.PositionX;
                    newShelf.PositionY = shelf.PositionY;
                    newShelf.Row = shelf.Row;
                    newShelf.Width = shelf.Width;
                    newShelf.Planogram = newPlanogram;
                    newShelf.PlanogramId = newPlanogram.Id;
                    newShelf.Part = shelf.Part;
                    newShelf.Label = shelf.Label;
                    newShelf.ShelfTypeId = shelf.ShelfTypeId;
                    newShelf.PartStatusId = (int)PlanoItemStatusEnum.NotChanged;
                    if (isUpdate)
                    {
                        newShelf.PartStatusId = shelf.PartStatusId;
                    }
                    CreatePlanogramShelf(newShelf);

                    foreach (PlanogramPart part in shelf.PlanogramParts)
                    {
                        PlanogramPart newPart = new PlanogramPart();
                        newPart.Part = part.Part;
                        newPart.PlanogramId = newPlanogram.Id;
                        newPart.PlanogramShelf = newShelf;
                        newPart.PlanogramShelfId = newShelf.Id;
                        newPart.PositionX = part.PositionX;
                        newPart.PositionY = part.PositionY;
                        newPart.Products = part.Products;
                        newPart.DateUpdated = DateTime.Now;
                        newPart.DateCreated = DateTime.Now;
                        newPart.PartStatusId = (int)PlanoItemStatusEnum.NotChanged;
                        //here if a bool val set to update save it or if not don't save it.
                        if (isUpdate)
                        {
                            newPart.PartStatusId = part.PartStatusId;
                            newPart.Notes = part.Notes;
                        }
                        CreatePlanogramPart(newPart);
                        foreach (PlanogramPartFacing partFacing in part.PlanogramPartFacings)
                        {
                            PlanogramPartFacing newPartFacing = new PlanogramPartFacing();
                            newPartFacing.PlanogramId = newPlanogram.Id;
                            newPartFacing.PlanogramPart = newPart;
                            newPartFacing.Position = partFacing.Position;
                            newPartFacing.ProductId = partFacing.ProductId;
                            newPartFacing.Shade = partFacing.Shade;
                            newPartFacing.StockCount = partFacing.StockCount;
                            newPartFacing.FacingStatusId = (int)PlanoItemStatusEnum.NotChanged;
                            if (isUpdate)
                            {
                                newPartFacing.FacingStatusId = partFacing.FacingStatusId;
                            }
                            CreatePlanogramPartFacing(newPartFacing);
                            newPart.PlanogramPartFacings.Add(newPartFacing);
                        }
                        SavePlanogramPart();
                        newShelf.PlanogramParts.Add(newPart);
                    }
                }
            }
            //Add Promos > Now Accessories

            foreach (PlanogramPart part in originalPlanogram.PlanogramParts)
            {
                if ((PartTypeEnum)part.Part.PartType.Id == PartTypeEnum.Accessory && part.ScratchPadId == null ||
                    (PartTypeEnum)part.Part.PartType.Id == PartTypeEnum.Glorifier && part.ScratchPadId == null ||
                    (PartTypeEnum)part.Part.PartType.Id == PartTypeEnum.Blanking && (part.ScratchPadId == null && part.PlanogramShelfId == null))
                {
                    PlanogramPart accessoryPart = new PlanogramPart();
                    accessoryPart.Part = part.Part;
                    accessoryPart.PlanogramId = newPlanogram.Id;
                    accessoryPart.PositionX = part.PositionX;
                    accessoryPart.PositionY = part.PositionY;
                    accessoryPart.DateUpdated = DateTime.Now;
                    accessoryPart.DateCreated = DateTime.Now;
                    accessoryPart.Label = part.Label ?? "";
                    accessoryPart.PartStatusId = (int)PlanoItemStatusEnum.NotChanged;

                    if (isUpdate)
                    {
                        accessoryPart.PartStatusId = part.PartStatusId;
                        accessoryPart.Notes = part.Notes;
                    }
                    CreatePlanogramPart(accessoryPart);
                }

            }

            SavePlanogram(newPlanogram);

            // considered placing the clone snapshots call in here, decided against it as its not strictly a data operation - MB
            // instead, cloning is called from the UI, e.g. planogramsInProgress.ascx.cs : btnSaveAsTemplate_Click()

            return newPlanogram.Id;

        }


        public async Task CreatePlanogram(Planogram planogram)
        {
            try
            {
                await _planogramRepository.AddAsync(planogram);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError("Error creating planogram: " + ex.Message);
                throw;
            }
        }

        public void DeletePlanogram(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsLocked(long id, CurrentUser user)
        {
            throw new NotImplementedException();
        }

        public void SavePlanogram(Planogram planogram)
        {
            _planogramRepository.UpdateAsync(planogram);
        }

        public PlanogramNote GetNote(long noteId)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<PlanogramNote>> IPlanogramService.GetPlanogramNotes(string userId, int brandId, int countryId, int regionId, long planogramId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<PlanogramNote>> DuplicatePlanogramNotes(string userId, int brandId, int countryId, int regionId, int planogramId,
            long newPlanogramId)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<PlanogramNote>> DuplicatePlanogramNotes(string userId, int brandId, int countryId, int regionId, long planogramId,
            long newPlanogramId)
        {
            var noteFilter = new NoteFilter();
            noteFilter.PlanogramId = planogramId;
            var spec = new NoteSpecification(noteFilter);
            var planogramNotes = await _noteRepository.ListAsync(spec);

            List<PlanogramNote> newNotes = new List<PlanogramNote>();
            foreach (var note in planogramNotes)
            {
                newNotes.Add(new PlanogramNote()
                {

                    Note = note.Note,
                    NoteDate = note.NoteDate,
                    NoteInReplyTo = note.NoteInReplyTo,
                    NoteTitle = note.NoteTitle,
                    PlanogramId = newPlanogramId,
                    UserId = note.UserId
                });
            }
            foreach (var note in newNotes)
            {
                CreatePlanogramNote(note);
            }

            return planogramNotes;
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

        #region scratchpad

        /// <summary>
        /// Original Clone scratchpad call.
        /// It creates a copy of an existing scratchpad based on the original planogram being cloned.
        /// </summary>
        /// <param name="planogramId"></param>
        /// <param name="newPlanogramId"></param>
        /// <returns>the new scratch pad Id</returns>
        public async Task<long> CloneScratchPad(long planogramId, long newPlanogramId)
        {
            var OriginalPlanogram = await GetPlanogram(planogramId);
            var newPlanogram = await GetPlanogram(newPlanogramId);
            var newScratchPad = new ScratchPad();
            var originalScratchPad = OriginalPlanogram.ScratchPad;

            newScratchPad.DateCreated = DateTime.Now;
            newScratchPad.DateUpdated = DateTime.Now;
            CreateScratchPad(newScratchPad);
            newPlanogram.ScratchPadId = newScratchPad.Id;
            newPlanogram.ScratchPad = newScratchPad;
            //add parts
            foreach (PlanogramPart part in originalScratchPad.PlanogramParts)
            {
                if ((PartTypeEnum)part.Part.PartType.Id != PartTypeEnum.Accessory)
                {
                    PlanogramPart newPart = new PlanogramPart();
                    newPart.Part = part.Part;
                    newPart.ScratchPadId = newScratchPad.Id;
                    newPart.PlanogramId = newPlanogramId;
                    //newPart.PlanogramShelf = newShelf;
                    //newPart.PlanogramShelfId = newShelf.PlanogramShelfId;
                    newPart.PositionX = part.PositionX;
                    newPart.PositionY = part.PositionY;
                    newPart.Products = part.Products;
                    newPart.PartStatusId = part.PartStatusId;
                    newPart.Notes = part.Notes;
                    newPart.DateUpdated = DateTime.Now;
                    newPart.DateCreated = DateTime.Now;
                    newPart.Label = part.Label;

                    CreatePlanogramPart(newPart);
                    foreach (PlanogramPartFacing partFacing in part.PlanogramPartFacings)
                    {
                        PlanogramPartFacing newPartFacing = new PlanogramPartFacing();
                        newPartFacing.PlanogramId = newPlanogramId;
                        newPartFacing.PlanogramPart = newPart;
                        newPartFacing.Position = partFacing.Position;
                        newPartFacing.ProductId = partFacing.ProductId;
                        newPartFacing.Shade = partFacing.Shade;
                        newPartFacing.StockCount = partFacing.StockCount;
                        newPartFacing.FacingStatusId = partFacing.FacingStatusId;
                        CreatePlanogramPartFacing(newPartFacing);
                        newPart.PlanogramPartFacings.Add(newPartFacing);
                    }
                    SavePlanogramPart();
                }
                else if ((PartTypeEnum)part.Part.PartType.Id == PartTypeEnum.Accessory)
                {
                    PlanogramPart accessoryPart = new PlanogramPart();
                    accessoryPart.Part = part.Part;
                    accessoryPart.PlanogramId = newPlanogramId;
                    accessoryPart.ScratchPadId = newScratchPad.Id;
                    accessoryPart.PositionX = part.PositionX;
                    accessoryPart.PositionY = part.PositionY;
                    accessoryPart.PartStatusId = part.PartStatusId;
                    accessoryPart.Notes = part.Notes;
                    accessoryPart.DateUpdated = DateTime.Now;
                    accessoryPart.DateCreated = DateTime.Now;
                    accessoryPart.Label = part.Label;
                    CreatePlanogramPart(accessoryPart);
                }


            }
            foreach (PlanogramShelf shelf in originalScratchPad.PlanogramShelves)
            {
                PlanogramShelf newShelf = new PlanogramShelf()
                {
                    ScratchPadId = newScratchPad.Id,
                    ShelfTypeId = shelf.ShelfTypeId,
                    PlanogramId = newPlanogramId,
                    Column = shelf.Column,
                    Row = shelf.Row,
                    Width = shelf.Width,
                    Height = shelf.Height,
                    Label = shelf.Label,
                    Part = shelf.Part,
                    PartStatusId = shelf.PartStatusId,
                    PositionX = shelf.PositionX,
                    PositionY = shelf.PositionY
                };
                CreatePlanogramShelf(newShelf);
            }
            //SaveScratchPad();
            await _scratchPadRepository.UpdateAsync(newScratchPad);
            return newScratchPad.Id;
        }

        public Task<ScratchPad> GetScratchPad(long scratchPadId)
        {
            throw new NotImplementedException();
        }


        public async Task<ScratchPad> GetScratchPad(int scratchPadId)
        {
            var scratchPad = await _scratchPadRepository.GetByIdAsync(scratchPadId);
            return scratchPad;
        }

        public async void CreateScratchPad(ScratchPad scratchPad)
        {
            await _scratchPadRepository.AddAsync(scratchPad);
            
        }

        public async void DeleteScratchPad(long id)
        {
            var scratchPad = await _scratchPadRepository.GetByIdAsync(id);
            await _scratchPadRepository.DeleteAsync(scratchPad);
        }



        #endregion
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
