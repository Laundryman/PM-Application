using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Dtos;
using PMApplication.Specifications.Filters;
using PMApplication.Dtos.PlanModels;
using PMApplication.Specifications;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IPlanogramService
    {
        Task<Planogram> GetPlanogram(long id);
        Task<IEnumerable<Planogram>> GetPlanograms(PlanogramFilter filter);
        Task<IEnumerable<PlanogramLock>> GetLockedPlanograms();


        /// <summary>
        /// Get All Planograms for a specific country
        /// </summary>
        /// <param name="threeLetterIsoCode">The three letter ISO code pertaining to the required country</param>
        /// <returns></returns>
        //IEnumerable<Planogram> GetPlanogramsByUserCountry(int brandId, string threeLetterIsoCode);
        ////IEnumerable<Planogram> GetTemplatePlanogramByCountry(int countryId);
        //IEnumerable<Planogram> GetTemplatePlanogramByCluster(int clusterId);
        //IEnumerable<Planogram> GetTemplatePlanogramByStand(int standId);
        ////IEnumerable<Planogram> GetTemplatePlanograms(int brandId, int countryId);
        //IEnumerable<Planogram> GetApprovedPlanogramsByUser(string userId);
        //IEnumerable<Planogram> GetApprovedPlanogramsByUserCountry(int brandId, string threeLetterIsoCode);
        //IEnumerable<Planogram> GetApprovedPlanograms(int brandId);
        //IEnumerable<Planogram> GetInProgressPlanogramsByUser(string userId);
        //IEnumerable<Planogram> GetInProgressPlanogramsByUserCountry(int brandId, string threeLetterIsoCode);
        //IEnumerable<Planogram> GetInProgressPlanograms(int brandId);
        //IEnumerable<Planogram> GetSubmittedPlanogramsByUser(string userId);
        //IEnumerable<Planogram> GetSubmittedPlanogramsByUserCountry(int brandId, string threeLetterIsoCode);
        //IEnumerable<Planogram> GetSubmittedPlanograms();

        //IEnumerable<PlanogramInfo> GetApprovedPlanograms(string userId, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser);

        //IEnumerable<PlanogramInfo> GetArchivedPlanograms(string userId, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser);
        //IEnumerable<PlanogramInfo> GetArchivedPlanograms(string userId, string jobCode, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser, string planogramHostUrl = "");

        //IEnumerable<PlanogramInfo> GetValidatedPlanograms(string userId, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser);

        //IEnumerable<PlanogramInfo> GetInProgressPlanograms(string userId, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser);

        //IEnumerable<PlanogramInfo> GetSubmittedPlanograms(string userId, int brandId, int countryId, int regionId, int standTypeId, bool isDiamUser);







        Task<IReadOnlyList<Sku>> GetSkuList(long id, string userId, bool hasColumns);
        //IEnumerable<CassetteList> GetCassetteList(int id, string userId);


        Task<long> CreatePlanogramFromCluster(int clusterId, string name, CurrentUser userInfo);
        Task<long> ClonePlanogram(long planogramId, string name, CurrentUser userProfile);
        Task<long> ClonePlanogram(long planogramId, string name, CurrentUser userProfile, bool isUpdate);



        //  int GetPlanogramSectionOffSetWidth(int planogramId, int sectionStartPoint, int sectionEndPoint);

        Task CreatePlanogram(Planogram planogram);
        void DeletePlanogram(long id);
        void LockPlanogram(long id, CurrentUser user);
        void UnLockPlanogram(long id, CurrentUser user);
        void UnLockPlanogram(long id);

        bool IsLocked(long PlanogramId, CurrentUser user);
        void SavePlanogram(Planogram planogram);

        PlanogramNote GetNote(long noteId);
        Task<IReadOnlyList<PlanogramNote>> GetPlanogramNotes(NoteFilter filter);

        Task<IReadOnlyList<PlanogramNote>> DuplicatePlanogramNotes(string userId, int brandId, int countryId,
            int regionId, int planogramId, long newPlanogramId);
        void CreatePlanogramNote(PlanogramNote planogramNote);
        void DeletePlanogramNote(int id);
        void SavePlanogramNote();

        Task<long> CloneScratchPad(long planogramId, long newPlanogramId);
        Task<ScratchPad> GetScratchPad(long scratchPadId);
        void CreateScratchPad(ScratchPad scratchPad);
        void DeleteScratchPad(long id);
        //void SaveScratchPad();

        PlanogramShelf GetPlanogramShelf(int id);
        IEnumerable<PlanogramShelf> GetPlanogramShelves(int planogramId);
        void CreatePlanogramShelf(PlanogramShelf shelf);
        Task DeletePlanogramShelf(long id);
        void SavePlanogramShelf();

        //IEnumerable<PlanxPlanogramPart> GetPlanogramParts(int planogramId, int countryId);
        PlanogramPart GetPlanogramPart(int id);
        Task<IReadOnlyList<PlanogramPart>> GetPlanogramParts(PlanogramPartFilter filter);
        void CreatePlanogramPart(PlanogramPart part);
        void DeletePlanogramPart(int id);
        void SavePlanogramPart();

        PlanogramPartFacing GetPlanogramPartFacing(long id);
        void CreatePlanogramPartFacing(PlanogramPartFacing partFacing);
        void DeletePlanogramPartFacing(long id);
        void SavePlanogramPartFacing();

        IEnumerable<PlanogramPartFacing> GetPlanogramPartFacings();
        IEnumerable<PartFacingDto> GetPlanogramPartFacings(int ppartId);

        PlanogramStatus GetPlanogramStatus(int id);

        //these are just special parts, that can have a parent part (cassette)
        void CreatePlanogramPartFactice(PlanogramPart part);
        void DeletePlanogramPartFactice(int id);
        void SavePlanogramPartFactice();
    }
}
