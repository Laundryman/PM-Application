using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Dtos;
using PMApplication.Specifications.Filters;
using PMApplication.Dtos.Filters.Widgets;

using PMApplication.Dtos.PlanModels;
using PMApplication.Specifications;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IPlanogramService
    {
        Task<Planogram> GetPlanogram(long id);
        Task<Planogram> GetPlanogram(PlanogramFilter filter);
        Task<IEnumerable<Planogram>> GetPlanograms(PlanogramFilter filter);
        //Task<IEnumerable<PlanogramLock>> GetLockedPlanograms();

        Task<IReadOnlyList<PlanogramShelf>> GetPlanogramShelves(PlanogramFilter filter);
        Task<IReadOnlyList<PlanogramPart>> GetPlanogramParts(PlanogramPartFilter filter);

        Task<PlanogramPreview?> GetPlanogramPreview(long id);
        Task<PlanogramPreview> GetPlanogramPreview(PlanogramFilter filter);
        Task CreatePlanogramPreview(PlanogramPreview preview);
        Task SavePlanogramPreview(PlanogramPreview preview);
        public Task<int> GetPlanogramCount(CountsFilterDto filter);

        Task<IReadOnlyList<Sku>> GetSkuList(long id, string userId, bool hasColumns);


        Task<long> CreatePlanogramFromCluster(ClusterFilter filter, CreatePlanogramDto newPlanogramDetails, CurrentUser userInfo);
        Task<long> ClonePlanogram(long planogramId, string name, CurrentUser userProfile);
        Task<long> ClonePlanogram(long planogramId, string name, CurrentUser userProfile, bool isUpdate);


        Task CreatePlanogram(Planogram planogram);
        Task DeletePlanogram(long id);
        Task LockPlanogram(PlanogramLockFilter filter);
        Task UnLockPlanogram(PlanogramLockFilter filter);

        Task<bool> IsLocked(PlanogramLockFilter filter);
        Task SavePlanogram(Planogram planogram);

        Task<PlanogramNote> GetNote(long noteId);
        Task<IReadOnlyList<PlanogramNote>> GetPlanogramNotes(NoteFilter filter);

        Task<IReadOnlyList<PlanogramNote>> DuplicatePlanogramNotes(long planogramId, long newPlanogramId);
        Task CreatePlanogramNote(PlanogramNote planogramNote);
        //void DeletePlanogramNote(int id);
        //void SavePlanogramNote();

        Task<long> CloneScratchPad(long planogramId, long newPlanogramId);
        Task<ScratchPad> GetScratchPad(long scratchPadId);
        Task<ScratchPad> GetScratchPad(ScratchPadFilter filter);
        Task CreateScratchPad(ScratchPad scratchPad);
        void DeleteScratchPad(long id);
        //void SaveScratchPad();

        Task<PlanogramShelf> GetPlanogramShelf(int id);
        //IEnumerable<PlanogramShelf> GetPlanogramShelves(int planogramId);
        Task CreatePlanogramShelf(PlanogramShelf shelf);
        Task DeletePlanogramShelf(long id);
        Task UpdatePlanogramShelf(PlanogramShelf shelf);

        //IEnumerable<PlanxPlanogramPart> GetPlanogramParts(int planogramId, int countryId);
        Task<PlanogramPart> GetPlanogramPart(long id);
        Task CreatePlanogramPart(PlanogramPart part);
        Task DeletePlanogramPart(long id);
        Task SavePlanogramPart(PlanogramPart part);

        Task<PlanogramPartFacing> GetPlanogramPartFacing(long id);
        Task CreatePlanogramPartFacing(PlanogramPartFacing partFacing);
        Task DeletePlanogramPartFacing(long id);
        Task SavePlanogramPartFacing(PlanogramPartFacing partFacing);

        //IEnumerable<PlanogramPartFacing> GetPlanogramPartFacings();
        //IEnumerable<PartFacingDto> GetPlanogramPartFacings(int ppartId);

        //Task<PlanogramStatus> GetPlanogramStatus(int id);

        //these are just special parts, that can have a parent part (cassette)
        //void CreatePlanogramPartFactice(PlanogramPart part);
        //void DeletePlanogramPartFactice(int id);
        //void SavePlanogramPartFactice();

        Task<IEnumerable<Planogram>> GetRecentPlanogramsAsync(PlanoWidgetFilterDto filter);
    }
}
