// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The current status of an async operation. </summary>
    public partial class OperationStatus
    {
        /// <summary> Initializes a new instance of OperationStatus. </summary>
        internal OperationStatus()
        {
        }

        /// <summary> Initializes a new instance of OperationStatus. </summary>
        /// <param name="id"> Fully qualified ID for the operation status. </param>
        /// <param name="name"> The operation id name. </param>
        /// <param name="status"> Provisioning state of the resource. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="properties"> Custom operation properties, populated only for a successful operation. </param>
        /// <param name="error"> Operation Error message. </param>
        internal OperationStatus(string id, string name, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, float? percentComplete, BinaryData properties, OperationStatusError error)
        {
            Id = id;
            Name = name;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            PercentComplete = percentComplete;
            Properties = properties;
            Error = error;
        }

        /// <summary> Fully qualified ID for the operation status. </summary>
        public string Id { get; }
        /// <summary> The operation id name. </summary>
        public string Name { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public string Status { get; }
        /// <summary> The start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the operation. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Percent of the operation that is complete. </summary>
        public float? PercentComplete { get; }
        /// <summary>
        /// Custom operation properties, populated only for a successful operation.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Properties { get; }
        /// <summary> Operation Error message. </summary>
        public OperationStatusError Error { get; }
    }
}
