using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CosmosDBWebApp.Enums.Enums;

namespace CosmosDBWebApp.Models
{
    public interface IModelBase
    {
        [JsonProperty(PropertyName = "docType")]
        DocTypes DocType { get; set; }
    }
    public class ModelBase : IModelBase
    {
        [JsonProperty(PropertyName = "docType")]
        public DocTypes DocType { get; set; }
    }
}