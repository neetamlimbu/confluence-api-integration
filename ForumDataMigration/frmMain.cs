using ForumDataMigration.Domain;
using HtmlAgilityPack;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDataMigration
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Database Connection

        private bool CheckConnection()
        {
            bool success = false;

            if (string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBox.Show("Please enter connection string");
                return success;
            }

            string connetionString = txtConnectionString.Text.Trim();
            MySqlConnection cnn;
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();

                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL DB" + ex.ToString());
            }

            return success;
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if (CheckConnection())
            {
                MessageBox.Show("Connection succeeded");
            }
        }

        #endregion

        #region Forum

        private void cmdForumLoad_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_forum.fid, " +
                "pre_forum_forum.fup, " +
                "pre_forum_forum.type, " +
                "pre_forum_forum.name, " +
                "pre_forum_forum.status, " +
                "pre_forum_forum.displayorder, " +
                "pre_forum_forum.styleid, " +
                "pre_forum_forum.threads, " +
                "pre_forum_forum.posts, " +
                "pre_forum_forum.todayposts, " +
                "pre_forum_forum.lastpost, " +
                "pre_forum_forum.domain, " +
                "pre_forum_forum.allowsmilies, " +
                "pre_forum_forum.allowhtml, " +
                "pre_forum_forum.allowbbcode, " +
                "pre_forum_forum.allowimgcode, " +
                "pre_forum_forum.allowmediacode, " +
                "pre_forum_forum.allowanonymous, " +
                "pre_forum_forum.allowpostspecial, " +
                "pre_forum_forum.allowspecialonly, " +
                "pre_forum_forum.allowappend, " +
                "pre_forum_forum.alloweditrules, " +
                "pre_forum_forum.allowfeed, " +
                "pre_forum_forum.allowside, " +
                "pre_forum_forum.recyclebin, " +
                "pre_forum_forum.modnewposts, " +
                "pre_forum_forum.jammer, " +
                "pre_forum_forum.disablewatermark, " +
                "pre_forum_forum.inheritedmod, " +
                "pre_forum_forum.autoclose, " +
                "pre_forum_forum.forumcolumns, " +
                "pre_forum_forum.catforumcolumns, " +
                "pre_forum_forum.threadcaches, " +
                "pre_forum_forum.alloweditpost, " +
                "pre_forum_forum.simple, " +
                "pre_forum_forum.modworks, " +
                "pre_forum_forum.allowglobalstick, " +
                "pre_forum_forum.level, " +
                "pre_forum_forum.commoncredits, " +
                "pre_forum_forum.archive, " +
                "pre_forum_forum.recommend, " +
                "pre_forum_forum.favtimes,  " +
                "pre_forum_forum.sharetimes, " +
                "pre_forum_forum.disablethumb " +
                "FROM cmsforum.pre_forum_forum";

                int intFID;
                bool success = false;

                if (!string.IsNullOrWhiteSpace(txtForumID.Text.Trim()))
                {
                    success = int.TryParse(txtForumID.Text.Trim(), out intFID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid FID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumID.Text.Trim()))
                {
                    sql = sql + " WHERE pre_forum_forum.fid = " + txtForumID.Text.Trim();
                }

                string orderByClause = string.Empty;

                if (cmbForumOrderBy.SelectedIndex > -1)
                {
                    switch (cmbForumOrderBy.SelectedIndex)
                    {
                        case 0:
                            orderByClause = " ORDER BY pre_forum_forum.fid";
                            break;

                        case 1:
                            orderByClause = " ORDER BY pre_forum_forum.displayorder";
                            break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(orderByClause))
                {
                    sql = sql + orderByClause;
                }

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<Forum> forums = new List<Forum>();

                    while (rdr.Read())
                    {
                        bool selected = false;
                        int FID = rdr.GetInt32(0);
                        int FUP = rdr.GetInt32(1);
                        string Type = rdr.GetString(2);
                        string Name = rdr.GetString(3);
                        int Status = rdr.GetInt32(4);
                        int DisplayOrder = rdr.GetInt32(5);
                        int StyleID = rdr.GetInt32(6);
                        int Threads = rdr.GetInt32(7);
                        int Posts = rdr.GetInt32(8);
                        int TodayPosts = rdr.GetInt32(9);
                        string LastPost = rdr.GetString(10);
                        string Domain = rdr.GetString(11);
                        int AllowMiles = rdr.GetInt32(12);
                        int AllowHtml = rdr.GetInt32(13);
                        int AllowBBCode = rdr.GetInt32(14);
                        int AllowingCode = rdr.GetInt32(15);
                        int AllowMediaCode = rdr.GetInt32(16);
                        int AllowAnonymous = rdr.GetInt32(17);
                        int AllowPostsSpecial = rdr.GetInt32(18);
                        int AllowSpecialOnly = rdr.GetInt32(19);
                        int AllowAppend = rdr.GetInt32(20);
                        int AllowEditRules = rdr.GetInt32(21);
                        int AllowFeed = rdr.GetInt32(22);
                        int AllowSide = rdr.GetInt32(23);
                        int RecyleBin = rdr.GetInt32(24);
                        int ModNewPosts = rdr.GetInt32(25);
                        int Jammer = rdr.GetInt32(26);
                        int DisableWaterMark = rdr.GetInt32(27);
                        int InheritEdMod = rdr.GetInt32(28);
                        int AutoClose = rdr.GetInt32(29);
                        int ForumColumns = rdr.GetInt32(30);
                        int CatForumColumns = rdr.GetInt32(31);
                        int ThreadCaches = rdr.GetInt32(32);
                        int AllowdItPost = rdr.GetInt32(33);
                        int Simple = rdr.GetInt32(34);
                        int ModWorks = rdr.GetInt32(35);
                        int AllowGlobalStick = rdr.GetInt32(36);
                        int Level = rdr.GetInt32(37);
                        int CommonCredits = rdr.GetInt32(38);
                        int Archive = rdr.GetInt32(39);
                        int Recommend = rdr.GetInt32(40);
                        int FavTimes = rdr.GetInt32(41);
                        int ShareTimes = rdr.GetInt32(42);
                        int DisableThumb = rdr.GetInt32(43);

                        Forum forumThread = new Forum
                        {
                            Select = selected,
                            FID = FID,
                            FUP = FUP,
                            Type = Type,
                            Name = Name,
                            Status = Status,
                            DisplayOrder = DisplayOrder,
                            StyleID = StyleID,
                            Threads = Threads,
                            Posts = Posts,
                            TodayPosts = TodayPosts,
                            LastPost = LastPost,
                            Domain = Domain,
                            AllowMiles = AllowMiles,
                            AllowHtml = AllowHtml,
                            AllowBBCode = AllowBBCode,
                            AllowingCode = AllowingCode,
                            AllowMediaCode = AllowMediaCode,
                            AllowAnonymous = AllowAnonymous,
                            AllowPostsSpecial = AllowPostsSpecial,
                            AllowSpecialOnly = AllowSpecialOnly,
                            AllowAppend = AllowAppend,
                            AllowEditRules = AllowEditRules,
                            AllowFeed = AllowFeed,
                            AllowSide = AllowSide,
                            RecyleBin = RecyleBin,
                            ModNewPosts = ModNewPosts,
                            Jammer = Jammer,
                            DisableWaterMark = DisableWaterMark,
                            InheritEdMod = InheritEdMod,
                            AutoClose = AutoClose,
                            ForumColumns = ForumColumns,
                            CatForumColumns = CatForumColumns,
                            ThreadCaches = ThreadCaches,
                            AllowdItPost = AllowdItPost,
                            Simple = Simple,
                            ModWorks = ModWorks,
                            AllowGlobalStick = AllowGlobalStick,
                            Level = Level,
                            CommonCredits = CommonCredits,
                            Archive = Archive,
                            Recommend = Recommend,
                            FavTimes = FavTimes,
                            ShareTimes = ShareTimes,
                            DisableThumb = DisableThumb
                        };

                        forums.Add(forumThread);
                    }

                    rdr.Close();

                    dgForum.DataSource = null;
                    dgForum.Rows.Clear();
                    dgForum.Refresh();

                    dgForum.DataSource = forums;
                    txtForumNoOfRows.Text = forums.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading forums " + ex.ToString());
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void cmdSelectAllForum_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForum.Rows)
            {
                dr.Cells["Select"].Value = true;
            }

            dgForum.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void cmdClearAllForum_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForum.Rows)
            {
                dr.Cells["Select"].Value = false;
            }

            dgForum.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private async void cmdForumUpload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (dgForum.DataSource == null)
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            ListViewItem listViewItem = null;
            listViewItem = new ListViewItem("Add Forum");

            try
            {
                List<Forum> forums = ((List<Forum>)dgForum.DataSource).Where(d => d.Select == true)
                .ToList();

                foreach (Forum forum in forums)
                {
                    string name = forum.Name;
                    bool success = await Task.FromResult(Helper.AddForumPageAsync(txtAdmin.Text.Trim(), txtPass.Text.Trim(), txtSpace.Text.Trim(),
                        txtServer.Text.Trim(), txtForumApiUrl.Text.Trim(), name)).Result;

                    if (success)
                    {
                        listViewItem.SubItems.Add("Added Forum: " + name);
                        lvEvents.Items.Add(listViewItem);
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Failed to add Forum: " + name);
                        lvEvents.Items.Add(listViewItem);
                    }

                    Thread.Sleep(3000);
                }

                //string name = dgForum.Rows[0].Cells["Name"].Value.ToString();
                //Task.FromResult(Helper.AddForumPageAsync(txtAdmin.Text.Trim(), txtPass.Text.Trim(), txtSpace.Text.Trim(),
                //    txtServer.Text.Trim(), txtForumApiUrl.Text.Trim(), name));
            }
            catch (Exception ex)
            {
                listViewItem.SubItems.Add("Unexpected Error" + ex.ToString());
                lvEvents.Items.Add(listViewItem);
            }

            Cursor.Current = Cursors.Default;
        }

        private string GetForumTopic(string fid)
        {
            string topic = string.Empty;
            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_forum.name " +
                "FROM cmsforum.pre_forum_forum " +
                "WHERE pre_forum_forum.fid = " + fid;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        topic = rdr[0].ToString();
                    }

                    rdr.Close();

                }
                catch (Exception ex)
                {
                    ListViewItem listViewItem = new ListViewItem("Error loading forum topic");
                    listViewItem.SubItems.Add(ex.ToString());
                    lvEvents.Items.Add(listViewItem);
                }
            }

            return topic;
        }

        #endregion

        #region Forum Thread => Sub Forum

        private void cmdLoadForumThread_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_thread.tid, " +
                "pre_forum_thread.fid, " +
                "pre_forum_thread.posttableid, " +
                "pre_forum_thread.typeid, " +
                "pre_forum_thread.sortid, " +
                "pre_forum_thread.readperm, " +
                "pre_forum_thread.price, " +
                "pre_forum_thread.author, " +
                "pre_forum_thread.authorid, " +
                "pre_forum_thread.subject, " +
                "from_unixtime(pre_forum_thread.dateline,'%Y-%m-%d') as PostDate, " +
                "pre_forum_thread.lastpost, " +
                "pre_forum_thread.lastposter, " +
                "pre_forum_thread.views, " +
                "pre_forum_thread.replies, " +
                "pre_forum_thread.displayorder, " +
                "pre_forum_thread.highlight, " +
                "pre_forum_thread.digest, " +
                "pre_forum_thread.rate, " +
                "pre_forum_thread.special, " +
                "pre_forum_thread.attachment, " +
                "pre_forum_thread.moderated, " +
                "pre_forum_thread.closed, " +
                "pre_forum_thread.stickreply, " +
                "pre_forum_thread.recommends, " +
                "pre_forum_thread.recommend_add, " +
                "pre_forum_thread.recommend_sub, " +
                "pre_forum_thread.heats, " +
                "pre_forum_thread.status, " +
                "pre_forum_thread.isgroup, " +
                "pre_forum_thread.favtimes, " +
                "pre_forum_thread.sharetimes, " +
                "pre_forum_thread.stamp, " +
                "pre_forum_thread.icon, " +
                "pre_forum_thread.pushedaid, " +
                "pre_forum_thread.cover, " +
                "pre_forum_thread.replycredit " +
                "FROM cmsforum.pre_forum_thread";

                string whereClause = string.Empty;

                int intFID, intTID;
                bool success = false;

                if (!string.IsNullOrWhiteSpace(txtSubForumFID.Text.Trim()))
                {
                    success = int.TryParse(txtSubForumFID.Text.Trim(), out intFID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid FID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtSubForumID.Text.Trim()))
                {
                    success = int.TryParse(txtSubForumID.Text.Trim(), out intTID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid TID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtSubForumFID.Text.Trim()))
                {
                    whereClause = " WHERE pre_forum_thread.fid = " + txtSubForumFID.Text.Trim();
                }

                if (!string.IsNullOrWhiteSpace(txtSubForumID.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(whereClause))
                    {
                        whereClause = " WHERE pre_forum_thread.tid = " + txtSubForumID.Text.Trim();
                    }
                    else
                    {
                        whereClause = whereClause + " AND pre_forum_thread.tid = " + txtSubForumID.Text.Trim();
                    }
                }

                if (!string.IsNullOrWhiteSpace(whereClause))
                {
                    sql = sql + whereClause;
                }

                string orderByClause = string.Empty;

                if (cmbForumThreadOrderBy.SelectedIndex > -1)
                {
                    switch (cmbForumThreadOrderBy.SelectedIndex)
                    {
                        case 0:
                            orderByClause = " ORDER BY pre_forum_thread.tid";
                            break;

                        case 1:
                            orderByClause = " ORDER BY pre_forum_thread.fid";
                            break;

                        case 2:
                            orderByClause = " ORDER BY PostDate";
                            break;

                        case 3:
                            orderByClause = " ORDER BY pre_forum_thread.displayorder";
                            break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(orderByClause))
                {
                    sql = sql + orderByClause;
                }

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<SubForum> forumThreads = new List<SubForum>();

                    while (rdr.Read())
                    {
                        bool selected = false;
                        int tid = rdr.GetInt32(0);
                        int fid = rdr.GetInt32(1);
                        int postTableID = rdr.GetInt32(2);
                        int typeId = rdr.GetInt32(3);
                        int sortId = rdr.GetInt32(4);
                        int readPerm = rdr.GetInt32(5);
                        int price = rdr.GetInt32(6);
                        string author = rdr.GetString(7);
                        int authorId = rdr.GetInt32(8);
                        string subject = rdr.GetString(9);
                        string dateLine = rdr.GetString(10);
                        int lastPost = rdr.GetInt32(11);
                        string lastPoster = rdr.GetString(12);
                        int views = rdr.GetInt32(13);
                        int replies = rdr.GetInt32(14);
                        int displayOrder = rdr.GetInt32(15);
                        int highlight = rdr.GetInt32(16);
                        int digest = rdr.GetInt32(17);
                        int rate = rdr.GetInt32(18);
                        int special = rdr.GetInt32(19);
                        int attachment = rdr.GetInt32(20);
                        int moderated = rdr.GetInt32(21);
                        int closed = rdr.GetInt32(22);
                        int stickReply = rdr.GetInt32(23);
                        int recommends = rdr.GetInt32(24);
                        int recommendAdd = rdr.GetInt32(25);
                        int recommendSub = rdr.GetInt32(26);
                        int heats = rdr.GetInt32(27);
                        int status = rdr.GetInt32(28);
                        int isGroup = rdr.GetInt32(29);
                        int favTimes = rdr.GetInt32(30);
                        int shareTimes = rdr.GetInt32(31);
                        int stamp = rdr.GetInt32(32);
                        int icon = rdr.GetInt32(33);
                        int pushedAid = rdr.GetInt32(34);
                        int cover = rdr.GetInt32(35);
                        int replyCredit = rdr.GetInt32(36);

                        SubForum forumThread = new SubForum
                        {
                            Select = selected,
                            FID = fid,
                            SFID = tid,
                            PostTableID = postTableID,
                            TypeID = typeId,
                            SortID = sortId,
                            ReadPerm = readPerm,
                            Price = price,
                            Author = author,
                            AuthorID = authorId,
                            Subject = subject,
                            DateLine = dateLine,
                            LastPost = lastPost,
                            LastPoster = lastPoster,
                            Views = views,
                            Replies = replies,
                            DisplayOrder = displayOrder,
                            HighLight = highlight,
                            Digest = digest,
                            Rate = rate,
                            Special = special,
                            Attachment = attachment,
                            Moderated = moderated,
                            Closed = closed,
                            StickReply = stickReply,
                            Recommends = recommends,
                            RecommendsAdd = recommendAdd,
                            RecommendsSub = recommendSub,
                            Heats = heats,
                            Status = status,
                            IsGroup = isGroup,
                            FavTimes = favTimes,
                            ShareTimes = shareTimes,
                            Stamp = stamp,
                            Icon = icon,
                            PushedAid = pushedAid,
                            Cover = cover,
                            ReplyCredit = replyCredit,
                            ParentPageID = 0
                        };

                        forumThreads.Add(forumThread);
                    }

                    rdr.Close();

                    dgSubForum.DataSource = null;
                    dgSubForum.Rows.Clear();
                    dgSubForum.Refresh();

                    dgSubForum.DataSource = forumThreads;
                    txtForumPostNoOfRows.Text = forumThreads.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading forum posts " + ex.ToString());
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void cmdSelectAllForumThreads_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgSubForum.Rows)
            {
                dr.Cells["Select"].Value = true;
            }

            dgSubForum.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void cmdClearAllForumThreads_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgSubForum.Rows)
            {
                dr.Cells["Select"].Value = false;
            }

            dgSubForum.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private async void cmdUploadSubForum_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (dgForum.DataSource == null)
            {
                MessageBox.Show("Please load Forum List");
                return;
            }

            if (dgSubForum.DataSource == null)
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            ListViewItem listViewItem = null;

            try
            {
                List<SubForum> subForums = ((List<SubForum>)dgSubForum.DataSource).Where(d => d.Select == true)
               .ToList();

                foreach (SubForum subForum in subForums)
                {
                    string subject = subForum.Subject;

                    int parentPageId = subForum.ParentPageID;
                    string userName = subForum.Author;
                    string password = string.Empty;

                    if (string.IsNullOrWhiteSpace(userName))
                    {
                        userName = "admin";
                    }

                    if (userName.ToLower().Equals("admin"))
                    {
                        password = Helper.DefaultAdminPassword;
                    }
                    else
                    {
                        password = Helper.DefaultUserPassword;
                    }

                    bool exists = CompareForumAndSubForumTopic(subject);

                    if (exists)
                    {
                        subject = subject + ":";
                    }

                    bool success = await Task.FromResult(Helper.AddSubForumAsync(userName.Trim(), password.Trim(), txtSpace.Text.Trim(),
                         txtServer.Text.Trim(), txtForumThreadApiUrl.Text.Trim(), subject, string.Empty, parentPageId.ToString())).Result;

                    listViewItem = new ListViewItem("Add Sub Forum");
                    if (success)
                    {
                        listViewItem.SubItems.Add("Added Sub Forum: " + subject);
                        lvEvents.Items.Add(listViewItem);
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Failed to add Sub Forum: " + subject);
                        lvEvents.Items.Add(listViewItem);
                    }

                    Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {
                listViewItem = new ListViewItem("Add Sub Forum");
                listViewItem.SubItems.Add("Unexpected Error: " + ex.ToString());
                lvEvents.Items.Add(listViewItem);
            }

            Cursor.Current = Cursors.Default;
        }

        private async void cmdAssignSubForum_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                foreach (DataGridViewRow row in dgSubForum.Rows)
                {
                    bool rowSelected = (bool)row.Cells["Select"].Value;
                    if (rowSelected)
                    {
                        string subForumID = row.Cells["FID"].Value.ToString();
                        string topic = GetForumTopic(subForumID);

                        string pageId = await Helper.SearchForumPage("admin", "abc$123~~", txtSpace.Text.Trim(),
                                                       txtServer.Text.Trim(), txtSubForumApiUrl.Text.Trim(), topic.Trim());

                        row.Cells["ParentPageID"].Value = pageId;
                    }
                }
            }
            catch (Exception ex)
            {
                ListViewItem listViewItem = new ListViewItem("Unexpected Error");
                listViewItem.SubItems.Add(ex.ToString());
                lvEvents.Items.Add(listViewItem);
            }

            Cursor.Current = Cursors.Default;
        }

        private string GetSubForumTopic(string sfid)
        {
            string topic = string.Empty;
            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_thread.subject " +
                "FROM cmsforum.pre_forum_thread " +
                "WHERE pre_forum_thread.tid = " + sfid;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        topic = rdr[0].ToString();
                    }

                    rdr.Close();

                }
                catch (Exception ex)
                {
                    ListViewItem listViewItem = new ListViewItem("Error loading sub forum topic");
                    listViewItem.SubItems.Add(ex.ToString());
                    lvEvents.Items.Add(listViewItem);
                }
            }

            return topic;
        }

        private bool CompareForumAndSubForumTopic(string subforumTopic)
        {
            List<Forum> list = (List<Forum>)dgForum.DataSource;
            bool exists = false;

            if (list.Where(d => d.Name.Trim().ToLower().Equals(subforumTopic.Trim().ToLower())).Count() > 0)
            {
                exists = true;
            }

            return exists;
        }

        #endregion

        #region Forum Post

        private void cmdLoadForumTopics_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_post.pid as PID, " +
                "pre_forum_post.fid as FID, " +
                "pre_forum_post.tid as TID, " +
                "pre_forum_post.first as First, " +
                "pre_forum_post.author as Author, " +
                "pre_forum_post.authorid as AuthorID, " +
                "pre_forum_post.subject as Subject, " +
                "from_unixtime(pre_forum_post.dateline,'%Y-%m-%d') as PostDate, " +
                "pre_forum_post.message as Message, " +
                "pre_forum_post.useip as UserIP, " +
                "pre_forum_post.invisible as Invisible, " +
                "pre_forum_post.anonymous as Anonymous, " +
                "pre_forum_post.usesig as UseSig, " +
                "pre_forum_post.htmlon as HTMLOn, " +
                "pre_forum_post.bbcodeoff as BBCodeOff, " +
                "pre_forum_post.smileyoff as SmileyOff, " +
                "pre_forum_post.parseurloff as ParseUrlOff, " +
                "pre_forum_post.attachment as Attachment, " +
                "pre_forum_post.rate as Rate, " +
                "pre_forum_post.ratetimes as RateTimes, " +
                "pre_forum_post.status as Status, " +
                "pre_forum_post.tags as Tags, " +
                "pre_forum_post.comment as Comment, " +
                "pre_forum_post.replycredit as ReplyCredit " +
                "FROM cmsforum.pre_forum_post";

                string whereClause = string.Empty;

                int intPID, intFID, intTID;
                bool success = false;

                if (!string.IsNullOrWhiteSpace(txtForumThreadID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadID.Text.Trim(), out intPID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid PID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadFID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadFID.Text.Trim(), out intFID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid FID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadSFID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadSFID.Text.Trim(), out intTID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid TID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadID.Text.Trim()))
                {
                    whereClause = " WHERE pre_forum_post.pid = " + txtForumThreadID.Text.Trim();
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadFID.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(whereClause))
                    {
                        whereClause = " WHERE pre_forum_post.fid = " + txtForumThreadFID.Text.Trim();
                    }
                    else
                    {
                        whereClause = whereClause + " AND pre_forum_post.fid = " + txtForumThreadFID.Text.Trim();
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadSFID.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(whereClause))
                    {
                        whereClause = " WHERE pre_forum_post.tid = " + txtForumThreadSFID.Text.Trim();
                    }
                    else
                    {
                        whereClause = whereClause + " AND pre_forum_post.tid = " + txtForumThreadSFID.Text.Trim();
                    }
                }

                if (!string.IsNullOrWhiteSpace(whereClause))
                {
                    sql = sql + whereClause;
                }

                string orderByClause = string.Empty;

                if (cmbForumPostOrderBy.SelectedIndex > -1)
                {
                    switch (cmbForumPostOrderBy.SelectedIndex)
                    {
                        case 0:
                            orderByClause = " ORDER BY pre_forum_post.pid";
                            break;

                        case 1:
                            orderByClause = " ORDER BY pre_forum_post.fid";
                            break;

                        case 2:
                            orderByClause = " ORDER BY pre_forum_post.tid";
                            break;

                        case 3:
                            orderByClause = " ORDER BY PostDate";
                            break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(orderByClause))
                {
                    sql = sql + orderByClause;
                }

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<ForumThread> forumPosts = new List<ForumThread>();

                    while (rdr.Read())
                    {
                        bool selected = false;
                        int pid = rdr.GetInt32(0);
                        int fid = rdr.GetInt32(1);
                        int tid = rdr.GetInt32(2);
                        int first = rdr.GetInt32(3);
                        string author = rdr.GetString(4);
                        int authorId = rdr.GetInt32(5);
                        string subject = rdr.GetString(6);
                        string dateLine = rdr.GetString(7);
                        string message = rdr.GetString(8);
                        string useIP = rdr.GetString(9);
                        int invisible = rdr.GetInt32(10);
                        int anonymous = rdr.GetInt32(11);
                        int useSig = rdr.GetInt32(12);
                        int htmlOn = rdr.GetInt32(13);
                        int bbcodeoff = rdr.GetInt32(14);
                        int smileyOff = rdr.GetInt32(15);
                        int parseUrlOff = rdr.GetInt32(16);
                        int attachment = rdr.GetInt32(17);
                        int rate = rdr.GetInt32(18);
                        int rateTimes = rdr.GetInt32(19);
                        int status = rdr.GetInt32(20);
                        string tags = rdr.GetString(21);
                        int comment = rdr.GetInt32(22);
                        int replyCredit = rdr.GetInt32(23);


                        ForumThread forumPost = new ForumThread
                        {
                            Select = selected,
                            TID = pid,
                            FID = fid,
                            SFID = tid,
                            First = first,
                            Author = author,
                            AuthorID = authorId,
                            Subject = subject,
                            DateLine = dateLine,
                            Message = message,
                            UseIP = useIP,
                            Invisible = invisible,
                            Anonymous = anonymous,
                            UseSig = useSig,
                            HtmlOn = htmlOn,
                            BBCodeOff = bbcodeoff,
                            SmileyOff = smileyOff,
                            ParseUrlOff = parseUrlOff,
                            Attachment = attachment,
                            Rate = rate,
                            RateTimes = rateTimes,
                            Status = status,
                            Tags = tags,
                            Comment = comment,
                            ReplyCredit = replyCredit,
                            ParentPageID = 0
                        };

                        forumPosts.Add(forumPost);
                    }

                    rdr.Close();

                    dgForumThread.DataSource = null;
                    dgForumThread.Rows.Clear();
                    dgForumThread.Refresh();

                    dgForumThread.DataSource = forumPosts;
                    txtForumPostNoOfRows.Text = forumPosts.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading forum threads " + ex.ToString());
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void cmdSelectAllForumTopics_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForumThread.Rows)
            {
                dr.Cells["Select"].Value = true;
            }

            dgForumThread.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void cmdClearAllForumTopics_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForumThread.Rows)
            {
                dr.Cells["Select"].Value = false;
            }

            dgForumThread.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private async void cmdUploadForumThread_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (dgForumThread.DataSource == null)
            {
                Cursor.Current = Cursors.Default;
                return;
            }

            //ListViewItem listViewItem = null;

            try
            {
                List<ForumThread> forumThreads = ((List<ForumThread>)dgForumThread.DataSource).Where(d => d.Select == true)
               .ToList();

                foreach (ForumThread forumThread in forumThreads)
                {
                    string subject = forumThread.Subject;
                    string message = forumThread.Message;
                    int parentPageId = forumThread.ParentPageID;

                    string htmlMessage = Helper.ReplaceTags(message);
                    htmlMessage = Helper.CleanUnnessaryTags(htmlMessage);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(htmlMessage);

                    string errorMessage = string.Empty;

                    if(doc.ParseErrors.Count() > 0)
                    {
                        //Invalid HTML
                        errorMessage = "Invalid HTML for Subject \"" + subject + "\"" + ", SFID: " + forumThread.SFID;

                        string errDetails = string.Empty;

                        foreach (HtmlParseError err in doc.ParseErrors)
                        {
                            if (!string.IsNullOrWhiteSpace(errDetails))
                            {
                                errDetails += ", " + err.Reason;
                            }
                            else
                            {
                                errDetails = err.Reason;
                            }
                        }

                        errorMessage = errorMessage + ", " + errDetails;

                        WriteLogFile(errorMessage);

                        //listViewItem = new ListViewItem(errorMessage);

                        //listViewItem.SubItems.Add(errDetails);
                        //lvEvents.Items.Add(listViewItem);
                    }

                    string userName = forumThread.Author;
                    string password = string.Empty;

                    if (string.IsNullOrWhiteSpace(userName))
                    {
                        userName = "admin";
                    }

                    if (userName.ToLower().Equals("admin"))
                    {
                        password = Helper.DefaultAdminPassword;
                    }
                    else
                    {
                        password = Helper.DefaultUserPassword;
                    }

                    bool success = await Task.FromResult(Helper.AddForumThreadAsync(userName.Trim(), password.Trim(), txtSpace.Text.Trim(),
                         txtServer.Text.Trim(), txtForumThreadApiUrl.Text.Trim(), subject, htmlMessage, parentPageId.ToString())).Result;

                    //listViewItem = new ListViewItem("Add Forum Thread");
                    if (success)
                    {
                        message = "Added Forum Thread: " + subject;
                        
                        //listViewItem.SubItems.Add("Added Forum Thread: " + subject);
                        //lvEvents.Items.Add(listViewItem);
                    }
                    else
                    {
                        message = "Failed to add Forum Thread: " + subject;
                        //listViewItem.SubItems.Add("Failed to add forum thread: " + subject);
                        //lvEvents.Items.Add(listViewItem);
                    }

                    WriteLogFile(message);
                }
            }
            catch (Exception ex)
            {
                //listViewItem = new ListViewItem("Add Forum Thread");
                //listViewItem.SubItems.Add("Unexpected Error: " + ex.ToString());
                //lvEvents.Items.Add(listViewItem);

                WriteLogFile("Add Forum Thread - " + "Unexpected Error: " + ex.ToString());
            }

            Cursor.Current = Cursors.Default;
        }

        private async void cmdAssignParentPage_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                foreach (DataGridViewRow row in dgForumThread.Rows)
                {
                    bool rowSelected = (bool)row.Cells["Select"].Value;
                    if (rowSelected)
                    {
                        string subForumID = row.Cells["SFID"].Value.ToString();
                        string topic = GetSubForumTopic(subForumID);

                        string pageId = await Helper.SearchForumPage("admin", "abc$123~~", txtSpace.Text.Trim(),
                                                       txtServer.Text.Trim(), txtForumThreadApiUrl.Text.Trim(), topic.Trim());

                        row.Cells["ParentPageID"].Value = pageId;
                    }
                }
            }
            catch (Exception ex)
            {
                ListViewItem listViewItem = new ListViewItem("Unexpected Error");
                listViewItem.SubItems.Add(ex.ToString());
                lvEvents.Items.Add(listViewItem);
            }

            Cursor.Current = Cursors.Default;
        }

        private void WriteLogFile(string message)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Logs\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Logs\\");
            }

            StreamWriter file = new StreamWriter(Application.StartupPath + "\\Logs\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);

            file.WriteLine(message);
            file.Close();
        }


        //foreach (DataGridViewRow row in dgForumThread.Rows)
        //{
        //    bool rowSelected = (bool)row.Cells["Select"].Value;
        //    string parentPageId = row.Cells["ParentPageId"].Value.ToString();

        //    //int intParentPageId = 0;
        //    //bool valid = Int32.TryParse(parentPageId, out intParentPageId);

        //    if (rowSelected)
        //    {
        //        string subject = row.Cells["Subject"].Value.ToString();
        //        string message = row.Cells["Message"].Value.ToString();

        //        string htmlMessage = Helper.ReplaceTags(message);
        //        htmlMessage = Helper.CleanUnnessaryTags(htmlMessage);

        //        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        //        doc.LoadHtml(htmlMessage);

        //        string errorMessage = string.Empty;

        //        if (!Directory.Exists(Application.StartupPath + "\\Logs\\"))
        //        {
        //            Directory.CreateDirectory(Application.StartupPath + "\\Logs\\");
        //        }

        //        StreamWriter file = new StreamWriter(Application.StartupPath + "\\Logs\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);

        //        //Invalid HTML
        //        string fid = row.Cells["SFID"].Value.ToString();
        //        errorMessage = "Invalid HTML for Subject \"" + subject + "\"" + ", FID: " + fid;


        //        string errDetails = string.Empty;

        //        foreach (HtmlParseError err in doc.ParseErrors)
        //        {
        //            if (!string.IsNullOrWhiteSpace(errDetails))
        //            {
        //                errDetails += ", " + err.Reason;
        //            }
        //            else
        //            {
        //                errDetails = err.Reason;
        //            }

        //            switch (err.Reason)
        //            {
        //                case "Start tag <font> was not found":
        //                    htmlMessage = Helper.ReplaceEndFontTags(htmlMessage);
        //                    break;

        //                default:
        //                    break;
        //            }
        //        }

        //        listViewItem = new ListViewItem(errorMessage);

        //        listViewItem.SubItems.Add(errDetails);
        //        lvEvents.Items.Add(listViewItem);

        //        file.WriteLine(errorMessage + ", " + errDetails);

        //        doc.LoadHtml(htmlMessage);

        //        file.Close();


        //        string userName = row.Cells["Author"].Value.ToString();
        //        string password = string.Empty;

        //        if (string.IsNullOrWhiteSpace(userName))
        //        {
        //            userName = "admin";
        //        }

        //        if (userName.ToLower().Equals("admin"))
        //        {
        //            password = Helper.DefaultAdminPassword;
        //        }
        //        else
        //        {
        //            password = Helper.DefaultUserPassword;
        //        }

        //        bool success = await Task.FromResult(Helper.AddForumThreadAsync(userName.Trim(), password.Trim(), txtSpace.Text.Trim(),
        //             txtServer.Text.Trim(), txtForumThreadApiUrl.Text.Trim(), subject, htmlMessage, parentPageId)).Result;

        //        listViewItem = new ListViewItem("Add Forum Thread");
        //        if (success)
        //        {
        //            listViewItem.SubItems.Add("Added Forum Thread: " + subject);
        //            lvEvents.Items.Insert(0, listViewItem);
        //        }
        //        else
        //        {
        //            listViewItem.SubItems.Add("Failed to add forum thread: " + subject);
        //            lvEvents.Items.Insert(0, listViewItem);
        //        }
        //    }

        //    Thread.Sleep(3000);
        //}

        #endregion

        #region Users

        private void cmdLoadUsers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (CheckConnection())
            {
                MySqlConnection con = new MySqlConnection(txtConnectionString.Text.Trim());
                con.Open();

                string sql = "SELECT pre_forum_post.pid as PID, " +
                "pre_forum_post.fid as FID, " +
                "pre_forum_post.tid as TID, " +
                "pre_forum_post.first as First, " +
                "pre_forum_post.author as Author, " +
                "pre_forum_post.authorid as AuthorID, " +
                "pre_forum_post.subject as Subject, " +
                "from_unixtime(pre_forum_post.dateline,'%Y-%m-%d') as PostDate, " +
                "pre_forum_post.message as Message, " +
                "pre_forum_post.useip as UserIP, " +
                "pre_forum_post.invisible as Invisible, " +
                "pre_forum_post.anonymous as Anonymous, " +
                "pre_forum_post.usesig as UseSig, " +
                "pre_forum_post.htmlon as HTMLOn, " +
                "pre_forum_post.bbcodeoff as BBCodeOff, " +
                "pre_forum_post.smileyoff as SmileyOff, " +
                "pre_forum_post.parseurloff as ParseUrlOff, " +
                "pre_forum_post.attachment as Attachment, " +
                "pre_forum_post.rate as Rate, " +
                "pre_forum_post.ratetimes as RateTimes, " +
                "pre_forum_post.status as Status, " +
                "pre_forum_post.tags as Tags, " +
                "pre_forum_post.comment as Comment, " +
                "pre_forum_post.replycredit as ReplyCredit " +
                "FROM cmsforum.pre_forum_post";

                string whereClause = string.Empty;

                int intPID, intFID, intTID;
                bool success = false;

                if (!string.IsNullOrWhiteSpace(txtForumThreadID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadID.Text.Trim(), out intPID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid PID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadFID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadFID.Text.Trim(), out intFID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid FID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadSFID.Text.Trim()))
                {
                    success = int.TryParse(txtForumThreadSFID.Text.Trim(), out intTID);

                    if (!success)
                    {
                        MessageBox.Show("Please enter valid TID");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadID.Text.Trim()))
                {
                    whereClause = " WHERE pre_forum_post.pid = " + txtForumThreadID.Text.Trim();
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadFID.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(whereClause))
                    {
                        whereClause = " WHERE pre_forum_post.fid = " + txtForumThreadFID.Text.Trim();
                    }
                    else
                    {
                        whereClause = whereClause + " AND pre_forum_post.fid = " + txtForumThreadFID.Text.Trim();
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtForumThreadSFID.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(whereClause))
                    {
                        whereClause = " WHERE pre_forum_post.tid = " + txtForumThreadSFID.Text.Trim();
                    }
                    else
                    {
                        whereClause = whereClause + " AND pre_forum_post.tid = " + txtForumThreadSFID.Text.Trim();
                    }
                }

                if (!string.IsNullOrWhiteSpace(whereClause))
                {
                    sql = sql + whereClause;
                }

                string orderByClause = string.Empty;

                if (cmbForumPostOrderBy.SelectedIndex > -1)
                {
                    switch (cmbForumPostOrderBy.SelectedIndex)
                    {
                        case 0:
                            orderByClause = " ORDER BY pre_forum_post.pid";
                            break;

                        case 1:
                            orderByClause = " ORDER BY pre_forum_post.fid";
                            break;

                        case 2:
                            orderByClause = " ORDER BY pre_forum_post.tid";
                            break;

                        case 3:
                            orderByClause = " ORDER BY PostDate";
                            break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(orderByClause))
                {
                    sql = sql + orderByClause;
                }

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<ForumThread> forumPosts = new List<ForumThread>();

                    while (rdr.Read())
                    {
                        bool selected = false;
                        int pid = rdr.GetInt32(0);
                        int fid = rdr.GetInt32(1);
                        int tid = rdr.GetInt32(2);
                        int first = rdr.GetInt32(3);
                        string author = rdr.GetString(4);
                        int authorId = rdr.GetInt32(5);
                        string subject = rdr.GetString(6);
                        string dateLine = rdr.GetString(7);
                        string message = rdr.GetString(8);
                        string useIP = rdr.GetString(9);
                        int invisible = rdr.GetInt32(10);
                        int anonymous = rdr.GetInt32(11);
                        int useSig = rdr.GetInt32(12);
                        int htmlOn = rdr.GetInt32(13);
                        int bbcodeoff = rdr.GetInt32(14);
                        int smileyOff = rdr.GetInt32(15);
                        int parseUrlOff = rdr.GetInt32(16);
                        int attachment = rdr.GetInt32(17);
                        int rate = rdr.GetInt32(18);
                        int rateTimes = rdr.GetInt32(19);
                        int status = rdr.GetInt32(20);
                        string tags = rdr.GetString(21);
                        int comment = rdr.GetInt32(22);
                        int replyCredit = rdr.GetInt32(23);


                        ForumThread forumPost = new ForumThread
                        {
                            Select = selected,
                            TID = pid,
                            FID = fid,
                            SFID = tid,
                            First = first,
                            Author = author,
                            AuthorID = authorId,
                            Subject = subject,
                            DateLine = dateLine,
                            Message = message,
                            UseIP = useIP,
                            Invisible = invisible,
                            Anonymous = anonymous,
                            UseSig = useSig,
                            HtmlOn = htmlOn,
                            BBCodeOff = bbcodeoff,
                            SmileyOff = smileyOff,
                            ParseUrlOff = parseUrlOff,
                            Attachment = attachment,
                            Rate = rate,
                            RateTimes = rateTimes,
                            Status = status,
                            Tags = tags,
                            Comment = comment,
                            ReplyCredit = replyCredit,
                            ParentPageID = 0
                        };

                        forumPosts.Add(forumPost);
                    }

                    rdr.Close();

                    dgForumThread.DataSource = null;
                    dgForumThread.Rows.Clear();
                    dgForumThread.Refresh();

                    dgForumThread.DataSource = forumPosts;
                    txtForumPostNoOfRows.Text = forumPosts.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading forum threads " + ex.ToString());
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void cmdSelectAllUsers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForumThread.Rows)
            {
                dr.Cells["Select"].Value = true;
            }

            dgForumThread.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void cmdClearAllUsers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow dr in dgForumThread.Rows)
            {
                dr.Cells["Select"].Value = false;
            }

            dgForumThread.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private async void cmdGetUsers_Click(object sender, EventArgs e)
        {
            string userKey = await Helper.GetUser(Helper.DefaultAdmin, Helper.DefaultAdminPassword, txtSpace.Text.Trim(),
                                                      txtServer.Text.Trim(), txtApiUserUrl.Text.Trim(), txtUserName.Text.Trim());
        }

        #endregion

    }
}
