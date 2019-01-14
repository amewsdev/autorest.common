// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace AutoRest.Modeler.Model
{
    public class Path
    {

        public Path()
        {
        }


        [JsonProperty(PropertyName = "get")]  
        public  Operation Get {get; set;}

        
        [JsonProperty(PropertyName = "put")]  
        public Operation Put {get; set;}

        [JsonProperty(PropertyName = "post")]  
        public  Operation Post {get; set;}

        [JsonProperty(PropertyName = "delete")]  
        public Operation Delete {get; set;}

        [JsonProperty(PropertyName = "options")]  
        public Operation Options {get; set;}

        [JsonProperty(PropertyName = "head")]
        public Operation Head {get; set;}

         [JsonProperty(PropertyName = "patch")]  
        public Operation Patch {get; set;}

         [JsonProperty(PropertyName = "trace")]  
        public Operation Trace {get; set;}       

        [JsonProperty(PropertyName = "x-ms-metadata")]
        public AutoRest.Core.Model.XmsMetadata XMsMetadata { get; set; }

        public Dictionary<string, Operation> ToOperationsDictionary() =>  
            new Dictionary<string, Operation> {
                { "put", Put },       
                { "delete", Delete },                         
                { "get", Get },                
                { "post", Post },
                { "options", Options },
                { "head", Head },
                { "patch", Patch },
                { "trace", Trace}
            }.Where(op => op.Value != null)
            .ToDictionary(op => op.Key, op => op.Value);        
    }
}