using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    [MetadataType(typeof(memberMetaData))]
    public partial class member
    {
        public class memberMetaData
        {
            [DisplayName("Tên thành viên")]
            public string name { get; set; }

            [DisplayName("Mã sinh viên")]
            public string mssv { get; set; }

            [DisplayName("Địa chỉ")]
            public string address { get; set; }

            [DisplayName("Số điện thoại")]
            public string phone { get; set; }

            [DisplayName("Mật khẩu")]
            public string password { get; set; }
        }
    }
}