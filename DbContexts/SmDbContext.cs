using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using nhcs_agent.Models;

namespace nhcs_agent.DbContexts;

public partial class SmDbContext : DbContext
{
    public SmDbContext(DbContextOptions<SmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OdMsMCity> OdMsMCities { get; set; }

    public virtual DbSet<OdMsMCompany> OdMsMCompanies { get; set; }

    public virtual DbSet<OdMsMCompanyGroup> OdMsMCompanyGroups { get; set; }

    public virtual DbSet<OdMsMCompanyOutsource> OdMsMCompanyOutsources { get; set; }

    public virtual DbSet<OdMsMCompanyOutsourceGroup> OdMsMCompanyOutsourceGroups { get; set; }

    public virtual DbSet<OdMsMCostCentre> OdMsMCostCentres { get; set; }

    public virtual DbSet<OdMsMCountry> OdMsMCountries { get; set; }

    public virtual DbSet<OdMsMDistrict> OdMsMDistricts { get; set; }

    public virtual DbSet<OdMsMEmploymentType> OdMsMEmploymentTypes { get; set; }

    public virtual DbSet<OdMsMEmploymentTypeGroup> OdMsMEmploymentTypeGroups { get; set; }

    public virtual DbSet<OdMsMFamilyFunction> OdMsMFamilyFunctions { get; set; }

    public virtual DbSet<OdMsMFunction> OdMsMFunctions { get; set; }

    public virtual DbSet<OdMsMGroupPosition> OdMsMGroupPositions { get; set; }

    public virtual DbSet<OdMsMGroupingDetail> OdMsMGroupingDetails { get; set; }

    public virtual DbSet<OdMsMGroupingHeader> OdMsMGroupingHeaders { get; set; }

    public virtual DbSet<OdMsMJobLevel> OdMsMJobLevels { get; set; }

    public virtual DbSet<OdMsMJobTitle> OdMsMJobTitles { get; set; }

    public virtual DbSet<OdMsMJobTitleFamily> OdMsMJobTitleFamilies { get; set; }

    public virtual DbSet<OdMsMJobTitleOrganizationLevel> OdMsMJobTitleOrganizationLevels { get; set; }

    public virtual DbSet<OdMsMLocation> OdMsMLocations { get; set; }

    public virtual DbSet<OdMsMLocationType> OdMsMLocationTypes { get; set; }

    public virtual DbSet<OdMsMOrganization> OdMsMOrganizations { get; set; }

    public virtual DbSet<OdMsMOrganizationGroup> OdMsMOrganizationGroups { get; set; }

    public virtual DbSet<OdMsMOrganizationLevel> OdMsMOrganizationLevels { get; set; }

    public virtual DbSet<OdMsMState> OdMsMStates { get; set; }

    public virtual DbSet<OdMsMSubDistrict> OdMsMSubDistricts { get; set; }

    public virtual DbSet<OdMsSMatrixMapping> OdMsSMatrixMappings { get; set; }

    public virtual DbSet<PmMsMBank> PmMsMBanks { get; set; }

    public virtual DbSet<PmMsMCompanyBank> PmMsMCompanyBanks { get; set; }

    public virtual DbSet<PmMsMCurrency> PmMsMCurrencies { get; set; }

    public virtual DbSet<PmMsMDocumentType> PmMsMDocumentTypes { get; set; }

    public virtual DbSet<PmMsMDocumentTypeGroup> PmMsMDocumentTypeGroups { get; set; }

    public virtual DbSet<PmMsMEducationInstitution> PmMsMEducationInstitutions { get; set; }

    public virtual DbSet<PmMsMEducationLevel> PmMsMEducationLevels { get; set; }

    public virtual DbSet<PmMsMEducationMajor> PmMsMEducationMajors { get; set; }

    public virtual DbSet<PmMsMEmployee> PmMsMEmployees { get; set; }

    public virtual DbSet<PmMsMFamilyRelationGrouping> PmMsMFamilyRelationGroupings { get; set; }

    public virtual DbSet<PmMsMFamilyRelationType> PmMsMFamilyRelationTypes { get; set; }

    public virtual DbSet<PmMsMHobby> PmMsMHobbies { get; set; }

    public virtual DbSet<PmMsMLanguage> PmMsMLanguages { get; set; }

    public virtual DbSet<PmMsMMaritalStatus> PmMsMMaritalStatuses { get; set; }

    public virtual DbSet<PmMsMRace> PmMsMRaces { get; set; }

    public virtual DbSet<PmMsMReligion> PmMsMReligions { get; set; }

    public virtual DbSet<PmMsMResidenceStatus> PmMsMResidenceStatuses { get; set; }

    public virtual DbSet<PmMsMSkill> PmMsMSkills { get; set; }

    public virtual DbSet<PmMsMSkillGroup> PmMsMSkillGroups { get; set; }

    public virtual DbSet<PmMsMSocialMediaType> PmMsMSocialMediaTypes { get; set; }

    public virtual DbSet<PmMsMVaccineMaster> PmMsMVaccineMasters { get; set; }

    public virtual DbSet<PmMsMVehicleOwnStatus> PmMsMVehicleOwnStatuses { get; set; }

    public virtual DbSet<PmMsMVehicleType> PmMsMVehicleTypes { get; set; }

    public virtual DbSet<PmPcnMNumberFormat> PmPcnMNumberFormats { get; set; }

    public virtual DbSet<PmPcnMType> PmPcnMTypes { get; set; }

    public virtual DbSet<PmPcnSMatrixType> PmPcnSMatrixTypes { get; set; }

    public virtual DbSet<PmPcnSTypeTrustee> PmPcnSTypeTrustees { get; set; }

    public virtual DbSet<PmPcnTRequest> PmPcnTRequests { get; set; }

    public virtual DbSet<PmPcnTRequestApproval> PmPcnTRequestApprovals { get; set; }

    public virtual DbSet<PmPcnTRequestApprovalMember> PmPcnTRequestApprovalMembers { get; set; }

    public virtual DbSet<PmTrmMBenefit> PmTrmMBenefits { get; set; }

    public virtual DbSet<PmTrmMExitType> PmTrmMExitTypes { get; set; }

    public virtual DbSet<PmTrmMNumberFormat> PmTrmMNumberFormats { get; set; }

    public virtual DbSet<PmTrmMReason> PmTrmMReasons { get; set; }

    public virtual DbSet<PmTrmMReasonCategory> PmTrmMReasonCategories { get; set; }

    public virtual DbSet<SmAthMLoginUserList> SmAthMLoginUserLists { get; set; }

    public virtual DbSet<SmAthMUserLevel> SmAthMUserLevels { get; set; }

    public virtual DbSet<SmAthSUserLevelMapping> SmAthSUserLevelMappings { get; set; }

    public virtual DbSet<SmAthSUserLevelMenuMapping> SmAthSUserLevelMenuMappings { get; set; }

    public virtual DbSet<SmAthTLoginFailedAttempt> SmAthTLoginFailedAttempts { get; set; }

    public virtual DbSet<SmAthTLoginSession> SmAthTLoginSessions { get; set; }

    public virtual DbSet<SmCrMMenu> SmCrMMenus { get; set; }

    public virtual DbSet<SmCrMMenuFeature> SmCrMMenuFeatures { get; set; }

    public virtual DbSet<SmCrMModule> SmCrMModules { get; set; }

    public virtual DbSet<SmCrMModuleActivity> SmCrMModuleActivities { get; set; }

    public virtual DbSet<SmFlwMApprovalTypeHeader> SmFlwMApprovalTypeHeaders { get; set; }

    public virtual DbSet<SmFlwMApprovalTypeHeaderAlias> SmFlwMApprovalTypeHeaderAliases { get; set; }

    public virtual DbSet<SmFlwMApprovalTypeHeaderAliasDetail> SmFlwMApprovalTypeHeaderAliasDetails { get; set; }

    public virtual DbSet<SmFlwMApprovalWorkflowHeader> SmFlwMApprovalWorkflowHeaders { get; set; }

    public virtual DbSet<SmFlwMCriteriaDetail> SmFlwMCriteriaDetails { get; set; }

    public virtual DbSet<SmFlwMCriteriaHeader> SmFlwMCriteriaHeaders { get; set; }

    public virtual DbSet<SmFlwMCriteriaMaster> SmFlwMCriteriaMasters { get; set; }

    public virtual DbSet<SmFlwMCriteriaMemberJobTitle> SmFlwMCriteriaMemberJobTitles { get; set; }

    public virtual DbSet<SmFlwMCriteriaMemberLocationType> SmFlwMCriteriaMemberLocationTypes { get; set; }

    public virtual DbSet<SmFlwMCriteriaMemberOrgLevel> SmFlwMCriteriaMemberOrgLevels { get; set; }

    public virtual DbSet<SmFlwMEmpSuperior> SmFlwMEmpSuperiors { get; set; }

    public virtual DbSet<SmFlwSApprovalMapping> SmFlwSApprovalMappings { get; set; }

    public virtual DbSet<SmFlwSApprovalTypeMapping> SmFlwSApprovalTypeMappings { get; set; }

    public virtual DbSet<SmFlwSApprovalWorkflowTemplate> SmFlwSApprovalWorkflowTemplates { get; set; }

    public virtual DbSet<SmFlwTApprovalAccess> SmFlwTApprovalAccesses { get; set; }

    public virtual DbSet<SmFlwTApprovalWorkflowTransaction> SmFlwTApprovalWorkflowTransactions { get; set; }

    public virtual DbSet<SmNumMMappingAttribute> SmNumMMappingAttributes { get; set; }

    public virtual DbSet<SmNumMMasterNumberFormat> SmNumMMasterNumberFormats { get; set; }

    public virtual DbSet<SmTstMTrusteeAliasHeader> SmTstMTrusteeAliasHeaders { get; set; }

    public virtual DbSet<SmTstMTrusteeAliasMember> SmTstMTrusteeAliasMembers { get; set; }

    public virtual DbSet<SmTstMUserGroup> SmTstMUserGroups { get; set; }

    public virtual DbSet<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; }

    public virtual DbSet<SmTstSUserGroupData> SmTstSUserGroupData { get; set; }

    public virtual DbSet<SmTstSUserGroupMenu> SmTstSUserGroupMenus { get; set; }

    public virtual DbSet<SmTstSUserGroupMenuFeature> SmTstSUserGroupMenuFeatures { get; set; }

    public virtual DbSet<SmTstSUserTrusteeDataCriteria> SmTstSUserTrusteeDataCriteria { get; set; }

    public virtual DbSet<SmTstSUserTrusteeData> SmTstSUserTrusteeData { get; set; }

    public virtual DbSet<SmTstSUserTrusteeMenu> SmTstSUserTrusteeMenus { get; set; }

    public virtual DbSet<SmTstSUserTrusteeMenuFeature> SmTstSUserTrusteeMenuFeatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum("operationEnum", new[] { "INSERT", "UPDATE", "DELETE" });

