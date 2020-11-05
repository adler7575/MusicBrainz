using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicbrainz.Models
{
    public class Album
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string ImageUri { get; set; }
    }
}
