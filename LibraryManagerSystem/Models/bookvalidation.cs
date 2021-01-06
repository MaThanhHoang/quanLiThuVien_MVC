using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    [MetadataType(typeof(bookMetaData))]
    public partial class book
    {
        public class bookMetaData
        {
            [DisplayName("Mã sách")]
            public string book_id { get; set; }

            [DisplayName("Tên sách")]
            public string bname { get; set; }

            [DisplayName("Thể loại")]
            public Nullable<int> cat_id { get; set; }

            [DisplayName("Tác giả")]
            public Nullable<int> a_id { get; set; }

            [DisplayName("Nhà xuất bản")]
            public Nullable<int> p_id { get; set; }

            [DisplayName("Nội dung")]
            public string contents { get; set; }

            [DisplayName("Số trang")]
            public Nullable<int> pages { get; set; }

            [DisplayName("Phiên bản")]
            public string edition { get; set; }

            [DisplayName("Số lượng")]
            public Nullable<int> amount { get; set; }

        }
    }
}