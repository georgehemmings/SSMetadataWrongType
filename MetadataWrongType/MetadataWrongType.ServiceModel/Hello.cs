using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using ServiceStack;

namespace MetadataWrongType.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }

        public class Address
        {
            public string HouseNumber { get; set; }
            public string Postcode { get; set; }
        }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}
