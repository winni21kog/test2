//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberPairList
    {
        public int MemberPairListID { get; set; }
        public int MemberID { get; set; }
        public int PairMemberID { get; set; }
        public string PairID { get; set; }
        public Nullable<System.DateTime> Pairtime { get; set; }
        public Nullable<System.DateTime> Changetime { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Pair Pair { get; set; }
    }
}
