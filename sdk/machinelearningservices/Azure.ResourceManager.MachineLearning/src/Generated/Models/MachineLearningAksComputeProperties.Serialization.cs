// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterFqdn))
            {
                if (ClusterFqdn != null)
                {
                    writer.WritePropertyName("clusterFqdn");
                    writer.WriteStringValue(ClusterFqdn);
                }
                else
                {
                    writer.WriteNull("clusterFqdn");
                }
            }
            if (Optional.IsDefined(AgentCount))
            {
                if (AgentCount != null)
                {
                    writer.WritePropertyName("agentCount");
                    writer.WriteNumberValue(AgentCount.Value);
                }
                else
                {
                    writer.WriteNull("agentCount");
                }
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                if (AgentVmSize != null)
                {
                    writer.WritePropertyName("agentVmSize");
                    writer.WriteStringValue(AgentVmSize);
                }
                else
                {
                    writer.WriteNull("agentVmSize");
                }
            }
            if (Optional.IsDefined(ClusterPurpose))
            {
                writer.WritePropertyName("clusterPurpose");
                writer.WriteStringValue(ClusterPurpose.Value.ToString());
            }
            if (Optional.IsDefined(SslConfiguration))
            {
                if (SslConfiguration != null)
                {
                    writer.WritePropertyName("sslConfiguration");
                    writer.WriteObjectValue(SslConfiguration);
                }
                else
                {
                    writer.WriteNull("sslConfiguration");
                }
            }
            if (Optional.IsDefined(AksNetworkingConfiguration))
            {
                if (AksNetworkingConfiguration != null)
                {
                    writer.WritePropertyName("aksNetworkingConfiguration");
                    writer.WriteObjectValue(AksNetworkingConfiguration);
                }
                else
                {
                    writer.WriteNull("aksNetworkingConfiguration");
                }
            }
            if (Optional.IsDefined(LoadBalancerType))
            {
                writer.WritePropertyName("loadBalancerType");
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerSubnet))
            {
                if (LoadBalancerSubnet != null)
                {
                    writer.WritePropertyName("loadBalancerSubnet");
                    writer.WriteStringValue(LoadBalancerSubnet);
                }
                else
                {
                    writer.WriteNull("loadBalancerSubnet");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningAksComputeProperties DeserializeMachineLearningAksComputeProperties(JsonElement element)
        {
            Optional<string> clusterFqdn = default;
            Optional<IReadOnlyList<MachineLearningComputeSystemService>> systemServices = default;
            Optional<int?> agentCount = default;
            Optional<string> agentVmSize = default;
            Optional<MachineLearningClusterPurpose> clusterPurpose = default;
            Optional<MachineLearningSslConfiguration> sslConfiguration = default;
            Optional<MachineLearningAksNetworkingConfiguration> aksNetworkingConfiguration = default;
            Optional<MachineLearningLoadBalancerType> loadBalancerType = default;
            Optional<string> loadBalancerSubnet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clusterFqdn = null;
                        continue;
                    }
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemServices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemServices = null;
                        continue;
                    }
                    List<MachineLearningComputeSystemService> array = new List<MachineLearningComputeSystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeSystemService.DeserializeMachineLearningComputeSystemService(item));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("agentCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        agentCount = null;
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        agentVmSize = null;
                        continue;
                    }
                    agentVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterPurpose"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterPurpose = new MachineLearningClusterPurpose(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sslConfiguration = null;
                        continue;
                    }
                    sslConfiguration = MachineLearningSslConfiguration.DeserializeMachineLearningSslConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("aksNetworkingConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        aksNetworkingConfiguration = null;
                        continue;
                    }
                    aksNetworkingConfiguration = MachineLearningAksNetworkingConfiguration.DeserializeMachineLearningAksNetworkingConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBalancerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadBalancerType = new MachineLearningLoadBalancerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerSubnet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        loadBalancerSubnet = null;
                        continue;
                    }
                    loadBalancerSubnet = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningAksComputeProperties(clusterFqdn.Value, Optional.ToList(systemServices), Optional.ToNullable(agentCount), agentVmSize.Value, Optional.ToNullable(clusterPurpose), sslConfiguration.Value, aksNetworkingConfiguration.Value, Optional.ToNullable(loadBalancerType), loadBalancerSubnet.Value);
        }
    }
}
