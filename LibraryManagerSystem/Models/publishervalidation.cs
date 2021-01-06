using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    [MetadataType(typeof(publisherMetaData))]
    public partial class publisher
    {
        public class publisherMetaData
        {
            [DisplayName("Nhà xuất bản")]
            public string name { get; set; }

            [DisplayName("Văn Phòng")]
            public string address { get; set; }

            [DisplayName("Hotline")]
            public string phone { get; set; }

        }
    }
}