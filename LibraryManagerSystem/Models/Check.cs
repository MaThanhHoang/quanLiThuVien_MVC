using LibraryManagerSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagerSystem.Models
{
    public class Check
    {
        nitlibraryEntities db = new nitlibraryEntities();
        public static bool checkAmount(string bookid)
        {
            int count = (from s in MyDbContext.Instance.books where s.book_id == bookid select s.amount).First().Value;
            return (count > 1);
        }

        public static void removeBook(string bookid)
        {
            book matchedBook = (from s in MyDbContext.Instance.books where s.book_id == bookid select s).First();
            matchedBook.amount -= 1;
            MyDbContext.Instance.SaveChanges();
        }

        public static bool checkReturn(string memid, string bookid, string stt)
        {
            return (from s in MyDbContext.Instance.issuebooks where s.member_id == memid && s.book_id == bookid && s.status == stt select s).Any();
        }

        public static bool CanIssueBook(string memberId, string bookId)
        {
            var hasItem = MyDbContext.Instance.issuebooks.FirstOrDefault(s => s.member_id == memberId && s.book_id == bookId);
            if (hasItem == null || hasItem.status == ReturnBookStatus.Yes.GetDescription())
            {
                return true;
            }

            return false;
        }

        public static void updateReturn(issuebook returns)
        {
            issuebook update = (from s in MyDbContext.Instance.issuebooks where s.book_id == returns.book_id && s.member_id == returns.member_id && s.status == null select s).FirstOrDefault();
            update.returndate = returns.returndate;
            update.status = ReturnBookStatus.Yes.GetDescription();
            book matchedBook = (from s in MyDbContext.Instance.books where s.book_id == returns.book_id select s).First();
            matchedBook.amount += 1;
            MyDbContext.Instance.SaveChanges();
        }

    }
}