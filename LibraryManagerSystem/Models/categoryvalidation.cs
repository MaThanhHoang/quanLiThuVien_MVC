using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    [MetadataType(typeof(categoryMetaData))]

    public partial class category
    {
        public class categoryMetaData
        {
            [DisplayName("Thể loại sách")]
            public string catname { get; set; }

            [DisplayName("Status")]
            public string status { get; set; }

        }
    }
}