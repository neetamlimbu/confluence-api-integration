namespace ForumDataMigration.Domain
{
    public class SubForum
    {
        public bool Select { get; set; }
        public int SFID { get; set; }
        public int FID { get; set; }
        public int ParentPageID { get; set; }
        public int PostTableID { get; set; }
        public int TypeID { get; set; }
        public int SortID { get; set; }
        public int ReadPerm { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int AuthorID { get; set; }
        public string Subject { get; set; }
        public string DateLine { get; set; }
        public string PostDate { get; set; }
        public int LastPost { get; set; }
        public string LastPoster { get; set; }
        public int Views { get; set; }
        public int Replies { get; set; }
        public int DisplayOrder { get; set; }
        public int HighLight { get; set; }
        public int Digest { get; set; }
        public int Rate { get; set; }
        public int Special { get; set; }
        public int Attachment { get; set; }
        public int Moderated { get; set; }
        public int Closed { get; set; }
        public int StickReply { get; set; }
        public int Recommends { get; set; }
        public int RecommendsAdd { get; set; }
        public int RecommendsSub { get; set; }
        public int Heats { get; set; }
        public int Status { get; set; }
        public int IsGroup { get; set; }
        public int FavTimes { get; set; }
        public int ShareTimes { get; set; }
        public int Stamp { get; set; }
        public int Icon { get; set; }
        public int PushedAid { get; set; }
        public int Cover { get; set; }
        public int ReplyCredit { get; set; }
    }
}
