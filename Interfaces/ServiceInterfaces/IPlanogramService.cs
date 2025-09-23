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






        IEnumerable<PlanogramNote> GetPlanogramNotes(string userId, int brandId, int countryId, int regionId, int planogramID);


        //IEnumerable<SkuList> GetSkuList(int id, string userId, bool hasColumns);
        //IEnumerable<CassetteList> GetCassetteList(int id, string userId);


        //int CreatePlanogramFromCluster(int clusterId, string name, UserViewModel userInfo);
        //Task<int> ClonePlanogram(int planogramId, string name, UserViewModel userProfile);
        //Task<int> ClonePlanogram(int planogramId, string name, UserViewModel userProfile, bool isUpdate);



        //XmlDocument GetPlanogramXML(int id, string userId, string rootPath);
        //    XmlDocument GetPlanogramSectionXML(int planogramId, Guid virtualPlanoId, string userId, string rootPath, int leftPosition, int rightPosition);
        //  int GetPlanogramSectionOffSetWidth(int planogramId, int sectionStartPoint, int sectionEndPoint);

        void CreatePlanogram(Planogram planogram);
        void DeletePlanogram(int id);
        //void LockPlanogram(int id, UserViewModel user);
        //void UnLockPlanogram(int id, UserViewModel user);
        //void UnLockPlanogram(int id);

        bool IsLocked(int id, CurrentUser user);
        void SavePlanogram();

        PlanogramNote GetNote(long noteId);
        void CreatePlanogramNote(PlanogramNote planogramNote);
        void DeletePlanogramNote(int id);
        void SavePlanogramNote();

        ScratchPad GetScratchPad(int scratchPadId);
        void CreateScratchPad(ScratchPad scratchPad);
        void DeleteScratchPad(int id);
        void SaveScratchPad();

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
