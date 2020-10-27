/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateColumnStatisticsForPartition operation.
    /// Creates or updates partition statistics of columns.
    /// 
    ///  
    /// <para>
    /// The Identity and Access Management (IAM) permission required for this operation is
    /// <code>UpdatePartition</code>.
    /// </para>
    /// </summary>
    public partial class UpdateColumnStatisticsForPartitionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private List<ColumnStatistics> _columnStatisticsList = new List<ColumnStatistics>();
        private string _databaseName;
        private List<string> _partitionValues = new List<string>();
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partitions in question reside. If none is supplied,
        /// the AWS account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnStatisticsList. 
        /// <para>
        /// A list of the column statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<ColumnStatistics> ColumnStatisticsList
        {
            get { return this._columnStatisticsList; }
            set { this._columnStatisticsList = value; }
        }

        // Check to see if ColumnStatisticsList property is set
        internal bool IsSetColumnStatisticsList()
        {
            return this._columnStatisticsList != null && this._columnStatisticsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database where the partitions reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionValues. 
        /// <para>
        /// A list of partition values identifying the partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PartitionValues
        {
            get { return this._partitionValues; }
            set { this._partitionValues = value; }
        }

        // Check to see if PartitionValues property is set
        internal bool IsSetPartitionValues()
        {
            return this._partitionValues != null && this._partitionValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the partitions' table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}