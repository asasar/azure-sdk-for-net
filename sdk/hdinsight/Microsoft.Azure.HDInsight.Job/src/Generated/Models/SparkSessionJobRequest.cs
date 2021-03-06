// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SparkSessionJobRequest
    {
        /// <summary>
        /// Initializes a new instance of the SparkSessionJobRequest class.
        /// </summary>
        public SparkSessionJobRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkSessionJobRequest class.
        /// </summary>
        /// <param name="kind">Possible values include: 'spark', 'pyspark',
        /// 'sparkr', 'sql'</param>
        public SparkSessionJobRequest(string kind = default(string), string proxyUser = default(string), IList<string> jars = default(IList<string>), IList<string> pythonFiles = default(IList<string>), IList<string> files = default(IList<string>), string driverMemory = default(string), int? driverCores = default(int?), string executorMemory = default(string), int? executorCores = default(int?), int? executorCount = default(int?), IList<string> archives = default(IList<string>), string queue = default(string), string name = default(string), IDictionary<string, string> configuration = default(IDictionary<string, string>), int? heartbeatTimeoutInSecond = default(int?))
        {
            Kind = kind;
            ProxyUser = proxyUser;
            Jars = jars;
            PythonFiles = pythonFiles;
            Files = files;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            ExecutorCount = executorCount;
            Archives = archives;
            Queue = queue;
            Name = name;
            Configuration = configuration;
            HeartbeatTimeoutInSecond = heartbeatTimeoutInSecond;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'spark', 'pyspark', 'sparkr',
        /// 'sql'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxyUser")]
        public string ProxyUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jars")]
        public IList<string> Jars { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pyFiles")]
        public IList<string> PythonFiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<string> Files { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "driverMemory")]
        public string DriverMemory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "driverCores")]
        public int? DriverCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executorMemory")]
        public string ExecutorMemory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executorCores")]
        public int? ExecutorCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numExecutors")]
        public int? ExecutorCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "archives")]
        public IList<string> Archives { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public string Queue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conf")]
        public IDictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "heartbeatTimeoutInSecond")]
        public int? HeartbeatTimeoutInSecond { get; set; }

    }
}
