using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    [MetadataType(typeof(authorMetaData))]
    public partial class author
    {
        public class authorMetaData
        {
            [DisplayName("Tên tác giả")]
            public string name { get; set; }

            [DisplayName("Địa chỉ")]
            public string address { get; set; }

            [DisplayName("Số điện thoại")]
            public string phone { get; set; }

        }
    }
}