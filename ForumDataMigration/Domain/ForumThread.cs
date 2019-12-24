namespace ForumDataMigration.Domain
{
    public class ForumThread
    {
        public bool Select { get; set; }
        public int TID { get; set; }
        public int FID { get; set; }
        public int SFID { get; set; }
        public int ParentPageID { get; set; }
        public int First { get; set; }
        public string Author { get; set; }
        public int AuthorID { get; set; }
        public string Subject { get; set; }
        public string DateLine { get; set; }
        public string Message { get; set; }
        public string UseIP { get; set; }
        public int Invisible { get; set; }
        public int Anonymous { get; set; }
        public int UseSig { get; set; }
        public int HtmlOn { get; set; }
        public int BBCodeOff { get; set; }
        public int SmileyOff { get; set; }
        public int ParseUrlOff { get; set; }
        public int Attachment { get; set; }
        public int Rate { get; set; }
        public int RateTimes { get; set; }
        public int Status { get; set; }
        public string Tags { get; set; }
        public int Comment { get; set; }
        public int ReplyCredit { get; set; }
    }
}