        modelBuilder.Entity<OdMsMCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("od_ms_m_city");

            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(200)
                .HasColumnName("city_name");
            entity.Property(e => e.CityType)
                .HasMaxLength(200)
                .HasColumnName("city_type");
        });

        modelBuilder.Entity<OdMsMCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("od_ms_m_company_pkey");

            entity.ToTable("od_ms_m_company");

            entity.HasIndex(e => e.CompanyCode, "od_ms_m_company_pk").IsUnique();

            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("nextval('od_ms_m_company_id_seq'::regclass)")
                .HasColumnName("company_id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("city_id");
            entity.Property(e => e.CompanyAlias)
                .HasMaxLength(200)
                .HasColumnName("company_alias");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(50)
                .HasColumnName("company_code");
            entity.Property(e => e.CompanyGroupId).HasColumnName("company_group_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .HasColumnName("company_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DistrictId)
                .HasMaxLength(50)
                .HasColumnName("district_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(200)
                .HasColumnName("phone_number");
            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("state_id");
            entity.Property(e => e.SubDistrictId)
                .HasMaxLength(50)
                .HasColumnName("sub_district_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(200)
                .HasColumnName("zip_code");

            entity.HasOne(d => d.CompanyGroup).WithMany(p => p.OdMsMCompanies)
                .HasForeignKey(d => d.CompanyGroupId)
                .HasConstraintName("od_ms_m_company_od_ms_m_company_group_company_group_id_fk");
        });

        modelBuilder.Entity<OdMsMCompanyGroup>(entity =>
        {
            entity.HasKey(e => e.CompanyGroupId).HasName("od_ms_m_company_group_pkey");

            entity.ToTable("od_ms_m_company_group");

            entity.HasIndex(e => e.CompanyGroupCode, "od_ms_m_company_group_pk").IsUnique();

            entity.Property(e => e.CompanyGroupId)
                .HasDefaultValueSql("nextval('od_ms_m_company_group_id_seq'::regclass)")
                .HasColumnName("company_group_id");
            entity.Property(e => e.CompanyGroupCode)
                .HasMaxLength(50)
                .HasColumnName("company_group_code");
            entity.Property(e => e.CompanyGroupName)
                .HasMaxLength(200)
                .HasColumnName("company_group_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMCompanyOutsource>(entity =>
        {
            entity.HasKey(e => e.CompanyOutsourceId).HasName("od_ms_m_company_outsource_pkey");

            entity.ToTable("od_ms_m_company_outsource");

            entity.HasIndex(e => e.CompanyOutsourceCode, "od_ms_m_company_outsource_pk").IsUnique();

            entity.Property(e => e.CompanyOutsourceId)
                .HasDefaultValueSql("nextval('od_ms_m_company_outsource_id_seq'::regclass)")
                .HasColumnName("company_outsource_id");
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("city_id");
            entity.Property(e => e.CompanyOutsourceCode)
                .HasMaxLength(50)
                .HasColumnName("company_outsource_code");
            entity.Property(e => e.CompanyOutsourceGroupId).HasColumnName("company_outsource_group_id");
            entity.Property(e => e.CompanyOutsourceName)
                .HasMaxLength(200)
                .HasColumnName("company_outsource_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CompanyOutsourceGroup).WithMany(p => p.OdMsMCompanyOutsources)
                .HasForeignKey(d => d.CompanyOutsourceGroupId)
                .HasConstraintName("od_ms_m_company_outsource_od_ms_m_company_outsource_group_compa");
        });

        modelBuilder.Entity<OdMsMCompanyOutsourceGroup>(entity =>
        {
            entity.HasKey(e => e.CompanyOutsourceGroupId).HasName("od_ms_m_company_outsource_group_pkey");

            entity.ToTable("od_ms_m_company_outsource_group");

            entity.HasIndex(e => e.CompanyOutsourceGroupCode, "od_ms_m_company_outsource_group_pk").IsUnique();

            entity.Property(e => e.CompanyOutsourceGroupId)
                .HasDefaultValueSql("nextval('od_ms_m_company_outsource_group_id_seq'::regclass)")
                .HasColumnName("company_outsource_group_id");
            entity.Property(e => e.CompanyOutsourceGroupCode)
                .HasMaxLength(50)
                .HasColumnName("company_outsource_group_code");
            entity.Property(e => e.CompanyOutsourceGroupName)
                .HasMaxLength(200)
                .HasColumnName("company_outsource_group_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMCostCentre>(entity =>
        {
            entity.HasKey(e => e.CostCentreId).HasName("od_ms_m_cost_centre_pkey");

            entity.ToTable("od_ms_m_cost_centre");

            entity.HasIndex(e => e.CostCentreCode, "od_ms_m_cost_centre_pk").IsUnique();

            entity.Property(e => e.CostCentreId)
                .HasDefaultValueSql("nextval('od_ms_m_cost_centre_id_seq'::regclass)")
                .HasColumnName("cost_centre_id");
            entity.Property(e => e.CostCentreCode)
                .HasMaxLength(50)
                .HasColumnName("cost_centre_code");
            entity.Property(e => e.CostCentreName)
                .HasMaxLength(200)
                .HasColumnName("cost_centre_name");
            entity.Property(e => e.CostCentreSapId).HasColumnName("cost_centre_sap_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("od_ms_m_country_pkey");

            entity.ToTable("od_ms_m_country");

            entity.HasIndex(e => e.CountryCode, "od_ms_m_country_pk").IsUnique();

            entity.Property(e => e.CountryId)
                .HasDefaultValueSql("nextval('od_ms_m_country_id_seq'::regclass)")
                .HasColumnName("country_id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .HasColumnName("country_code");
            entity.Property(e => e.CountryName)
                .HasMaxLength(200)
                .HasColumnName("country_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Currency).WithMany(p => p.OdMsMCountries)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("od_ms_m_country_pm_ms_m_currency_currency_id_fk");
        });

        modelBuilder.Entity<OdMsMDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("od_ms_m_district_pkey");

            entity.ToTable("od_ms_m_district");

            entity.Property(e => e.DistrictId)
                .HasMaxLength(50)
                .HasColumnName("district_id");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(50)
                .HasColumnName("district_name");
        });

        modelBuilder.Entity<OdMsMEmploymentType>(entity =>
        {
            entity.HasKey(e => e.EmploymentTypeId).HasName("od_ms_m_employment_type_pkey");

            entity.ToTable("od_ms_m_employment_type");

            entity.HasIndex(e => e.EmploymentTypeCode, "od_ms_m_employment_type_pk").IsUnique();

            entity.Property(e => e.EmploymentTypeId)
                .HasDefaultValueSql("nextval('od_ms_m_employment_type_id_seq'::regclass)")
                .HasColumnName("employment_type_id");
            entity.Property(e => e.BpjsType)
                .HasMaxLength(200)
                .HasColumnName("bpjs_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmploymentTypeCode)
                .HasMaxLength(50)
                .HasColumnName("employment_type_code");
            entity.Property(e => e.EmploymentTypeGroupId).HasColumnName("employment_type_group_id");
            entity.Property(e => e.EmploymentTypeName)
                .HasMaxLength(200)
                .HasColumnName("employment_type_name");
            entity.Property(e => e.FgDueStatus)
                .HasMaxLength(1)
                .HasColumnName("fg_due_status");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.MonthEmploymentCount)
                .HasMaxLength(200)
                .HasColumnName("month_employment_count");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PeriodTime)
                .HasMaxLength(200)
                .HasColumnName("period_time");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.EmploymentTypeGroup).WithMany(p => p.OdMsMEmploymentTypes)
                .HasForeignKey(d => d.EmploymentTypeGroupId)
                .HasConstraintName("od_ms_m_employment_type_od_ms_m_employment_type_group_employmen");
        });

        modelBuilder.Entity<OdMsMEmploymentTypeGroup>(entity =>
        {
            entity.HasKey(e => e.EmploymentTypeGroupId).HasName("od_ms_m_employment_type_group_pkey");

            entity.ToTable("od_ms_m_employment_type_group");

            entity.HasIndex(e => e.EmploymentTypeGroupCode, "od_ms_m_employment_type_group_pk").IsUnique();

            entity.Property(e => e.EmploymentTypeGroupId)
                .HasDefaultValueSql("nextval('od_ms_m_employment_type_group_id_seq'::regclass)")
                .HasColumnName("employment_type_group_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmploymentTypeGroupCode)
                .HasMaxLength(50)
                .HasColumnName("employment_type_group_code");
            entity.Property(e => e.EmploymentTypeGroupName)
                .HasMaxLength(200)
                .HasColumnName("employment_type_group_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMFamilyFunction>(entity =>
        {
            entity.HasKey(e => e.FamilyFunctionId).HasName("od_ms_m_family_function_pkey");

            entity.ToTable("od_ms_m_family_function");

            entity.HasIndex(e => e.FamilyFunctionCode, "od_ms_m_family_function_pk").IsUnique();

            entity.Property(e => e.FamilyFunctionId)
                .HasDefaultValueSql("nextval('od_ms_m_family_function_id_seq'::regclass)")
                .HasColumnName("family_function_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FamilyFunctionCode)
                .HasMaxLength(50)
                .HasColumnName("family_function_code");
            entity.Property(e => e.FamilyFunctionName)
                .HasMaxLength(200)
                .HasColumnName("family_function_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMFunction>(entity =>
        {
            entity.HasKey(e => e.FunctionId).HasName("od_ms_m_function_pkey");

            entity.ToTable("od_ms_m_function");

            entity.HasIndex(e => e.FunctionCode, "od_ms_m_function_pk").IsUnique();

            entity.Property(e => e.FunctionId)
                .HasDefaultValueSql("nextval('od_ms_m_function_id_seq'::regclass)")
                .HasColumnName("function_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FunctionCode)
                .HasMaxLength(50)
                .HasColumnName("function_code");
            entity.Property(e => e.FunctionName)
                .HasMaxLength(200)
                .HasColumnName("function_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMGroupPosition>(entity =>
        {
            entity.HasKey(e => e.GroupPositionId).HasName("od_ms_m_group_position_pkey");

            entity.ToTable("od_ms_m_group_position");

            entity.HasIndex(e => e.GroupPositionCode, "od_ms_m_group_position_pk").IsUnique();

            entity.Property(e => e.GroupPositionId)
                .HasDefaultValueSql("nextval('od_ms_m_group_position_id_seq'::regclass)")
                .HasColumnName("group_position_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.GroupPositionCode)
                .HasMaxLength(50)
                .HasColumnName("group_position_code");
            entity.Property(e => e.GroupPositionName)
                .HasMaxLength(200)
                .HasColumnName("group_position_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMGroupingDetail>(entity =>
        {
            entity.HasKey(e => e.GroupingDetailId).HasName("od_ms_m_grouping_detail_pkey");

            entity.ToTable("od_ms_m_grouping_detail");

            entity.HasIndex(e => e.GroupingDetailCode, "od_ms_m_grouping_detail_pk").IsUnique();

            entity.Property(e => e.GroupingDetailId)
                .HasDefaultValueSql("nextval('od_ms_m_grouping_detail_id_seq'::regclass)")
                .HasColumnName("grouping_detail_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.GroupingDetailCode)
                .HasMaxLength(50)
                .HasColumnName("grouping_detail_code");
            entity.Property(e => e.GroupingDetailName)
                .HasMaxLength(200)
                .HasColumnName("grouping_detail_name");
            entity.Property(e => e.GroupingHeaderId).HasColumnName("grouping_header_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.GroupingHeader).WithMany(p => p.OdMsMGroupingDetails)
                .HasForeignKey(d => d.GroupingHeaderId)
                .HasConstraintName("od_ms_m_grouping_detail_od_ms_m_grouping_header_grouping_header");
        });

        modelBuilder.Entity<OdMsMGroupingHeader>(entity =>
        {
            entity.HasKey(e => e.GroupingHeaderId).HasName("od_ms_m_grouping_header_pkey");

            entity.ToTable("od_ms_m_grouping_header");

            entity.HasIndex(e => e.GroupingHeaderCode, "od_ms_m_grouping_header_pk").IsUnique();

            entity.Property(e => e.GroupingHeaderId)
                .HasDefaultValueSql("nextval('od_ms_m_grouping_header_id_seq'::regclass)")
                .HasColumnName("grouping_header_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.GroupBy)
                .HasMaxLength(200)
                .HasColumnName("group_by");
            entity.Property(e => e.GroupingHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("grouping_header_code");
            entity.Property(e => e.GroupingHeaderName)
                .HasMaxLength(200)
                .HasColumnName("grouping_header_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMJobLevel>(entity =>
        {
            entity.HasKey(e => e.JobLevelId).HasName("od_ms_m_job_level_pkey");

            entity.ToTable("od_ms_m_job_level");

            entity.HasIndex(e => e.JobLevelCode, "od_ms_m_job_level_pk").IsUnique();

            entity.Property(e => e.JobLevelId)
                .HasDefaultValueSql("nextval('od_ms_m_job_level_id_seq'::regclass)")
                .HasColumnName("job_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.GroupLevel)
                .HasMaxLength(200)
                .HasColumnName("group_level");
            entity.Property(e => e.HierarchyLevel)
                .HasMaxLength(50)
                .HasColumnName("hierarchy_level");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobLevelCode)
                .HasMaxLength(50)
                .HasColumnName("job_level_code");
            entity.Property(e => e.JobLevelName)
                .HasMaxLength(200)
                .HasColumnName("job_level_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PromoteRange)
                .HasMaxLength(50)
                .HasColumnName("promote_range");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMJobTitle>(entity =>
        {
            entity.HasKey(e => e.JobTitleId).HasName("od_ms_m_job_title_pkey");

            entity.ToTable("od_ms_m_job_title");

            entity.HasIndex(e => e.JobTitleCode, "od_ms_m_job_title_pk").IsUnique();

            entity.Property(e => e.JobTitleId)
                .HasDefaultValueSql("nextval('od_ms_m_job_title_id_seq'::regclass)")
                .HasColumnName("job_title_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FamilyFunctionId).HasColumnName("family_function_id");
            entity.Property(e => e.FgLdp)
                .HasMaxLength(1)
                .HasColumnName("fg_ldp");
            entity.Property(e => e.FgMdp)
                .HasMaxLength(1)
                .HasColumnName("fg_mdp");
            entity.Property(e => e.FunctionId).HasColumnName("function_id");
            entity.Property(e => e.GroupPositionId).HasColumnName("group_position_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobTitleCode)
                .HasMaxLength(50)
                .HasColumnName("job_title_code");
            entity.Property(e => e.JobTitleFamilyId).HasColumnName("job_title_family_id");
            entity.Property(e => e.JobTitleName)
                .HasMaxLength(200)
                .HasColumnName("job_title_name");
            entity.Property(e => e.JobTitleOrganizationLevelId).HasColumnName("job_title_organization_level_id");
            entity.Property(e => e.LevelMaxId).HasColumnName("level_max_id");
            entity.Property(e => e.LevelMinId).HasColumnName("level_min_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ParentJobTitleId).HasColumnName("parent_job_title_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.FamilyFunction).WithMany(p => p.OdMsMJobTitles)
                .HasForeignKey(d => d.FamilyFunctionId)
                .HasConstraintName("od_ms_m_job_title_od_ms_m_family_function_family_function_id_fk");

            entity.HasOne(d => d.Function).WithMany(p => p.OdMsMJobTitles)
                .HasForeignKey(d => d.FunctionId)
                .HasConstraintName("od_ms_m_job_title_od_ms_m_function_function_id_fk");

            entity.HasOne(d => d.GroupPosition).WithMany(p => p.OdMsMJobTitles)
                .HasForeignKey(d => d.GroupPositionId)
                .HasConstraintName("od_ms_m_job_title_od_ms_m_group_position_group_position_id_fk");

            entity.HasOne(d => d.JobTitleFamily).WithMany(p => p.OdMsMJobTitles)
                .HasForeignKey(d => d.JobTitleFamilyId)
                .HasConstraintName("od_ms_m_job_title_od_ms_m_job_title_family_job_title_family_id_");

            entity.HasOne(d => d.JobTitleOrganizationLevel).WithMany(p => p.OdMsMJobTitles)
                .HasForeignKey(d => d.JobTitleOrganizationLevelId)
                .HasConstraintName("od_ms_m_job_title_od_ms_m_job_title_organization_level_job_titl");
        });

        modelBuilder.Entity<OdMsMJobTitleFamily>(entity =>
        {
            entity.HasKey(e => e.JobTitleFamilyId).HasName("od_ms_m_job_title_family_pkey");

            entity.ToTable("od_ms_m_job_title_family");

            entity.HasIndex(e => e.JobTitleFamilyCode, "od_ms_m_job_title_family_pk").IsUnique();

            entity.Property(e => e.JobTitleFamilyId)
                .HasDefaultValueSql("nextval('od_ms_m_job_title_family_id_seq'::regclass)")
                .HasColumnName("job_title_family_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobTitleFamilyCode)
                .HasMaxLength(50)
                .HasColumnName("job_title_family_code");
            entity.Property(e => e.JobTitleFamilyName)
                .HasMaxLength(200)
                .HasColumnName("job_title_family_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMJobTitleOrganizationLevel>(entity =>
        {
            entity.HasKey(e => e.JobTitleOrganizationLevelId).HasName("od_ms_m_job_title_organization_level_pkey");

            entity.ToTable("od_ms_m_job_title_organization_level");

            entity.HasIndex(e => e.JobTitleOrganizationLevelCode, "od_ms_m_job_title_organization_level_pk").IsUnique();

            entity.Property(e => e.JobTitleOrganizationLevelId)
                .HasDefaultValueSql("nextval('od_ms_m_job_title_organization_level_id_seq'::regclass)")
                .HasColumnName("job_title_organization_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobTitleOrganizationLevelCode)
                .HasMaxLength(50)
                .HasColumnName("job_title_organization_level_code");
            entity.Property(e => e.JobTitleOrganizationLevelName)
                .HasMaxLength(200)
                .HasColumnName("job_title_organization_level_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("od_ms_m_location_pkey");

            entity.ToTable("od_ms_m_location");

            entity.HasIndex(e => e.LocationCode, "od_ms_m_location_pk").IsUnique();

            entity.Property(e => e.LocationId)
                .HasDefaultValueSql("nextval('od_ms_m_location_id_seq'::regclass)")
                .HasColumnName("location_id");
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("city_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.Latitude)
                .HasMaxLength(200)
                .HasColumnName("latitude");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasColumnName("location_code");
            entity.Property(e => e.LocationName)
                .HasMaxLength(200)
                .HasColumnName("location_name");
            entity.Property(e => e.LocationTypeId).HasColumnName("location_type_id");
            entity.Property(e => e.Longitude)
                .HasMaxLength(200)
                .HasColumnName("longitude");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(200)
                .HasColumnName("time_zone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.LocationType).WithMany(p => p.OdMsMLocations)
                .HasForeignKey(d => d.LocationTypeId)
                .HasConstraintName("od_ms_m_location_od_ms_m_location_type_location_type_id_fk");
        });

        modelBuilder.Entity<OdMsMLocationType>(entity =>
        {
            entity.HasKey(e => e.LocationTypeId).HasName("od_ms_m_location_type_pkey");

            entity.ToTable("od_ms_m_location_type");

            entity.HasIndex(e => e.LocationTypeCode, "od_ms_m_location_type_pk").IsUnique();

            entity.Property(e => e.LocationTypeId)
                .HasDefaultValueSql("nextval('od_ms_m_location_type_id_seq'::regclass)")
                .HasColumnName("location_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.LocationTypeCode)
                .HasMaxLength(50)
                .HasColumnName("location_type_code");
            entity.Property(e => e.LocationTypeName)
                .HasMaxLength(200)
                .HasColumnName("location_type_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMOrganization>(entity =>
        {
            entity.HasKey(e => e.OrganizationId).HasName("od_ms_m_organization_pkey");

            entity.ToTable("od_ms_m_organization");

            entity.HasIndex(e => e.OrganizationCode, "od_ms_m_organization_pk").IsUnique();

            entity.Property(e => e.OrganizationId)
                .HasDefaultValueSql("nextval('od_ms_m_organization_id_seq'::regclass)")
                .HasColumnName("organization_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.OrganizationCode)
                .HasMaxLength(50)
                .HasColumnName("organization_code");
            entity.Property(e => e.OrganizationGroupId).HasColumnName("organization_group_id");
            entity.Property(e => e.OrganizationLevelId).HasColumnName("organization_level_id");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .HasColumnName("organization_name");
            entity.Property(e => e.ParentOrganizationId).HasColumnName("parent_organization_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.OrganizationLevel).WithMany(p => p.OdMsMOrganizations)
                .HasForeignKey(d => d.OrganizationLevelId)
                .HasConstraintName("od_ms_m_organization_od_ms_m_organization_level_organization_le");
        });

        modelBuilder.Entity<OdMsMOrganizationGroup>(entity =>
        {
            entity.HasKey(e => e.OrganizationGroupId).HasName("od_ms_m_organization_group_pkey");

            entity.ToTable("od_ms_m_organization_group");

            entity.HasIndex(e => e.OrganizationGroupCode, "od_ms_m_organization_group_pk").IsUnique();

            entity.Property(e => e.OrganizationGroupId)
                .HasDefaultValueSql("nextval('od_ms_m_organization_group_id_seq'::regclass)")
                .HasColumnName("organization_group_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.OrganizationGroupCode)
                .HasMaxLength(50)
                .HasColumnName("organization_group_code");
            entity.Property(e => e.OrganizationGroupName)
                .HasMaxLength(200)
                .HasColumnName("organization_group_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMOrganizationLevel>(entity =>
        {
            entity.HasKey(e => e.OrganizationLevelId).HasName("od_ms_m_organization_level_pkey");

            entity.ToTable("od_ms_m_organization_level");

            entity.HasIndex(e => e.OrganizationLevelCode, "od_ms_m_organization_level_pk").IsUnique();

            entity.Property(e => e.OrganizationLevelId)
                .HasDefaultValueSql("nextval('od_ms_m_organization_level_id_seq'::regclass)")
                .HasColumnName("organization_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.OrganizationLevelCode)
                .HasMaxLength(50)
                .HasColumnName("organization_level_code");
            entity.Property(e => e.OrganizationLevelName)
                .HasMaxLength(200)
                .HasColumnName("organization_level_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OdMsMState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("od_ms_m_state_pkey");

            entity.ToTable("od_ms_m_state");

            entity.Property(e => e.StateId)
                .HasMaxLength(50)
                .HasColumnName("state_id");
            entity.Property(e => e.StateName)
                .HasMaxLength(200)
                .HasColumnName("state_name");
        });

        modelBuilder.Entity<OdMsMSubDistrict>(entity =>
        {
            entity.HasKey(e => e.SubDistrictId).HasName("od_ms_m_sub_district_pkey");

            entity.ToTable("od_ms_m_sub_district");

            entity.Property(e => e.SubDistrictId)
                .HasMaxLength(50)
                .HasColumnName("sub_district_id");
            entity.Property(e => e.PostCode)
                .HasMaxLength(50)
                .HasColumnName("post_code");
            entity.Property(e => e.SubDistrictName)
                .HasMaxLength(200)
                .HasColumnName("sub_district_name");
        });

        modelBuilder.Entity<OdMsSMatrixMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("od_ms_s_matrix_mapping");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CostCentreId).HasColumnName("cost_centre_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(50)
                .HasColumnName("is_active");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.MatrixMappingId).HasColumnName("matrix_mapping_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMBank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("pm_ms_m_bank_pkey");

            entity.ToTable("pm_ms_m_bank");

            entity.HasIndex(e => e.BankCode, "pm_ms_m_bank_pk").IsUnique();

            entity.Property(e => e.BankId)
                .HasDefaultValueSql("nextval('pm_ms_m_bank_id_seq'::regclass)")
                .HasColumnName("bank_id");
            entity.Property(e => e.BankCode)
                .HasMaxLength(50)
                .HasColumnName("bank_code");
            entity.Property(e => e.BankName)
                .HasMaxLength(200)
                .HasColumnName("bank_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMCompanyBank>(entity =>
        {
            entity.HasKey(e => e.CompanyBankId).HasName("pm_ms_m_company_bank_pkey");

            entity.ToTable("pm_ms_m_company_bank");

            entity.HasIndex(e => e.CompanyBankCode, "pm_ms_m_company_bank_pk").IsUnique();

            entity.Property(e => e.CompanyBankId)
                .HasDefaultValueSql("nextval('pm_ms_m_company_bank_id_seq'::regclass)")
                .HasColumnName("company_bank_id");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.BankNo)
                .HasMaxLength(200)
                .HasColumnName("bank_no");
            entity.Property(e => e.CompanyBankCode)
                .HasMaxLength(50)
                .HasColumnName("company_bank_code");
            entity.Property(e => e.CompanyBankName)
                .HasMaxLength(200)
                .HasColumnName("company_bank_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Bank).WithMany(p => p.PmMsMCompanyBanks)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("pm_ms_m_company_bank_pm_ms_m_bank_bank_id_fk");
        });

        modelBuilder.Entity<PmMsMCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("pm_ms_m_currency_pkey");

            entity.ToTable("pm_ms_m_currency");

            entity.HasIndex(e => e.CurrencyCode, "pm_ms_m_currency_pk").IsUnique();

            entity.Property(e => e.CurrencyId)
                .HasDefaultValueSql("nextval('pm_ms_m_currency_id_seq'::regclass)")
                .HasColumnName("currency_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(200)
                .HasColumnName("currency_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMDocumentType>(entity =>
        {
            entity.HasKey(e => e.DocumentTypeId).HasName("pm_ms_m_document_type_pkey");

            entity.ToTable("pm_ms_m_document_type");

            entity.HasIndex(e => e.DocumentTypeCode, "pm_ms_m_document_type_pk").IsUnique();

            entity.Property(e => e.DocumentTypeId)
                .HasDefaultValueSql("nextval('pm_ms_m_document_type_id_seq'::regclass)")
                .HasColumnName("document_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DocumentTypeCode)
                .HasMaxLength(50)
                .HasColumnName("document_type_code");
            entity.Property(e => e.DocumentTypeGroupId).HasColumnName("document_type_group_id");
            entity.Property(e => e.DocumentTypeName)
                .HasMaxLength(200)
                .HasColumnName("document_type_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.DocumentTypeGroup).WithMany(p => p.PmMsMDocumentTypes)
                .HasForeignKey(d => d.DocumentTypeGroupId)
                .HasConstraintName("pm_ms_m_document_type_pm_ms_m_document_type_group_document_type");
        });

        modelBuilder.Entity<PmMsMDocumentTypeGroup>(entity =>
        {
            entity.HasKey(e => e.DocumentTypeGroupId).HasName("pm_ms_m_document_type_group_pkey");

            entity.ToTable("pm_ms_m_document_type_group");

            entity.HasIndex(e => e.DocumentTypeGroupCode, "pm_ms_m_document_type_group_pk").IsUnique();

            entity.Property(e => e.DocumentTypeGroupId)
                .HasDefaultValueSql("nextval('pm_ms_m_document_type_group_id_seq'::regclass)")
                .HasColumnName("document_type_group_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DocumentTypeGroupCode)
                .HasMaxLength(50)
                .HasColumnName("document_type_group_code");
            entity.Property(e => e.DocumentTypeGroupName)
                .HasMaxLength(200)
                .HasColumnName("document_type_group_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMEducationInstitution>(entity =>
        {
            entity.HasKey(e => e.EducationInstitutionId).HasName("pm_ms_m_education_institution_pkey");

            entity.ToTable("pm_ms_m_education_institution");

            entity.HasIndex(e => e.EducationInstitutionCode, "pm_ms_m_education_institution_pk").IsUnique();

            entity.Property(e => e.EducationInstitutionId)
                .HasDefaultValueSql("nextval('pm_ms_m_education_institution_id_seq'::regclass)")
                .HasColumnName("education_institution_id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("city_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EducationInstitutionCode)
                .HasMaxLength(50)
                .HasColumnName("education_institution_code");
            entity.Property(e => e.EducationInstitutionName)
                .HasMaxLength(200)
                .HasColumnName("education_institution_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(200)
                .HasColumnName("phone_number");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .HasColumnName("website");
        });

        modelBuilder.Entity<PmMsMEducationLevel>(entity =>
        {
            entity.HasKey(e => e.EducationLevelId).HasName("pm_ms_m_education_level_pkey");

            entity.ToTable("pm_ms_m_education_level");

            entity.HasIndex(e => e.EducationLevelName, "pm_ms_m_education_level_pk").IsUnique();

            entity.Property(e => e.EducationLevelId)
                .HasDefaultValueSql("nextval('pm_ms_m_education_level_id_seq'::regclass)")
                .HasColumnName("education_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EducationLevelCode)
                .HasMaxLength(50)
                .HasColumnName("education_level_code");
            entity.Property(e => e.EducationLevelName)
                .HasMaxLength(200)
                .HasColumnName("education_level_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.LevelGrade)
                .HasMaxLength(200)
                .HasColumnName("level_grade");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMEducationMajor>(entity =>
        {
            entity.HasKey(e => e.EducationMajorId).HasName("pm_ms_m_education_major_pkey");

            entity.ToTable("pm_ms_m_education_major");

            entity.HasIndex(e => e.EducationMajorCode, "pm_ms_m_education_major_pk").IsUnique();

            entity.Property(e => e.EducationMajorId)
                .HasDefaultValueSql("nextval('pm_ms_m_education_major_id_seq'::regclass)")
                .HasColumnName("education_major_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EducationMajorCode)
                .HasMaxLength(50)
                .HasColumnName("education_major_code");
            entity.Property(e => e.EducationMajorName)
                .HasMaxLength(200)
                .HasColumnName("education_major_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("pm_ms_m_employee_pkey");

            entity.ToTable("pm_ms_m_employee");

            entity.HasIndex(e => e.EmployeeCode, "pm_ms_m_employee_pk").IsUnique();

            entity.Property(e => e.EmployeeId)
                .HasDefaultValueSql("nextval('pm_ms_m_employee_id_seq'::regclass)")
                .HasColumnName("employee_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CompanyOutsourceId).HasColumnName("company_outsource_id");
            entity.Property(e => e.ContractEndDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("contract_end_date");
            entity.Property(e => e.ContractStartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("contract_start_date");
            entity.Property(e => e.CostCentreId).HasColumnName("cost_centre_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DeskLocation)
                .HasMaxLength(200)
                .HasColumnName("desk_location");
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(50)
                .HasColumnName("employee_code");
            entity.Property(e => e.EmployeeIdAlias).HasColumnName("employee_id_alias");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(200)
                .HasColumnName("employee_name");
            entity.Property(e => e.EmploymentTypeId).HasColumnName("employment_type_id");
            entity.Property(e => e.FgActing)
                .HasMaxLength(1)
                .HasColumnName("fg_acting");
            entity.Property(e => e.FgConcurrently)
                .HasMaxLength(1)
                .HasColumnName("fg_concurrently");
            entity.Property(e => e.FgOutsource)
                .HasMaxLength(1)
                .HasColumnName("fg_outsource");
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .HasColumnName("first_name");
            entity.Property(e => e.HomeBaseLocationId).HasColumnName("home_base_location_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .HasColumnName("last_name");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(200)
                .HasColumnName("middle_name");
            entity.Property(e => e.OldEmployeeCode)
                .HasMaxLength(50)
                .HasColumnName("old_employee_code");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.StartJoinDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_join_date");
            entity.Property(e => e.StartWorkDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_work_date");
            entity.Property(e => e.TermEffDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("term_eff_date");
            entity.Property(e => e.TermInternalReason).HasColumnName("term_internal_reason");
            entity.Property(e => e.TermPlanDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("term_plan_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_company_company_id_fk");

            entity.HasOne(d => d.CompanyOutsource).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.CompanyOutsourceId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_company_outsource_company_outsource_id");

            entity.HasOne(d => d.CostCentre).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.CostCentreId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_cost_centre_cost_centre_id_fk");

            entity.HasOne(d => d.EmploymentType).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.EmploymentTypeId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_employment_type_employment_type_id_fk");

            entity.HasOne(d => d.HomeBaseLocation).WithMany(p => p.PmMsMEmployeeHomeBaseLocations)
                .HasForeignKey(d => d.HomeBaseLocationId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_location_location_id_fk2");

            entity.HasOne(d => d.JobLevel).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.JobLevelId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_job_level_job_level_id_fk");

            entity.HasOne(d => d.JobTitle).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.JobTitleId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_job_title_job_title_id_fk");

            entity.HasOne(d => d.Location).WithMany(p => p.PmMsMEmployeeLocations)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_location_location_id_fk");

            entity.HasOne(d => d.MaritalStatus).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("pm_ms_m_employee_pm_ms_m_marital_status_marital_status_id_fk");

            entity.HasOne(d => d.Organization).WithMany(p => p.PmMsMEmployees)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("pm_ms_m_employee_od_ms_m_organization_organization_id_fk");
        });

        modelBuilder.Entity<PmMsMFamilyRelationGrouping>(entity =>
        {
            entity.HasKey(e => e.FamilyRelationGroupingId).HasName("pm_ms_m_family_relation_grouping_pkey");

            entity.ToTable("pm_ms_m_family_relation_grouping");

            entity.HasIndex(e => e.FamilyRelationGroupingCode, "pm_ms_m_family_relation_grouping_pk").IsUnique();

            entity.Property(e => e.FamilyRelationGroupingId)
                .HasDefaultValueSql("nextval('pm_ms_m_family_relation_grouping_id_seq'::regclass)")
                .HasColumnName("family_relation_grouping_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FamilyRelationGroupingCode)
                .HasMaxLength(50)
                .HasColumnName("family_relation_grouping_code");
            entity.Property(e => e.FamilyRelationGroupingName)
                .HasMaxLength(200)
                .HasColumnName("family_relation_grouping_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMFamilyRelationType>(entity =>
        {
            entity.HasKey(e => e.FamilyRelationTypeId).HasName("pm_ms_m_family_relation_type_pkey");

            entity.ToTable("pm_ms_m_family_relation_type");

            entity.HasIndex(e => e.FamilyRelationTypeCode, "pm_ms_m_family_relation_type_pk").IsUnique();

            entity.Property(e => e.FamilyRelationTypeId)
                .HasDefaultValueSql("nextval('pm_ms_m_family_relation_type_id_seq'::regclass)")
                .HasColumnName("family_relation_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FamilyRelationGroupingId).HasColumnName("family_relation_grouping_id");
            entity.Property(e => e.FamilyRelationTypeCode)
                .HasMaxLength(50)
                .HasColumnName("family_relation_type_code");
            entity.Property(e => e.FamilyRelationTypeName)
                .HasMaxLength(200)
                .HasColumnName("family_relation_type_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.FamilyRelationGrouping).WithMany(p => p.PmMsMFamilyRelationTypes)
                .HasForeignKey(d => d.FamilyRelationGroupingId)
                .HasConstraintName("pm_ms_m_family_relation_type_pm_ms_m_family_relation_grouping_f");
        });

        modelBuilder.Entity<PmMsMHobby>(entity =>
        {
            entity.HasKey(e => e.HobbyId).HasName("pm_ms_m_hobby_pkey");

            entity.ToTable("pm_ms_m_hobby");

            entity.HasIndex(e => e.HobbyCode, "pm_ms_m_hobby_pk").IsUnique();

            entity.Property(e => e.HobbyId)
                .HasDefaultValueSql("nextval('pm_ms_m_hobby_id_seq'::regclass)")
                .HasColumnName("hobby_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.HobbyCode)
                .HasMaxLength(50)
                .HasColumnName("hobby_code");
            entity.Property(e => e.HobbyName)
                .HasMaxLength(200)
                .HasColumnName("hobby_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("pm_ms_m_language_pkey");

            entity.ToTable("pm_ms_m_language");

            entity.HasIndex(e => e.LanguageCode, "pm_ms_m_language_pk").IsUnique();

            entity.Property(e => e.LanguageId)
                .HasDefaultValueSql("nextval('pm_ms_m_hobby_id_seq'::regclass)")
                .HasColumnName("language_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(50)
                .HasColumnName("language_code");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(200)
                .HasColumnName("language_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMMaritalStatus>(entity =>
        {
            entity.HasKey(e => e.MaritalStatusId).HasName("pm_ms_m_marital_status_pkey");

            entity.ToTable("pm_ms_m_marital_status");

            entity.HasIndex(e => e.MaritalStatusCode, "pm_ms_m_marital_status_pk").IsUnique();

            entity.Property(e => e.MaritalStatusId)
                .HasDefaultValueSql("nextval('pm_ms_m_marital_status_id_seq'::regclass)")
                .HasColumnName("marital_status_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgShowInFamily)
                .HasMaxLength(1)
                .HasColumnName("fg_show_in_family");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.MaritalStatusCode)
                .HasMaxLength(50)
                .HasColumnName("marital_status_code");
            entity.Property(e => e.MaritalStatusName)
                .HasMaxLength(200)
                .HasColumnName("marital_status_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMRace>(entity =>
        {
            entity.HasKey(e => e.RaceId).HasName("pm_ms_m_race_pkey");

            entity.ToTable("pm_ms_m_race");

            entity.HasIndex(e => e.RaceCode, "pm_ms_m_race_pk").IsUnique();

            entity.Property(e => e.RaceId)
                .HasDefaultValueSql("nextval('pm_ms_m_race_id_seq'::regclass)")
                .HasColumnName("race_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.RaceCode)
                .HasMaxLength(50)
                .HasColumnName("race_code");
            entity.Property(e => e.RaceName)
                .HasMaxLength(200)
                .HasColumnName("race_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMReligion>(entity =>
        {
            entity.HasKey(e => e.ReligionId).HasName("pm_ms_m_religion_pkey");

            entity.ToTable("pm_ms_m_religion");

            entity.HasIndex(e => e.ReligionCode, "pm_ms_m_religion_pk").IsUnique();

            entity.Property(e => e.ReligionId)
                .HasDefaultValueSql("nextval('pm_ms_m_religion_id_seq'::regclass)")
                .HasColumnName("religion_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ReligionCode)
                .HasMaxLength(50)
                .HasColumnName("religion_code");
            entity.Property(e => e.ReligionName)
                .HasMaxLength(200)
                .HasColumnName("religion_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMResidenceStatus>(entity =>
        {
            entity.HasKey(e => e.ResidenceStatusId).HasName("pm_ms_m_residence_status_pkey");

            entity.ToTable("pm_ms_m_residence_status");

            entity.HasIndex(e => e.ResidenceStatusCode, "pm_ms_m_residence_status_pk").IsUnique();

            entity.Property(e => e.ResidenceStatusId)
                .HasDefaultValueSql("nextval('pm_ms_m_residence_status_id_seq'::regclass)")
                .HasColumnName("residence_status_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ResidenceStatusCode)
                .HasMaxLength(50)
                .HasColumnName("residence_status_code");
            entity.Property(e => e.ResidenceStatusName)
                .HasMaxLength(200)
                .HasColumnName("residence_status_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMSkill>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("pm_ms_m_skill_pkey");

            entity.ToTable("pm_ms_m_skill");

            entity.HasIndex(e => e.SkillCode, "pm_ms_m_skill_pk").IsUnique();

            entity.Property(e => e.SkillId)
                .HasDefaultValueSql("nextval('pm_ms_m_skill_id_seq'::regclass)")
                .HasColumnName("skill_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.SkillCode)
                .HasMaxLength(50)
                .HasColumnName("skill_code");
            entity.Property(e => e.SkillGroupId).HasColumnName("skill_group_id");
            entity.Property(e => e.SkillName)
                .HasMaxLength(200)
                .HasColumnName("skill_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.SkillGroup).WithMany(p => p.PmMsMSkills)
                .HasForeignKey(d => d.SkillGroupId)
                .HasConstraintName("pm_ms_m_skill_pm_ms_m_skill_group_skill_group_id_fk");
        });

        modelBuilder.Entity<PmMsMSkillGroup>(entity =>
        {
            entity.HasKey(e => e.SkillGroupId).HasName("pm_ms_m_skill_group_pkey");

            entity.ToTable("pm_ms_m_skill_group");

            entity.HasIndex(e => e.SkillGroupCode, "pm_ms_m_skill_group_pk").IsUnique();

            entity.Property(e => e.SkillGroupId)
                .HasDefaultValueSql("nextval('pm_ms_m_skill_group_id_seq'::regclass)")
                .HasColumnName("skill_group_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.SkillGroupCode)
                .HasMaxLength(50)
                .HasColumnName("skill_group_code");
            entity.Property(e => e.SkillGroupName)
                .HasMaxLength(200)
                .HasColumnName("skill_group_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMSocialMediaType>(entity =>
        {
            entity.HasKey(e => e.SocialMediaTypeId).HasName("pm_ms_m_social_media_type_pkey");

            entity.ToTable("pm_ms_m_social_media_type");

            entity.HasIndex(e => e.SocialMediaTypeCode, "pm_ms_m_social_media_type_pk").IsUnique();

            entity.Property(e => e.SocialMediaTypeId)
                .HasDefaultValueSql("nextval('pm_ms_m_social_media_type_id_seq'::regclass)")
                .HasColumnName("social_media_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.SocialMediaTypeCode)
                .HasMaxLength(50)
                .HasColumnName("social_media_type_code");
            entity.Property(e => e.SocialMediaTypeName)
                .HasMaxLength(200)
                .HasColumnName("social_media_type_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmMsMVaccineMaster>(entity =>
        {
            entity.HasKey(e => e.VaccineMasterId).HasName("pm_ms_m_vaccine_master_pkey");

            entity.ToTable("pm_ms_m_vaccine_master");

            entity.HasIndex(e => e.VaccineMasterCode, "pm_ms_m_vaccine_master_pk").IsUnique();

            entity.Property(e => e.VaccineMasterId)
                .HasDefaultValueSql("nextval('pm_ms_m_vaccine_master_id_seq'::regclass)")
                .HasColumnName("vaccine_master_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.VaccineMasterCode)
                .HasMaxLength(50)
                .HasColumnName("vaccine_master_code");
            entity.Property(e => e.VaccineMasterName)
                .HasMaxLength(200)
                .HasColumnName("vaccine_master_name");
        });

        modelBuilder.Entity<PmMsMVehicleOwnStatus>(entity =>
        {
            entity.HasKey(e => e.VehicleOwnStatusId).HasName("pm_ms_m_vehicle_own_status_pkey");

            entity.ToTable("pm_ms_m_vehicle_own_status");

            entity.HasIndex(e => e.VehicleOwnStatusCode, "pm_ms_m_vehicle_own_status_pk").IsUnique();

            entity.Property(e => e.VehicleOwnStatusId)
                .ValueGeneratedNever()
                .HasColumnName("vehicle_own_status_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.VehicleOwnStatusCode)
                .HasMaxLength(50)
                .HasColumnName("vehicle_own_status_code");
            entity.Property(e => e.VehicleOwnStatusName)
                .HasMaxLength(200)
                .HasColumnName("vehicle_own_status_name");
        });

        modelBuilder.Entity<PmMsMVehicleType>(entity =>
        {
            entity.HasKey(e => e.VehicleTypeId).HasName("pm_ms_m_vehicle_type_pkey");

            entity.ToTable("pm_ms_m_vehicle_type");

            entity.HasIndex(e => e.VehicleTypeCode, "pm_ms_m_vehicle_type_pk").IsUnique();

            entity.Property(e => e.VehicleTypeId)
                .HasDefaultValueSql("nextval('pm_ms_m_vehicle_type'::regclass)")
                .HasColumnName("vehicle_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.VehicleTypeCode)
                .HasMaxLength(50)
                .HasColumnName("vehicle_type_code");
            entity.Property(e => e.VehicleTypeName)
                .HasMaxLength(200)
                .HasColumnName("vehicle_type_name");
        });

        modelBuilder.Entity<PmPcnMNumberFormat>(entity =>
        {
            entity.HasKey(e => e.PcnNumberFormatId).HasName("pm_pcn_m_number_format_pkey");

            entity.ToTable("pm_pcn_m_number_format");

            entity.Property(e => e.PcnNumberFormatId).HasColumnName("pcn_number_format_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrentNumber)
                .HasMaxLength(200)
                .HasColumnName("current_number");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleName).HasColumnName("module_name");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .HasColumnName("month");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PcnNumberFormat)
                .HasMaxLength(200)
                .HasColumnName("pcn_number_format");
            entity.Property(e => e.PcnNumberFormatCode)
                .HasMaxLength(50)
                .HasColumnName("pcn_number_format_code");
            entity.Property(e => e.PcnTypeId).HasColumnName("pcn_type_id");
            entity.Property(e => e.Sequence)
                .HasMaxLength(200)
                .HasColumnName("sequence");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .HasColumnName("year");

            entity.HasOne(d => d.PcnType).WithMany(p => p.PmPcnMNumberFormats)
                .HasForeignKey(d => d.PcnTypeId)
                .HasConstraintName("pm_pcn_m_number_format_pcn_type_id_fkey");
        });

        modelBuilder.Entity<PmPcnMType>(entity =>
        {
            entity.HasKey(e => e.PcnTypeId).HasName("pm_pcn_m_type_pkey");

            entity.ToTable("pm_pcn_m_type");

            entity.Property(e => e.PcnTypeId).HasColumnName("pcn_type_id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgCompany)
                .HasMaxLength(1)
                .HasColumnName("fg_company");
            entity.Property(e => e.FgCostCentre)
                .HasMaxLength(1)
                .HasColumnName("fg_cost_centre");
            entity.Property(e => e.FgEmploymentType)
                .HasMaxLength(1)
                .HasColumnName("fg_employment_type");
            entity.Property(e => e.FgJobLevel)
                .HasMaxLength(1)
                .HasColumnName("fg_job_level");
            entity.Property(e => e.FgJobTitle)
                .HasMaxLength(1)
                .HasColumnName("fg_job_title");
            entity.Property(e => e.FgLocation)
                .HasMaxLength(1)
                .HasColumnName("fg_location");
            entity.Property(e => e.FgOrganization)
                .HasMaxLength(1)
                .HasColumnName("fg_organization");
            entity.Property(e => e.FgTypeDisplay)
                .HasMaxLength(1)
                .HasColumnName("fg_type_display");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.PcnTypeCode)
                .HasMaxLength(50)
                .HasColumnName("pcn_type_code");
            entity.Property(e => e.PcnTypeName)
                .HasMaxLength(200)
                .HasColumnName("pcn_type_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmPcnSMatrixType>(entity =>
        {
            entity.HasKey(e => e.MatrixTypeId).HasName("pm_pcn_s_matrix_type_pkey");

            entity.ToTable("pm_pcn_s_matrix_type");

            entity.Property(e => e.MatrixTypeId).HasColumnName("matrix_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.PcnTypeId).HasColumnName("pcn_type_id");
            entity.Property(e => e.PcnTypeIdAdditional).HasColumnName("pcn_type_id_additional");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.PcnType).WithMany(p => p.PmPcnSMatrixTypePcnTypes)
                .HasForeignKey(d => d.PcnTypeId)
                .HasConstraintName("pm_pcn_s_matrix_type_pcn_type_id_fkey");

            entity.HasOne(d => d.PcnTypeIdAdditionalNavigation).WithMany(p => p.PmPcnSMatrixTypePcnTypeIdAdditionalNavigations)
                .HasForeignKey(d => d.PcnTypeIdAdditional)
                .HasConstraintName("pm_pcn_s_matrix_type_pcn_type_id_additional_fkey");
        });

        modelBuilder.Entity<PmPcnSTypeTrustee>(entity =>
        {
            entity.HasKey(e => e.TypeTrusteeId).HasName("pm_pcn_s_type_trustee_pkey");

            entity.ToTable("pm_pcn_s_type_trustee");

            entity.Property(e => e.TypeTrusteeId).HasColumnName("type_trustee_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.PcnTypeId).HasColumnName("pcn_type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");

            entity.HasOne(d => d.PcnType).WithMany(p => p.PmPcnSTypeTrustees)
                .HasForeignKey(d => d.PcnTypeId)
                .HasConstraintName("pm_pcn_s_type_trustee_pm_pcn_m_type_null_fk");
        });

        modelBuilder.Entity<PmPcnTRequest>(entity =>
        {
            entity.HasKey(e => e.PcnRequestId).HasName("pm_pcn_t_request_pkey");

            entity.ToTable("pm_pcn_t_request");

            entity.Property(e => e.PcnRequestId).HasColumnName("pcn_request_id");
            entity.Property(e => e.ApprovalWorkflowHeaderId).HasColumnName("approval_workflow_header_id");
            entity.Property(e => e.BatchNo).HasColumnName("batch_no");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EditReason).HasColumnName("edit_reason");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("effective_date");
            entity.Property(e => e.FgOverMpp)
                .HasMaxLength(1)
                .HasColumnName("fg_over_mpp");
            entity.Property(e => e.FgPriority)
                .HasMaxLength(1)
                .HasColumnName("fg_priority");
            entity.Property(e => e.FgReview)
                .HasMaxLength(1)
                .HasColumnName("fg_review");
            entity.Property(e => e.FgSuspended)
                .HasMaxLength(1)
                .HasColumnName("fg_suspended");
            entity.Property(e => e.FgSync)
                .HasMaxLength(1)
                .HasColumnName("fg_sync");
            entity.Property(e => e.InitiatorType)
                .HasMaxLength(200)
                .HasColumnName("initiator_type");
            entity.Property(e => e.OverMppReason).HasColumnName("over_mpp_reason");
            entity.Property(e => e.PcnNumberFormat)
                .HasMaxLength(200)
                .HasColumnName("pcn_number_format");
            entity.Property(e => e.PcnTransactionNo)
                .HasMaxLength(200)
                .HasColumnName("pcn_transaction_no");
            entity.Property(e => e.PcnTypeId1).HasColumnName("pcn_type_id_1");
            entity.Property(e => e.PcnTypeId2).HasColumnName("pcn_type_id_2");
            entity.Property(e => e.PostingBy)
                .HasMaxLength(50)
                .HasColumnName("posting_by");
            entity.Property(e => e.PostingDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("posting_date");
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.SyncDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sync_date");
            entity.Property(e => e.SyncStatus)
                .HasMaxLength(200)
                .HasColumnName("sync_status");
            entity.Property(e => e.SyncronizedBy)
                .HasMaxLength(50)
                .HasColumnName("syncronized_by");
            entity.Property(e => e.SyncronizedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("syncronized_date");
            entity.Property(e => e.TransactionOtherNumber)
                .HasMaxLength(200)
                .HasColumnName("transaction_other_number");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.PmPcnTRequests)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("pm_pcn_t_request_od_ms_m_company_null_fk");

            entity.HasOne(d => d.PcnTypeId1Navigation).WithMany(p => p.PmPcnTRequestPcnTypeId1Navigations)
                .HasForeignKey(d => d.PcnTypeId1)
                .HasConstraintName("pm_pcn_t_request_pcn_type_id_1_fkey");

            entity.HasOne(d => d.PcnTypeId2Navigation).WithMany(p => p.PmPcnTRequestPcnTypeId2Navigations)
                .HasForeignKey(d => d.PcnTypeId2)
                .HasConstraintName("pm_pcn_t_request_pcn_type_id_2_fkey");
        });

        modelBuilder.Entity<PmPcnTRequestApproval>(entity =>
        {
            entity.HasKey(e => e.PcnRequestApprovalId).HasName("pm_pcn_t_request_approval_pkey");

            entity.ToTable("pm_pcn_t_request_approval");

            entity.Property(e => e.PcnRequestApprovalId).HasColumnName("pcn_request_approval_id");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalSequence)
                .HasMaxLength(200)
                .HasColumnName("approval_sequence");
            entity.Property(e => e.ApprovalTypeMappingId).HasColumnName("approval_type_mapping_id");
            entity.Property(e => e.ApproverId).HasColumnName("approver_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Decision)
                .HasMaxLength(200)
                .HasColumnName("decision");
            entity.Property(e => e.FgEmail)
                .HasMaxLength(1)
                .HasColumnName("fg_email");
            entity.Property(e => e.FgParalel)
                .HasMaxLength(1)
                .HasColumnName("fg_paralel");
            entity.Property(e => e.FgReader)
                .HasMaxLength(1)
                .HasColumnName("fg_reader");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.PcnRequestId).HasColumnName("pcn_request_id");
            entity.Property(e => e.Step)
                .HasMaxLength(200)
                .HasColumnName("step");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserLevelAlias)
                .HasMaxLength(200)
                .HasColumnName("user_level_alias");

            entity.HasOne(d => d.ApprovalTypeMapping).WithMany(p => p.PmPcnTRequestApprovals)
                .HasForeignKey(d => d.ApprovalTypeMappingId)
                .HasConstraintName("pm_pcn_t_request_approval_sm_flw_s_approval_type_mapping_null_f");

            entity.HasOne(d => d.Approver).WithMany(p => p.PmPcnTRequestApprovals)
                .HasForeignKey(d => d.ApproverId)
                .HasConstraintName("pm_pcn_t_request_approval_pm_ms_m_employee_null_fk");

            entity.HasOne(d => d.PcnRequest).WithMany(p => p.PmPcnTRequestApprovals)
                .HasForeignKey(d => d.PcnRequestId)
                .HasConstraintName("pcn_request_foreign_key_id");
        });

        modelBuilder.Entity<PmPcnTRequestApprovalMember>(entity =>
        {
            entity.HasKey(e => e.PcnApprovalMemberId).HasName("pm_pcn_t_request_approval_member_pkey");

            entity.ToTable("pm_pcn_t_request_approval_member");

            entity.Property(e => e.PcnApprovalMemberId).HasColumnName("pcn_approval_member_id");
            entity.Property(e => e.AlternateApproverId).HasColumnName("alternate_approver_id");
            entity.Property(e => e.ApprovalSequence).HasColumnName("approval_sequence");
            entity.Property(e => e.PcnRequestId).HasColumnName("pcn_request_id");
            entity.Property(e => e.Step)
                .HasMaxLength(50)
                .HasColumnName("step");
            entity.Property(e => e.UserLevelAlias)
                .HasMaxLength(50)
                .HasColumnName("user_level_alias");

            entity.HasOne(d => d.AlternateApprover).WithMany(p => p.PmPcnTRequestApprovalMembers)
                .HasForeignKey(d => d.AlternateApproverId)
                .HasConstraintName("pm_pcn_t_request_approval_member_pm_ms_m_employee_null_fk");

            entity.HasOne(d => d.PcnRequest).WithMany(p => p.PmPcnTRequestApprovalMembers)
                .HasForeignKey(d => d.PcnRequestId)
                .HasConstraintName("pm_pcn_t_request_approval_member_pcn_request_id_fkey");
        });

        modelBuilder.Entity<PmTrmMBenefit>(entity =>
        {
            entity.HasKey(e => e.BenefitId).HasName("pm_trm_m_benefit_pkey");

            entity.ToTable("pm_trm_m_benefit");

            entity.Property(e => e.BenefitId).HasColumnName("benefit_id");
            entity.Property(e => e.BenefitCode)
                .HasMaxLength(50)
                .HasColumnName("benefit_code");
            entity.Property(e => e.BenefitName)
                .HasMaxLength(200)
                .HasColumnName("benefit_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmTrmMExitType>(entity =>
        {
            entity.HasKey(e => e.ExitTypeId).HasName("pm_trm_m_exit_type_pkey");

            entity.ToTable("pm_trm_m_exit_type");

            entity.Property(e => e.ExitTypeId).HasColumnName("exit_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.ExitTypeCode)
                .HasMaxLength(50)
                .HasColumnName("exit_type_code");
            entity.Property(e => e.ExitTypeName)
                .HasMaxLength(200)
                .HasColumnName("exit_type_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PmTrmMNumberFormat>(entity =>
        {
            entity.HasKey(e => e.TerminationNumberFormatId).HasName("pm_trm_m_number_format_pkey");

            entity.ToTable("pm_trm_m_number_format");

            entity.Property(e => e.TerminationNumberFormatId).HasColumnName("termination_number_format_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrentNumber)
                .HasMaxLength(200)
                .HasColumnName("current_number");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .HasColumnName("month");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.TerminationNumberFormat)
                .HasMaxLength(200)
                .HasColumnName("termination_number_format");
            entity.Property(e => e.TerminationNumberFormatCode)
                .HasMaxLength(50)
                .HasColumnName("termination_number_format_code");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.PmTrmMNumberFormats)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_foreign_key_id");
        });

        modelBuilder.Entity<PmTrmMReason>(entity =>
        {
            entity.HasKey(e => e.ReasonId).HasName("pm_trm_m_reason_pkey");

            entity.ToTable("pm_trm_m_reason");

            entity.Property(e => e.ReasonId).HasColumnName("reason_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgEmailDefault)
                .HasMaxLength(1)
                .HasColumnName("fg_email_default");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ReasonAlias)
                .HasMaxLength(200)
                .HasColumnName("reason_alias");
            entity.Property(e => e.ReasonCategoryId).HasColumnName("reason_category_id");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(50)
                .HasColumnName("reason_code");
            entity.Property(e => e.ReasonName)
                .HasMaxLength(200)
                .HasColumnName("reason_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ReasonCategory).WithMany(p => p.PmTrmMReasons)
                .HasForeignKey(d => d.ReasonCategoryId)
                .HasConstraintName("reason_category_foreign_key_id");
        });

        modelBuilder.Entity<PmTrmMReasonCategory>(entity =>
        {
            entity.HasKey(e => e.ReasonCategoryId).HasName("pm_trm_m_reason_category_pkey");

            entity.ToTable("pm_trm_m_reason_category");

            entity.Property(e => e.ReasonCategoryId).HasColumnName("reason_category_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ReasonCategoryCode)
                .HasMaxLength(50)
                .HasColumnName("reason_category_code");
            entity.Property(e => e.ReasonCategoryName)
                .HasMaxLength(200)
                .HasColumnName("reason_category_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmAthMLoginUserList>(entity =>
        {
            entity.HasKey(e => e.LoginUserListId).HasName("sm_ath_m_login_user_list_pk");

            entity.ToTable("sm_ath_m_login_user_list");

            entity.Property(e => e.LoginUserListId)
                .HasDefaultValueSql("nextval('login_user_list_id_seq'::regclass)")
                .HasColumnName("login_user_list_id");
            entity.Property(e => e.BlockedEndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("blocked_end_time");
            entity.Property(e => e.BlockedReason).HasColumnName("blocked_reason");
            entity.Property(e => e.BlockedStartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("blocked_start_time");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .HasColumnName("company_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(200)
                .HasColumnName("employee_name");
            entity.Property(e => e.FgBlocked)
                .HasMaxLength(1)
                .HasColumnName("fg_blocked");
            entity.Property(e => e.FgEmployee)
                .HasMaxLength(1)
                .HasColumnName("fg_employee");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.JobLevelName)
                .HasMaxLength(200)
                .HasColumnName("job_level_name");
            entity.Property(e => e.JobTitleName)
                .HasMaxLength(200)
                .HasColumnName("job_title_name");
            entity.Property(e => e.LocationName)
                .HasMaxLength(200)
                .HasColumnName("location_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .HasColumnName("organization_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(200)
                .HasColumnName("user_email");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.UserLevelId).HasColumnName("user_level_id");
            entity.Property(e => e.UserPassword).HasColumnName("user_password");
            entity.Property(e => e.UserPin).HasColumnName("user_pin");
            entity.Property(e => e.UserTelp)
                .HasMaxLength(200)
                .HasColumnName("user_telp");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SmAthMLoginUserLists)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("sm_ath_m_login_user_list_sm_tst_m_user_group_null_fk");

            entity.HasOne(d => d.UserLevel).WithMany(p => p.SmAthMLoginUserLists)
                .HasForeignKey(d => d.UserLevelId)
                .HasConstraintName("sm_ath_m_login_user_list_sm_ath_m_user_level_null_fk");
        });

        modelBuilder.Entity<SmAthMUserLevel>(entity =>
        {
            entity.HasKey(e => e.UserLevelId).HasName("sm_ath_m_user_level_pk");

            entity.ToTable("sm_ath_m_user_level");

            entity.Property(e => e.UserLevelId)
                .HasDefaultValueSql("nextval('user_level_id_seq'::regclass)")
                .HasColumnName("user_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserLevelCode)
                .HasMaxLength(50)
                .HasColumnName("user_level_code");
            entity.Property(e => e.UserLevelName)
                .HasMaxLength(200)
                .HasColumnName("user_level_name");
        });

        modelBuilder.Entity<SmAthSUserLevelMapping>(entity =>
        {
            entity.HasKey(e => e.UserLevelMappingId).HasName("sm_ath_s_user_level_mapping_pk");

            entity.ToTable("sm_ath_s_user_level_mapping");

            entity.Property(e => e.UserLevelMappingId)
                .HasDefaultValueSql("nextval('user_level_mapping_id_seq'::regclass)")
                .HasColumnName("user_level_mapping_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgCore)
                .HasMaxLength(1)
                .HasColumnName("fg_core");
            entity.Property(e => e.FgEss)
                .HasMaxLength(1)
                .HasColumnName("fg_ess");
            entity.Property(e => e.FgMss)
                .HasMaxLength(1)
                .HasColumnName("fg_mss");
            entity.Property(e => e.FgSpecial)
                .HasMaxLength(1)
                .HasColumnName("fg_special");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.UserLevelId).HasColumnName("user_level_id");

            entity.HasOne(d => d.UserLevel).WithMany(p => p.SmAthSUserLevelMappings)
                .HasForeignKey(d => d.UserLevelId)
                .HasConstraintName("sm_ath_s_user_level_mapping_sm_ath_m_user_level_null_fk");
        });

        modelBuilder.Entity<SmAthSUserLevelMenuMapping>(entity =>
        {
            entity.HasKey(e => e.UserLevelMenuMappingId).HasName("sm_ath_s_user_level_menu_mapping_pk");

            entity.ToTable("sm_ath_s_user_level_menu_mapping");

            entity.Property(e => e.UserLevelMenuMappingId)
                .HasDefaultValueSql("nextval('user_level_menu_mapping_id_seq'::regclass)")
                .HasColumnName("user_level_menu_mapping_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgCore)
                .HasMaxLength(1)
                .HasColumnName("fg_core");
            entity.Property(e => e.FgEss)
                .HasMaxLength(1)
                .HasColumnName("fg_ess");
            entity.Property(e => e.FgMss)
                .HasMaxLength(1)
                .HasColumnName("fg_mss");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserLevelId).HasColumnName("user_level_id");

            entity.HasOne(d => d.UserLevel).WithMany(p => p.SmAthSUserLevelMenuMappings)
                .HasForeignKey(d => d.UserLevelId)
                .HasConstraintName("sm_ath_s_user_level_menu_mapping_sm_ath_m_user_level_null_fk");
        });

        modelBuilder.Entity<SmAthTLoginFailedAttempt>(entity =>
        {
            entity.HasKey(e => e.LoginFailedAttemptId).HasName("sm_ath_t_login_failed_attempt_pk");

            entity.ToTable("sm_ath_t_login_failed_attempt");

            entity.Property(e => e.LoginFailedAttemptId)
                .HasDefaultValueSql("nextval('login_failed_id_seq'::regclass)")
                .HasColumnName("login_failed_attempt_id");
            entity.Property(e => e.Browser)
                .HasMaxLength(200)
                .HasColumnName("browser");
            entity.Property(e => e.BrowserVersion)
                .HasMaxLength(200)
                .HasColumnName("browser_version");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(200)
                .HasColumnName("ip_address");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<SmAthTLoginSession>(entity =>
        {
            entity.HasKey(e => e.LoginSessionId).HasName("sm_ath_t_login_session_pk");

            entity.ToTable("sm_ath_t_login_session");

            entity.Property(e => e.LoginSessionId)
                .HasDefaultValueSql("nextval('login_session_id_seq'::regclass)")
                .HasColumnName("login_session_id");
            entity.Property(e => e.Browser)
                .HasMaxLength(200)
                .HasColumnName("browser");
            entity.Property(e => e.BrowserVersion)
                .HasMaxLength(200)
                .HasColumnName("browser_version");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(200)
                .HasColumnName("ip_address");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<SmCrMMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("sm_cr_m_menu_pk");

            entity.ToTable("sm_cr_m_menu");

            entity.Property(e => e.MenuId)
                .HasDefaultValueSql("nextval('menu_id_seq'::regclass)")
                .HasColumnName("menu_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FgContainer)
                .HasMaxLength(1)
                .HasColumnName("fg_container");
            entity.Property(e => e.IconMenu)
                .HasMaxLength(200)
                .HasColumnName("icon_menu");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.MenuCode)
                .HasMaxLength(50)
                .HasColumnName("menu_code");
            entity.Property(e => e.MenuGrouping)
                .HasMaxLength(50)
                .HasColumnName("menu_grouping");
            entity.Property(e => e.MenuName)
                .HasMaxLength(200)
                .HasColumnName("menu_name");
            entity.Property(e => e.ModuleCategory)
                .HasMaxLength(200)
                .HasColumnName("module_category");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.ParentMenuId).HasColumnName("parent_menu_id");
            entity.Property(e => e.PathMenu).HasColumnName("path_menu");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.UrlGuide).HasColumnName("url_guide");
        });

        modelBuilder.Entity<SmCrMMenuFeature>(entity =>
        {
            entity.HasKey(e => e.MenuFeatureId).HasName("sm_cr_m_menu_feature_pk");

            entity.ToTable("sm_cr_m_menu_feature");

            entity.Property(e => e.MenuFeatureId)
                .HasDefaultValueSql("nextval('menu_feature_id_seq'::regclass)")
                .HasColumnName("menu_feature_id");
            entity.Property(e => e.ActionName)
                .HasMaxLength(200)
                .HasColumnName("action_name");
            entity.Property(e => e.Controller)
                .HasMaxLength(200)
                .HasColumnName("controller");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FgDataCustom)
                .HasMaxLength(1)
                .HasColumnName("fg_data_custom");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.MenuFeatureCode)
                .HasMaxLength(50)
                .HasColumnName("menu_feature_code");
            entity.Property(e => e.MenuFeatureName)
                .HasMaxLength(200)
                .HasColumnName("menu_feature_name");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmCrMModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("sm_cr_m_module_pkey");

            entity.ToTable("sm_cr_m_module");

            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleAlias)
                .HasMaxLength(200)
                .HasColumnName("module_alias");
            entity.Property(e => e.ModuleCode)
                .HasMaxLength(50)
                .HasColumnName("module_code");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(200)
                .HasColumnName("module_name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmCrMModuleActivity>(entity =>
        {
            entity.HasKey(e => e.ModuleActivityId).HasName("sm_cr_m_module_activity_pkey");

            entity.ToTable("sm_cr_m_module_activity");

            entity.Property(e => e.ModuleActivityId).HasColumnName("module_activity_id");
            entity.Property(e => e.AdditionalCriteriaName)
                .HasMaxLength(200)
                .HasColumnName("additional_criteria_name");
            entity.Property(e => e.ApprovalWorkflowHeaderCode)
                .HasMaxLength(200)
                .HasColumnName("approval_workflow_header_code");
            entity.Property(e => e.AttributeName)
                .HasMaxLength(255)
                .HasColumnName("attribute_name");
            entity.Property(e => e.AttributeValue)
                .HasMaxLength(255)
                .HasColumnName("attribute_value");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(255)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleActivityCode)
                .HasMaxLength(255)
                .HasColumnName("module_activity_code");
            entity.Property(e => e.ModuleActivityName)
                .HasMaxLength(255)
                .HasColumnName("module_activity_name");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.WorkflowApprovalHeaderId).HasColumnName("workflow_approval_header_id");
            entity.Property(e => e.WorkflowCriteriaHeaderId).HasColumnName("workflow_criteria_header_id");

            entity.HasOne(d => d.Module).WithMany(p => p.SmCrMModuleActivities)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("sm_cr_m_module_activity_module_id_fkey");

            entity.HasOne(d => d.WorkflowApprovalHeader).WithMany(p => p.SmCrMModuleActivities)
                .HasForeignKey(d => d.WorkflowApprovalHeaderId)
                .HasConstraintName("sm_cr_m_module_activity_sm_flw_m_approval_workflow_header_null_");

            entity.HasOne(d => d.WorkflowCriteriaHeader).WithMany(p => p.SmCrMModuleActivities)
                .HasForeignKey(d => d.WorkflowCriteriaHeaderId)
                .HasConstraintName("sm_cr_m_module_activity_sm_flw_m_criteria_header_null_fk");
        });

        modelBuilder.Entity<SmFlwMApprovalTypeHeader>(entity =>
        {
            entity.HasKey(e => e.ApprovalTypeHeaderId).HasName("sm_flw_m_approval_type_header_pkey");

            entity.ToTable("sm_flw_m_approval_type_header");

            entity.Property(e => e.ApprovalTypeHeaderId).HasColumnName("approval_type_header_id");
            entity.Property(e => e.ApprovalTypeHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("approval_type_header_code");
            entity.Property(e => e.ApprovalTypeHeaderName)
                .HasMaxLength(200)
                .HasColumnName("approval_type_header_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Module).WithMany(p => p.SmFlwMApprovalTypeHeaders)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("module_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwMApprovalTypeHeaderAlias>(entity =>
        {
            entity.HasKey(e => e.ApprovalTypeHeaderAliasId).HasName("sm_flw_m_approval_type_header_alias_pkey");

            entity.ToTable("sm_flw_m_approval_type_header_alias");

            entity.Property(e => e.ApprovalTypeHeaderAliasId)
                .HasDefaultValueSql("nextval('sm_flw_m_approval_type_header_approval_type_header_alias_id_seq'::regclass)")
                .HasColumnName("approval_type_header_alias_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmFlwMApprovalTypeHeaderAliasDetail>(entity =>
        {
            entity.HasKey(e => e.ApprovalTypeHeaderAliasDetailId).HasName("sm_flw_m_approval_type_header_alias_detail_pkey");

            entity.ToTable("sm_flw_m_approval_type_header_alias_detail");

            entity.Property(e => e.ApprovalTypeHeaderAliasDetailId)
                .HasDefaultValueSql("nextval('sm_flw_m_approval_type_header_approval_type_header_alias_de_seq'::regclass)")
                .HasColumnName("approval_type_header_alias_detail_id");
            entity.Property(e => e.ApprovalTypeHeaderAliasHeaderId).HasColumnName("approval_type_header_alias_header_id");
            entity.Property(e => e.ApprovalTypeHeaderId).HasColumnName("approval_type_header_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ApprovalTypeHeaderAliasHeader).WithMany(p => p.SmFlwMApprovalTypeHeaderAliasDetails)
                .HasForeignKey(d => d.ApprovalTypeHeaderAliasHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("approval_type_header_alias_foreign_key_id");

            entity.HasOne(d => d.ApprovalTypeHeader).WithMany(p => p.SmFlwMApprovalTypeHeaderAliasDetails)
                .HasForeignKey(d => d.ApprovalTypeHeaderId)
                .HasConstraintName("approval_type_header_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwMApprovalWorkflowHeader>(entity =>
        {
            entity.HasKey(e => e.ApprovalWorkflowHeaderId).HasName("sm_flw_m_approval_workflow_header_pkey");

            entity.ToTable("sm_flw_m_approval_workflow_header");

            entity.Property(e => e.ApprovalWorkflowHeaderId)
                .HasDefaultValueSql("nextval('sm_flw_m_approval_workflow_head_approval_workflow_header_id_seq'::regclass)")
                .HasColumnName("approval_workflow_header_id");
            entity.Property(e => e.ApprovalWorkflowHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("approval_workflow_header_code");
            entity.Property(e => e.ApprovalWorkflowHeaderName)
                .HasMaxLength(200)
                .HasColumnName("approval_workflow_header_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.ModuleActivityId).HasColumnName("module_activity_id");
            entity.Property(e => e.TotalStep)
                .HasMaxLength(200)
                .HasColumnName("total_step");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmFlwMCriteriaDetail>(entity =>
        {
            entity.HasKey(e => e.CriteriaDetailId).HasName("sm_flw_m_criteria_detail_pkey");

            entity.ToTable("sm_flw_m_criteria_detail");

            entity.Property(e => e.CriteriaDetailId).HasColumnName("criteria_detail_id");
            entity.Property(e => e.AttendanceCode)
                .HasMaxLength(50)
                .HasColumnName("attendance_code");
            entity.Property(e => e.Attributes)
                .HasMaxLength(200)
                .HasColumnName("attributes");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CostCentreId).HasColumnName("cost_centre_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaHeaderId).HasColumnName("criteria_header_id");
            entity.Property(e => e.EmploymentTypeId).HasColumnName("employment_type_id");
            entity.Property(e => e.FamilyFunctionId).HasColumnName("family_function_id");
            entity.Property(e => e.FamilyRelationTypeId).HasColumnName("family_relation_type_id");
            entity.Property(e => e.FgInclude)
                .HasMaxLength(50)
                .HasColumnName("fg_include");
            entity.Property(e => e.FunctionId).HasColumnName("function_id");
            entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Nip)
                .HasMaxLength(50)
                .HasColumnName("nip");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.ShiftCode)
                .HasMaxLength(50)
                .HasColumnName("shift_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CriteriaHeader).WithMany(p => p.SmFlwMCriteriaDetails)
                .HasForeignKey(d => d.CriteriaHeaderId)
                .HasConstraintName("criteria_header_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwMCriteriaHeader>(entity =>
        {
            entity.HasKey(e => e.CriteriaHeaderId).HasName("sm_flw_m_criteria_header_pkey");

            entity.ToTable("sm_flw_m_criteria_header");

            entity.Property(e => e.CriteriaHeaderId).HasColumnName("criteria_header_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("criteria_header_code");
            entity.Property(e => e.CriteriaHeaderName)
                .HasMaxLength(200)
                .HasColumnName("criteria_header_name");
            entity.Property(e => e.CriteriaMasterId).HasColumnName("criteria_master_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FgAttendanceCode)
                .HasMaxLength(1)
                .HasColumnName("fg_attendance_code");
            entity.Property(e => e.FgAttributes)
                .HasMaxLength(1)
                .HasColumnName("fg_attributes");
            entity.Property(e => e.FgCity)
                .HasMaxLength(1)
                .HasColumnName("fg_city");
            entity.Property(e => e.FgCompany)
                .HasMaxLength(1)
                .HasColumnName("fg_company");
            entity.Property(e => e.FgCostCentre)
                .HasMaxLength(1)
                .HasColumnName("fg_cost_centre");
            entity.Property(e => e.FgCountry)
                .HasMaxLength(1)
                .HasColumnName("fg_country");
            entity.Property(e => e.FgEmploymentType)
                .HasMaxLength(1)
                .HasColumnName("fg_employment_type");
            entity.Property(e => e.FgFamilyRelation)
                .HasMaxLength(1)
                .HasColumnName("fg_family_relation");
            entity.Property(e => e.FgJobLevel)
                .HasMaxLength(1)
                .HasColumnName("fg_job_level");
            entity.Property(e => e.FgJobTitle)
                .HasMaxLength(1)
                .HasColumnName("fg_job_title");
            entity.Property(e => e.FgJobTitleFamFunction)
                .HasMaxLength(1)
                .HasColumnName("fg_job_title_fam_function");
            entity.Property(e => e.FgJobTitleFunction)
                .HasMaxLength(1)
                .HasColumnName("fg_job_title_function");
            entity.Property(e => e.FgLocation)
                .HasMaxLength(1)
                .HasColumnName("fg_location");
            entity.Property(e => e.FgNip)
                .HasMaxLength(1)
                .HasColumnName("fg_nip");
            entity.Property(e => e.FgOrganization)
                .HasMaxLength(1)
                .HasColumnName("fg_organization");
            entity.Property(e => e.FgShiftCode)
                .HasMaxLength(1)
                .HasColumnName("fg_shift_code");
            entity.Property(e => e.FgState)
                .HasMaxLength(1)
                .HasColumnName("fg_state");
            entity.Property(e => e.SuperiorLevel).HasColumnName("superior_level");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CriteriaMaster).WithMany(p => p.SmFlwMCriteriaHeaders)
                .HasForeignKey(d => d.CriteriaMasterId)
                .HasConstraintName("criteria_master_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwMCriteriaMaster>(entity =>
        {
            entity.HasKey(e => e.CriteriaMasterId).HasName("sm_flw_m_criteria_master_pkey");

            entity.ToTable("sm_flw_m_criteria_master");

            entity.Property(e => e.CriteriaMasterId).HasColumnName("criteria_master_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaMasterCode)
                .HasMaxLength(50)
                .HasColumnName("criteria_master_code");
            entity.Property(e => e.CriteriaMasterName)
                .HasMaxLength(200)
                .HasColumnName("criteria_master_name");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Module).WithMany(p => p.SmFlwMCriteriaMasters)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("module_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwMCriteriaMemberJobTitle>(entity =>
        {
            entity.HasKey(e => e.CriteriaMemberJobTitleId).HasName("sm_flw_m_criteria_member_job_title_pkey");

            entity.ToTable("sm_flw_m_criteria_member_job_title");

            entity.Property(e => e.CriteriaMemberJobTitleId)
                .HasDefaultValueSql("nextval('sm_flw_m_criteria_member_job_t_criteria_member_job_title_id_seq'::regclass)")
                .HasColumnName("criteria_member_job_title_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaHeaderId).HasColumnName("criteria_header_id");
            entity.Property(e => e.IsEnclude)
                .HasMaxLength(1)
                .HasColumnName("is_enclude");
            entity.Property(e => e.JobTitle).HasColumnName("job_title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CriteriaHeader).WithMany(p => p.SmFlwMCriteriaMemberJobTitles)
                .HasForeignKey(d => d.CriteriaHeaderId)
                .HasConstraintName("sm_flw_m_criteria_member_job_title_sm_flw_m_criteria_header_nul");

            entity.HasOne(d => d.JobTitleNavigation).WithMany(p => p.SmFlwMCriteriaMemberJobTitles)
                .HasForeignKey(d => d.JobTitle)
                .HasConstraintName("sm_flw_m_criteria_member_job_title_od_ms_m_job_title_null_fk");
        });

        modelBuilder.Entity<SmFlwMCriteriaMemberLocationType>(entity =>
        {
            entity.HasKey(e => e.CriteriaMemberLocationTypeId).HasName("sm_flw_m_criteria_member_location_type_pkey");

            entity.ToTable("sm_flw_m_criteria_member_location_type");

            entity.Property(e => e.CriteriaMemberLocationTypeId)
                .HasDefaultValueSql("nextval('sm_flw_m_criteria_member_loca_criteria_member_location_type_seq'::regclass)")
                .HasColumnName("criteria_member_location_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("criteria_header_code");
            entity.Property(e => e.IsEnclude)
                .HasMaxLength(1)
                .HasColumnName("is_enclude");
            entity.Property(e => e.LocationType)
                .HasMaxLength(200)
                .HasColumnName("location_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmFlwMCriteriaMemberOrgLevel>(entity =>
        {
            entity.HasKey(e => e.CriteriaMemberOrgLevelId).HasName("sm_flw_m_criteria_member_org_level_pkey");

            entity.ToTable("sm_flw_m_criteria_member_org_level");

            entity.Property(e => e.CriteriaMemberOrgLevelId)
                .HasDefaultValueSql("nextval('sm_flw_m_criteria_member_org_l_criteria_member_org_level_id_seq'::regclass)")
                .HasColumnName("criteria_member_org_level_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CriteriaHeaderId).HasColumnName("criteria_header_id");
            entity.Property(e => e.IsEnclude)
                .HasMaxLength(1)
                .HasColumnName("is_enclude");
            entity.Property(e => e.OrgLevel)
                .HasMaxLength(200)
                .HasColumnName("org_level");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CriteriaHeader).WithMany(p => p.SmFlwMCriteriaMemberOrgLevels)
                .HasForeignKey(d => d.CriteriaHeaderId)
                .HasConstraintName("sm_flw_m_criteria_member_org_level_sm_flw_m_criteria_header_nul");
        });

        modelBuilder.Entity<SmFlwMEmpSuperior>(entity =>
        {
            entity.HasKey(e => e.EmpSuperiorId).HasName("sm_flw_m_emp_superior_pkey");

            entity.ToTable("sm_flw_m_emp_superior");

            entity.Property(e => e.EmpSuperiorId).HasColumnName("emp_superior_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.SuperiorId).HasColumnName("superior_id");
            entity.Property(e => e.SuperiorLevel).HasColumnName("superior_level");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Employee).WithMany(p => p.SmFlwMEmpSuperiorEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("sm_flw_m_emp_superior_pm_ms_m_employee_null_fk");

            entity.HasOne(d => d.Superior).WithMany(p => p.SmFlwMEmpSuperiorSuperiors)
                .HasForeignKey(d => d.SuperiorId)
                .HasConstraintName("sm_flw_m_emp_superior_pm_ms_m_employee_employee_id_fk");
        });

        modelBuilder.Entity<SmFlwSApprovalMapping>(entity =>
        {
            entity.HasKey(e => e.ApprovalMappingId).HasName("sm_flw_s_approval_mapping_pkey");

            entity.ToTable("sm_flw_s_approval_mapping");

            entity.Property(e => e.ApprovalMappingId).HasColumnName("approval_mapping_id");
            entity.Property(e => e.ApprovalMappingName)
                .HasMaxLength(200)
                .HasColumnName("approval_mapping_name");
            entity.Property(e => e.ApprovalTypeHeaderId).HasColumnName("approval_type_header_id");
            entity.Property(e => e.ApproverCriteriaId).HasColumnName("approver_criteria_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmpCriteriaId).HasColumnName("emp_criteria_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.IsActiveEmp)
                .HasMaxLength(1)
                .HasColumnName("is_active_emp");
            entity.Property(e => e.IsEmail)
                .HasMaxLength(1)
                .HasColumnName("is_email");
            entity.Property(e => e.IsTrustee)
                .HasMaxLength(1)
                .HasColumnName("is_trustee");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ApprovalTypeHeader).WithMany(p => p.SmFlwSApprovalMappings)
                .HasForeignKey(d => d.ApprovalTypeHeaderId)
                .HasConstraintName("approval_type_header_foreign_key_id");
        });

        modelBuilder.Entity<SmFlwSApprovalTypeMapping>(entity =>
        {
            entity.HasKey(e => e.ApprovalMappingId).HasName("sm_flw_s_approval_type_mapping_pkey");

            entity.ToTable("sm_flw_s_approval_type_mapping");

            entity.Property(e => e.ApprovalMappingId).HasColumnName("approval_mapping_id");
            entity.Property(e => e.ApprovalTypeHeaderName)
                .HasMaxLength(200)
                .HasColumnName("approval_type_header_name");
            entity.Property(e => e.ApproverCriteriaId)
                .HasMaxLength(200)
                .HasColumnName("approver_criteria_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmpCriteriaId)
                .HasMaxLength(200)
                .HasColumnName("emp_criteria_id");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.IsActiveEmp)
                .HasMaxLength(1)
                .HasColumnName("is_active_emp");
            entity.Property(e => e.IsTrustee)
                .HasMaxLength(1)
                .HasColumnName("is_trustee");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmFlwSApprovalWorkflowTemplate>(entity =>
        {
            entity.HasKey(e => e.ApprovalWorkflowTemplateId).HasName("sm_flw_s_approval_workflow_template_pkey");

            entity.ToTable("sm_flw_s_approval_workflow_template");

            entity.Property(e => e.ApprovalWorkflowTemplateId)
                .HasDefaultValueSql("nextval('sm_flw_s_approval_workflow_te_approval_workflow_template_id_seq'::regclass)")
                .HasColumnName("approval_workflow_template_id");
            entity.Property(e => e.ApprovalMappingId).HasColumnName("approval_mapping_id");
            entity.Property(e => e.ApprovalWorkflowHeaderId).HasColumnName("approval_workflow_header_id");
            entity.Property(e => e.ApproverTypeHeaderId).HasColumnName("approver_type_header_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgPararel)
                .HasMaxLength(1)
                .HasColumnName("fg_pararel");
            entity.Property(e => e.JumpDecis1)
                .HasMaxLength(200)
                .HasColumnName("jump_decis_1");
            entity.Property(e => e.JumpDecis2)
                .HasMaxLength(200)
                .HasColumnName("jump_decis_2");
            entity.Property(e => e.JumpDecis3)
                .HasMaxLength(200)
                .HasColumnName("jump_decis_3");
            entity.Property(e => e.JumpDecis4)
                .HasMaxLength(200)
                .HasColumnName("jump_decis_4");
            entity.Property(e => e.JumpDecis5)
                .HasMaxLength(200)
                .HasColumnName("jump_decis_5");
            entity.Property(e => e.JumpTo1)
                .HasMaxLength(200)
                .HasColumnName("jump_to_1");
            entity.Property(e => e.JumpTo2)
                .HasMaxLength(200)
                .HasColumnName("jump_to_2");
            entity.Property(e => e.JumpTo3)
                .HasMaxLength(200)
                .HasColumnName("jump_to_3");
            entity.Property(e => e.JumpTo4)
                .HasMaxLength(200)
                .HasColumnName("jump_to_4");
            entity.Property(e => e.JumpTo5)
                .HasMaxLength(200)
                .HasColumnName("jump_to_5");
            entity.Property(e => e.MaxSendBack)
                .HasMaxLength(200)
                .HasColumnName("max_send_back");
            entity.Property(e => e.SequenceFlow)
                .HasMaxLength(200)
                .HasColumnName("sequence_flow");
            entity.Property(e => e.Step)
                .HasMaxLength(200)
                .HasColumnName("step");
            entity.Property(e => e.TimeOutMinute)
                .HasMaxLength(200)
                .HasColumnName("time_out_minute");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserLevelAlias)
                .HasMaxLength(200)
                .HasColumnName("user_level_alias");

            entity.HasOne(d => d.ApprovalMapping).WithMany(p => p.SmFlwSApprovalWorkflowTemplates)
                .HasForeignKey(d => d.ApprovalMappingId)
                .HasConstraintName("sm_flw_s_approval_workflow_template_sm_flw_s_approval_type_mapp");
        });

        modelBuilder.Entity<SmFlwTApprovalAccess>(entity =>
        {
            entity.HasKey(e => e.ApproverAccessId).HasName("sm_flw_t_approval_access_pkey");

            entity.ToTable("sm_flw_t_approval_access");

            entity.Property(e => e.ApproverAccessId).HasColumnName("approver_access_id");
            entity.Property(e => e.ApproverId)
                .HasMaxLength(255)
                .HasColumnName("approver_id");
            entity.Property(e => e.ApproverTypeHeaderId).HasColumnName("approver_type_header_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("employee_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmFlwTApprovalWorkflowTransaction>(entity =>
        {
            entity.HasKey(e => e.ApprovalWorkflowTransactionId).HasName("sm_flw_t_approval_workflow_transaction_pkey");

            entity.ToTable("sm_flw_t_approval_workflow_transaction");

            entity.Property(e => e.ApprovalWorkflowTransactionId)
                .HasDefaultValueSql("nextval('sm_flw_t_approval_workflow_tr_approval_workflow_transaction_seq'::regclass)")
                .HasColumnName("approval_workflow_transaction_id");
            entity.Property(e => e.ApprovalWorkflowHeaderId).HasColumnName("approval_workflow_header_id");
            entity.Property(e => e.ApproverId)
                .HasMaxLength(50)
                .HasColumnName("approver_id");
            entity.Property(e => e.CountSendBack)
                .HasMaxLength(200)
                .HasColumnName("count_send_back");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Decision)
                .HasMaxLength(200)
                .HasColumnName("decision");
            entity.Property(e => e.DecisionTo)
                .HasMaxLength(200)
                .HasColumnName("decision_to");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("employee_id");
            entity.Property(e => e.FgPararel)
                .HasMaxLength(1)
                .HasColumnName("fg_pararel");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.SequenceFlow)
                .HasMaxLength(200)
                .HasColumnName("sequence_flow");
            entity.Property(e => e.Step)
                .HasMaxLength(200)
                .HasColumnName("step");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserLevelAlias)
                .HasMaxLength(200)
                .HasColumnName("user_level_alias");
        });

        modelBuilder.Entity<SmNumMMappingAttribute>(entity =>
        {
            entity.HasKey(e => e.MappingAttributeId).HasName("sm_num_m_mapping_attribute_pkey");

            entity.ToTable("sm_num_m_mapping_attribute");

            entity.Property(e => e.MappingAttributeId).HasColumnName("mapping_attribute_id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(255)
                .HasColumnName("attribute");
            entity.Property(e => e.AttributeFieldType)
                .HasMaxLength(255)
                .HasColumnName("attribute_field_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasMaxLength(255)
                .HasColumnName("is_active");
            entity.Property(e => e.Legend)
                .HasMaxLength(255)
                .HasColumnName("legend");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Module).WithMany(p => p.SmNumMMappingAttributes)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("sm_num_m_mapping_attribute_module_id_fkey");
        });

        modelBuilder.Entity<SmNumMMasterNumberFormat>(entity =>
        {
            entity.HasKey(e => e.MasterNumberFormatId).HasName("sm_num_m_master_number_format_pkey");

            entity.ToTable("sm_num_m_master_number_format");

            entity.Property(e => e.MasterNumberFormatId).HasColumnName("master_number_format_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.MappingAttributeId).HasColumnName("mapping_attribute_id");
            entity.Property(e => e.Separator)
                .HasMaxLength(255)
                .HasColumnName("separator");
            entity.Property(e => e.Sequence)
                .HasMaxLength(255)
                .HasColumnName("sequence");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.MappingAttribute).WithMany(p => p.SmNumMMasterNumberFormats)
                .HasForeignKey(d => d.MappingAttributeId)
                .HasConstraintName("sm_num_m_master_number_format_mapping_attribute_id_fkey");
        });

        modelBuilder.Entity<SmTstMTrusteeAliasHeader>(entity =>
        {
            entity.HasKey(e => e.TrusteeAliasHeaderId).HasName("sm_tst_m_trustee_alias_header_pk");

            entity.ToTable("sm_tst_m_trustee_alias_header");

            entity.Property(e => e.TrusteeAliasHeaderId).HasColumnName("trustee_alias_header_id");
            entity.Property(e => e.BehaviourType)
                .HasMaxLength(200)
                .HasColumnName("behaviour_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgTrusteeByCompany)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_company");
            entity.Property(e => e.FgTrusteeByJobLevel)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_job_level");
            entity.Property(e => e.FgTrusteeByJobTitle)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_job_title");
            entity.Property(e => e.FgTrusteeByLocation)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_location");
            entity.Property(e => e.FgTrusteeByOrganization)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_organization");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.TrusteeAliasHeaderCode)
                .HasMaxLength(50)
                .HasColumnName("trustee_alias_header_code");
            entity.Property(e => e.TrusteeAliasHeaderName)
                .HasMaxLength(200)
                .HasColumnName("trustee_alias_header_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmTstMTrusteeAliasMember>(entity =>
        {
            entity.HasKey(e => e.TrusteeAliasMemberId).HasName("sm_tst_m_trustee_alias_member_pkey");

            entity.ToTable("sm_tst_m_trustee_alias_member");

            entity.Property(e => e.TrusteeAliasMemberId).HasColumnName("trustee_alias_member_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(50)
                .HasColumnName("employee_code");
            entity.Property(e => e.TrusteeAliasHeaderId).HasColumnName("trustee_alias_header_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.TrusteeAliasHeader).WithMany(p => p.SmTstMTrusteeAliasMembers)
                .HasForeignKey(d => d.TrusteeAliasHeaderId)
                .HasConstraintName("sm_tst_m_trustee_alias_member_trustee_alias_header_id_fkey");
        });

        modelBuilder.Entity<SmTstMUserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("sm_tst_m_user_group_pk");

            entity.ToTable("sm_tst_m_user_group");

            entity.Property(e => e.UserGroupId)
                .HasDefaultValueSql("nextval('user_group_id_seq'::regclass)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgTrusteeByCompany)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_company");
            entity.Property(e => e.FgTrusteeByJobLevel)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_job_level");
            entity.Property(e => e.FgTrusteeByJobTitle)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_job_title");
            entity.Property(e => e.FgTrusteeByLocation)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_location");
            entity.Property(e => e.FgTrusteeByOrganization)
                .HasMaxLength(1)
                .HasColumnName("fg_trustee_by_organization");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasColumnName("is_active");
            entity.Property(e => e.OnChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_change_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserGroupCode)
                .HasMaxLength(50)
                .HasColumnName("user_group_code");
            entity.Property(e => e.UserGroupName)
                .HasMaxLength(200)
                .HasColumnName("user_group_name");
        });

        modelBuilder.Entity<SmTstSTrusteeAliasData>(entity =>
        {
            entity.HasKey(e => e.TrusteeAliasDataId).HasName("sm_tst_s_trustee_alias_data_pk");

            entity.ToTable("sm_tst_s_trustee_alias_data");

            entity.Property(e => e.TrusteeAliasDataId)
                .HasDefaultValueSql("nextval('trustee_alias_data_id_seq'::regclass)")
                .HasColumnName("trustee_alias_data_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.TrusteeAliasHeaderId).HasColumnName("trustee_alias_header_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_od_ms_m_company_null_fk");

            entity.HasOne(d => d.JobLevel).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.JobLevelId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_od_ms_m_job_level_null_fk");

            entity.HasOne(d => d.JobTitle).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.JobTitleId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_od_ms_m_job_title_null_fk");

            entity.HasOne(d => d.Location).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_od_ms_m_location_null_fk");

            entity.HasOne(d => d.Organization).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_od_ms_m_organization_null_fk");

            entity.HasOne(d => d.TrusteeAliasHeader).WithMany(p => p.SmTstSTrusteeAliasData)
                .HasForeignKey(d => d.TrusteeAliasHeaderId)
                .HasConstraintName("sm_tst_s_trustee_alias_data_sm_tst_m_trustee_alias_header_null_");
        });

        modelBuilder.Entity<SmTstSUserGroupData>(entity =>
        {
            entity.HasKey(e => e.UserGroupDataId).HasName("sm_tst_s_user_group_data_pk");

            entity.ToTable("sm_tst_s_user_group_data");

            entity.Property(e => e.UserGroupDataId)
                .HasDefaultValueSql("nextval('user_group_data_id_seq'::regclass)")
                .HasColumnName("user_group_data_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("effective_date");
            entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SmTstSUserGroupData)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("sm_tst_s_user_group_data_sm_tst_m_user_group_null_fk");
        });

        modelBuilder.Entity<SmTstSUserGroupMenu>(entity =>
        {
            entity.HasKey(e => e.UserGroupMenuId).HasName("sm_tst_s_user_group_menu_pk");

            entity.ToTable("sm_tst_s_user_group_menu");

            entity.Property(e => e.UserGroupMenuId)
                .HasDefaultValueSql("nextval('user_group_menu_id_seq'::regclass)")
                .HasColumnName("user_group_menu_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

            entity.HasOne(d => d.Menu).WithMany(p => p.SmTstSUserGroupMenus)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("sm_tst_s_user_group_menu_sm_cr_m_menu_null_fk");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SmTstSUserGroupMenus)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("sm_tst_s_user_group_menu_sm_tst_m_user_group_null_fk");
        });

        modelBuilder.Entity<SmTstSUserGroupMenuFeature>(entity =>
        {
            entity.HasKey(e => e.UserGroupMenuFeatureId).HasName("sm_tst_s_user_group_menu_feature_pk");

            entity.ToTable("sm_tst_s_user_group_menu_feature");

            entity.Property(e => e.UserGroupMenuFeatureId)
                .HasDefaultValueSql("nextval('user_group_menu_feature_id_seq'::regclass)")
                .HasColumnName("user_group_menu_feature_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.MenuFeatureId).HasColumnName("menu_feature_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

            entity.HasOne(d => d.MenuFeature).WithMany(p => p.SmTstSUserGroupMenuFeatures)
                .HasForeignKey(d => d.MenuFeatureId)
                .HasConstraintName("sm_tst_s_user_group_menu_feature_sm_cr_m_menu_feature_null_fk");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SmTstSUserGroupMenuFeatures)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("sm_tst_s_user_group_menu_feature_sm_tst_m_user_group_null_fk");
        });

        modelBuilder.Entity<SmTstSUserTrusteeDataCriteria>(entity =>
        {
            entity.HasKey(e => e.UserTrusteeDataCriteriaId).HasName("sm_tst_s_user_trustee_data_criteria_pkey");

            entity.ToTable("sm_tst_s_user_trustee_data_criteria");

            entity.Property(e => e.UserTrusteeDataCriteriaId)
                .HasDefaultValueSql("nextval('sm_tst_s_user_trustee_data_cr_user_trustee_data_criteria_id_seq'::regclass)")
                .HasColumnName("user_trustee_data_criteria_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgCompany)
                .HasMaxLength(1)
                .HasColumnName("fg_company");
            entity.Property(e => e.FgJobLevel)
                .HasMaxLength(1)
                .HasColumnName("fg_job_level");
            entity.Property(e => e.FgJobTitle)
                .HasMaxLength(1)
                .HasColumnName("fg_job_title");
            entity.Property(e => e.FgLocation)
                .HasMaxLength(1)
                .HasColumnName("fg_location");
            entity.Property(e => e.FgOrganization)
                .HasMaxLength(1)
                .HasColumnName("fg_organization");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<SmTstSUserTrusteeData>(entity =>
        {
            entity.HasKey(e => e.UserTrusteeDataId).HasName("sm_tst_s_user_trustee_data_pk");

            entity.ToTable("sm_tst_s_user_trustee_data");

            entity.Property(e => e.UserTrusteeDataId)
                .HasDefaultValueSql("nextval('user_trustee_data_id_seq'::regclass)")
                .HasColumnName("user_trustee_data_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.FgExceptional)
                .HasMaxLength(1)
                .HasColumnName("fg_exceptional");
            entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TrustExceptEffectiveDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("trust_except_effective_date");
            entity.Property(e => e.TrustExceptExpiredDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("trust_except_expired_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SmTstSUserTrusteeData)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("sm_tst_s_user_trustee_data_sm_tst_m_user_group_null_fk");
        });

        modelBuilder.Entity<SmTstSUserTrusteeMenu>(entity =>
        {
            entity.HasKey(e => e.UserTrusteeMenuId).HasName("sm_tst_s_user_trustee_menu_pk");

            entity.ToTable("sm_tst_s_user_trustee_menu");

            entity.Property(e => e.UserTrusteeMenuId)
                .HasDefaultValueSql("nextval('user_trustee_menu_id_seq'::regclass)")
                .HasColumnName("user_trustee_menu_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DataType)
                .HasMaxLength(200)
                .HasColumnName("data_type");
            entity.Property(e => e.FgDeleted)
                .HasMaxLength(1)
                .HasColumnName("fg_deleted");
            entity.Property(e => e.FgModified)
                .HasMaxLength(1)
                .HasColumnName("fg_modified");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.TrusteeAliasMemberId).HasColumnName("trustee_alias_member_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");

            entity.HasOne(d => d.Menu).WithMany(p => p.SmTstSUserTrusteeMenus)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("sm_tst_s_user_trustee_menu_sm_cr_m_menu_null_fk");

            entity.HasOne(d => d.TrusteeAliasMember).WithMany(p => p.SmTstSUserTrusteeMenus)
                .HasForeignKey(d => d.TrusteeAliasMemberId)
                .HasConstraintName("sm_tst_s_user_trustee_menu_member_fg_key_id");
        });

        modelBuilder.Entity<SmTstSUserTrusteeMenuFeature>(entity =>
        {
            entity.HasKey(e => e.UserTrusteeMenuFeatureId).HasName("sm_tst_s_user_trustee_menu_feature_pk");

            entity.ToTable("sm_tst_s_user_trustee_menu_feature");

            entity.Property(e => e.UserTrusteeMenuFeatureId)
                .HasDefaultValueSql("nextval('user_trustee_menu_feature_id_seq'::regclass)")
                .HasColumnName("user_trustee_menu_feature_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.DataType)
                .HasMaxLength(200)
                .HasColumnName("data_type");
            entity.Property(e => e.FgDeleted)
                .HasMaxLength(1)
                .HasColumnName("fg_deleted");
            entity.Property(e => e.FgModified)
                .HasMaxLength(1)
                .HasColumnName("fg_modified");
            entity.Property(e => e.MenuFeatureId).HasColumnName("menu_feature_id");
            entity.Property(e => e.TrusteeAliasMemberId).HasColumnName("trustee_alias_member_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");

            entity.HasOne(d => d.MenuFeature).WithMany(p => p.SmTstSUserTrusteeMenuFeatures)
                .HasForeignKey(d => d.MenuFeatureId)
                .HasConstraintName("sm_tst_s_user_trustee_menu_feature_sm_cr_m_menu_feature_null_fk");

            entity.HasOne(d => d.TrusteeAliasMember).WithMany(p => p.SmTstSUserTrusteeMenuFeatures)
                .HasForeignKey(d => d.TrusteeAliasMemberId)
                .HasConstraintName("sm_tst_s_user_trustee_menu_feature_sm_tst_m_trustee_alias_heade");
        });
        modelBuilder.HasSequence<int>("CR_OD_M_CompanyGroup_companyGroupId_seq");
        modelBuilder.HasSequence<int>("CR_OD_M_GroupPosition_groupPositionId_seq");
        modelBuilder.HasSequence("document_type_id_document_type_seq");
        modelBuilder.HasSequence("login_failed_id_seq");
        modelBuilder.HasSequence("login_session_id_seq");
        modelBuilder.HasSequence("login_user_list_id_seq");
        modelBuilder.HasSequence("menu_feature_id_seq");
        modelBuilder.HasSequence("menu_id_seq");
        modelBuilder.HasSequence("new_sequence_name").HasMax(100000000L);
        modelBuilder.HasSequence("od_ms_m_company_group_id_seq");
        modelBuilder.HasSequence("od_ms_m_company_id_seq");
        modelBuilder.HasSequence("od_ms_m_company_outsource_group_id_seq");
        modelBuilder.HasSequence("od_ms_m_company_outsource_id_seq");
        modelBuilder.HasSequence("od_ms_m_cost_centre_id_seq");
        modelBuilder.HasSequence("od_ms_m_country_id_seq");
        modelBuilder.HasSequence("od_ms_m_employment_type_group_id_seq");
        modelBuilder.HasSequence("od_ms_m_employment_type_id_seq");
        modelBuilder.HasSequence("od_ms_m_family_function_id_seq");
        modelBuilder.HasSequence("od_ms_m_function_id_seq");
        modelBuilder.HasSequence("od_ms_m_group_position_id_seq");
        modelBuilder.HasSequence("od_ms_m_grouping_detail_id_seq");
        modelBuilder.HasSequence("od_ms_m_grouping_header_id_seq");
        modelBuilder.HasSequence("od_ms_m_job_level_id_seq");
        modelBuilder.HasSequence("od_ms_m_job_title_family_id_seq");
        modelBuilder.HasSequence("od_ms_m_job_title_id_seq");
        modelBuilder.HasSequence("od_ms_m_job_title_organization_level_id_seq");
        modelBuilder.HasSequence("od_ms_m_location_group_id_seq");
        modelBuilder.HasSequence("od_ms_m_location_id_seq");
        modelBuilder.HasSequence("od_ms_m_location_type_id_seq");
        modelBuilder.HasSequence("od_ms_m_organization_group_id_seq");
        modelBuilder.HasSequence("od_ms_m_organization_id_seq");
        modelBuilder.HasSequence("od_ms_m_organization_level_id_seq");
        modelBuilder.HasSequence("od_ms_m_store_id_seq");
        modelBuilder.HasSequence("od_ms_m_store_pic_id_seq");
        modelBuilder.HasSequence("od_ms_m_store_pic_type_id_seq");
        modelBuilder.HasSequence("pm_ms_m_bank_id_seq");
        modelBuilder.HasSequence("pm_ms_m_company_bank_id_seq");
        modelBuilder.HasSequence("pm_ms_m_currency_id_seq");
        modelBuilder.HasSequence("pm_ms_m_document_type_group_id_seq");
        modelBuilder.HasSequence("pm_ms_m_document_type_id_seq");
        modelBuilder.HasSequence("pm_ms_m_education_institution_id_seq");
        modelBuilder.HasSequence("pm_ms_m_education_level_id_seq");
        modelBuilder.HasSequence("pm_ms_m_education_major_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_address_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_document_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_education_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_email_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_emer_contact_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_ext_organization_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_family_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_hobby_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_job_experience_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_language_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_other_document_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_personal_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_phone_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_skill_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_social_media_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_vaccine_id_seq");
        modelBuilder.HasSequence("pm_ms_m_employee_vehicle_id_seq");
        modelBuilder.HasSequence("pm_ms_m_family_relation_grouping_id_seq");
        modelBuilder.HasSequence("pm_ms_m_family_relation_type_id_seq");
        modelBuilder.HasSequence("pm_ms_m_hobby_id_seq");
        modelBuilder.HasSequence("pm_ms_m_language_id_seq");
        modelBuilder.HasSequence("pm_ms_m_marital_status_id_seq");
        modelBuilder.HasSequence("pm_ms_m_race_id_seq");
        modelBuilder.HasSequence("pm_ms_m_religion_id_seq");
        modelBuilder.HasSequence("pm_ms_m_residence_status_id_seq");
        modelBuilder.HasSequence("pm_ms_m_skill_group_id_seq");
        modelBuilder.HasSequence("pm_ms_m_skill_id_seq");
        modelBuilder.HasSequence("pm_ms_m_social_media_type_id_seq");
        modelBuilder.HasSequence("pm_ms_m_vaccine_master_id_seq");
        modelBuilder.HasSequence("pm_ms_m_vehicle_type_id_seq");
        modelBuilder.HasSequence("sm_flw_m_approval_type_header_approval_type_header_id_seq");
        modelBuilder.HasSequence("test_id_seq").HasMin(15L);
        modelBuilder.HasSequence("trustee_alias_data_id_seq");
        modelBuilder.HasSequence("user_employee_trustee_id_seq");
        modelBuilder.HasSequence("user_group_data_id_seq");
        modelBuilder.HasSequence("user_group_id_seq");
        modelBuilder.HasSequence("user_group_menu_feature_id_seq");
        modelBuilder.HasSequence("user_group_menu_id_seq");
        modelBuilder.HasSequence("user_level_id_seq");
        modelBuilder.HasSequence("user_level_mapping_id_seq");
        modelBuilder.HasSequence("user_level_menu_mapping_id_seq");
        modelBuilder.HasSequence("user_trustee_data_id_seq");
        modelBuilder.HasSequence("user_trustee_exception_data_id_seq");
        modelBuilder.HasSequence("user_trustee_menu_feature_id_seq");
        modelBuilder.HasSequence("user_trustee_menu_id_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
