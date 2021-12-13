using BusinessLogicLib.Interfaces;
using BusinessLogicLib.Models;
using DataBaseLib.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RepositoryLib.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLib.Service
{
    public class Config : IConfig
    {
        public IConfigurationRepository ConfigeRpository { get; }
        public IBusinessUnitsDataAccess BuDataAccess { get; }
        public IDepartmentsDataAccess DepDataAccess { get; }

        public Config(IConfigurationRepository configeRpository, IBusinessUnitsDataAccess buDataAccess, IDepartmentsDataAccess depDataAccess)
        {
            ConfigeRpository = configeRpository;
            BuDataAccess = buDataAccess;
            DepDataAccess = depDataAccess;
        }

        private readonly string[] _businessUnits = { "Ikke Angivet", "Aalborg Portland", "Unicon DK", "Unicon NO", "Kudsk & Dahl" }; // string length max 50.
        private readonly string[] _departments = { "Ikke Angivet", "Salg", "SCM", "Produktion", "Vedligehold", "Finans", "HR", "PMO & Trans" }; // string length max 50.

        public static string[] PriorityStrs { get; } = new string[] { "Ikke angivet", "Lav", "Mellem", "Høj" }; // Max length 255
        public static string[] StatusStrs { get; } = new string[] { "Oprettet", "Godkendt", "Arkiveret", "Afsluttet" }; // Max length 255

        /// <summary>
        /// Create tables DepartmentTbl and BusinessUnitTbl if empty
        /// </summary>
        public async Task ConfigureDBTables()
        {
            if (!(await ConfigeRpository.DoesDatabaseExist())) 
                throw new DbNoConnectionException();

            if (await ConfigeRpository.IsBuAndDepEmpty())
                await SetDefaultDeBuTbls();

            if (await ConfigeRpository.IsGuideTextEmpty())
                await ConfigeRpository.SetDefaultGuideText();
        }
        private async Task SetDefaultDeBuTbls()
        {
            try
            {
                for (int i = 0; i < _departments.Length; i++)
                {
                    DepartmentsTbl dep = new();
                    dep.Id = i + 1;
                    dep.Name = _departments[i];
                    await DepDataAccess.Insert(dep);
                }
                for (int i = 0; i < _businessUnits.Length; i++)
                {
                    BusinessUnitsTbl bu = new();
                    bu.Id = i + 1;
                    bu.Name = _businessUnits[i];
                    await BuDataAccess.Insert(bu);
                }
            } catch (DbUpdateException)
            {
                throw new DbUpdateException("Please reload page");
            }
            
        }
        public async Task<List<IdentityUser>> GetUsers()
        {
            return await ConfigeRpository.GetUsernameList();
        }

        public async Task EditGuideText(Settings settings)
        {
            await ConfigeRpository.UpdateGuideText(DBConvert.SettingsToGuideTbl(settings));
        }

        public async Task<Settings> GetGuideText()
        {
            return DBConvert.GuideTblToSettings(await ConfigeRpository.GetGuideText());
        }
    }
}

