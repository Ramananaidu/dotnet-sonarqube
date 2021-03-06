// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult class.
        /// </summary>
        public MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult class.
        /// </summary>
        /// <param name="resultType">Result type</param>
        /// <param name="id">Result identifier</param>
        /// <param name="migrationId">Migration Identifier</param>
        /// <param name="sourceDatabaseName">Name of the source
        /// database</param>
        /// <param name="targetDatabaseName">Name of the target
        /// database</param>
        /// <param name="startedOn">Validation start time</param>
        /// <param name="endedOn">Validation end time</param>
        /// <param name="dataIntegrityValidationResult">Provides data integrity
        /// validation result between the source and target tables that are
        /// migrated.</param>
        /// <param name="schemaValidationResult">Provides schema comparison
        /// result between source and target database</param>
        /// <param name="queryAnalysisValidationResult">Results of some of the
        /// query execution result between source and target database</param>
        /// <param name="status">Current status of validation at the database
        /// level. Possible values include: 'Default', 'NotStarted',
        /// 'Initialized', 'InProgress', 'Completed', 'CompletedWithIssues',
        /// 'Stopped', 'Failed'</param>
        public MigrateSqlServerSqlDbTaskOutputDatabaseLevelValidationResult(string resultType, string id = default(string), string migrationId = default(string), string sourceDatabaseName = default(string), string targetDatabaseName = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), DataIntegrityValidationResult dataIntegrityValidationResult = default(DataIntegrityValidationResult), SchemaComparisonValidationResult schemaValidationResult = default(SchemaComparisonValidationResult), QueryAnalysisValidationResult queryAnalysisValidationResult = default(QueryAnalysisValidationResult), string status = default(string))
        {
            Id = id;
            ResultType = resultType;
            MigrationId = migrationId;
            SourceDatabaseName = sourceDatabaseName;
            TargetDatabaseName = targetDatabaseName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            DataIntegrityValidationResult = dataIntegrityValidationResult;
            SchemaValidationResult = schemaValidationResult;
            QueryAnalysisValidationResult = queryAnalysisValidationResult;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets result type
        /// </summary>
        [JsonProperty(PropertyName = "resultType")]
        public string ResultType { get; set; }

        /// <summary>
        /// Gets migration Identifier
        /// </summary>
        [JsonProperty(PropertyName = "migrationId")]
        public string MigrationId { get; private set; }

        /// <summary>
        /// Gets name of the source database
        /// </summary>
        [JsonProperty(PropertyName = "sourceDatabaseName")]
        public string SourceDatabaseName { get; private set; }

        /// <summary>
        /// Gets name of the target database
        /// </summary>
        [JsonProperty(PropertyName = "targetDatabaseName")]
        public string TargetDatabaseName { get; private set; }

        /// <summary>
        /// Gets validation start time
        /// </summary>
        [JsonProperty(PropertyName = "startedOn")]
        public System.DateTimeOffset? StartedOn { get; private set; }

        /// <summary>
        /// Gets validation end time
        /// </summary>
        [JsonProperty(PropertyName = "endedOn")]
        public System.DateTimeOffset? EndedOn { get; private set; }

        /// <summary>
        /// Gets provides data integrity validation result between the source
        /// and target tables that are migrated.
        /// </summary>
        [JsonProperty(PropertyName = "dataIntegrityValidationResult")]
        public DataIntegrityValidationResult DataIntegrityValidationResult { get; private set; }

        /// <summary>
        /// Gets provides schema comparison result between source and target
        /// database
        /// </summary>
        [JsonProperty(PropertyName = "schemaValidationResult")]
        public SchemaComparisonValidationResult SchemaValidationResult { get; private set; }

        /// <summary>
        /// Gets results of some of the query execution result between source
        /// and target database
        /// </summary>
        [JsonProperty(PropertyName = "queryAnalysisValidationResult")]
        public QueryAnalysisValidationResult QueryAnalysisValidationResult { get; private set; }

        /// <summary>
        /// Gets current status of validation at the database level. Possible
        /// values include: 'Default', 'NotStarted', 'Initialized',
        /// 'InProgress', 'Completed', 'CompletedWithIssues', 'Stopped',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResultType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResultType");
            }
        }
    }
}
