// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CalculateTotalTimeIncidentResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCalculateTotalTimeIncidentResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCalculateTotalTimeIncidentResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCalculateTotalTimeIncidentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCalculateTotalTimeIncidentResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCalculateTotalTimeIncidentResponse(object totalTime = default(object))
        {
            TotalTime = totalTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalTime")]
        public object TotalTime { get; set; }

    }
}