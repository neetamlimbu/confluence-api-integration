using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ForumDataMigration
{
    public static class Helper
    {

        public static string DefaultAdmin
        {
            get { return "admin"; }
        }

        public static string DefaultAdminPassword
        {
            get { return "abc$123~~"; }
        }

        public static string DefaultUserPassword
        {
            get { return "123"; }
        }

        //Main Forum
        public static async Task<bool> AddForumPageAsync(
            string userName,
            string password,
            string spaceKey,
            string destinationUrl, //http://localhost:8080/confluence/rest/api/content/
            string apiPath,
            string message)
        {
            bool success = false;
            string result = string.Empty;

            try
            {
                //Call Api

                HttpClient httpClient = new HttpClient();
                string requestBody = $"{{ \"type\":\"page\", " +
                    "\"title\":\"" + message + "\", " +
                    "\"space\":{\"key\":\"" + spaceKey + "\"}, " +
                    "\"body\":{\"storage\":{\"value\":\"<p>" + message + "</p>\",\"representation\":\"storage\"}}}";


                HttpContent httpContent = new StringContent(requestBody);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + btoa(userName + ":" + password)); //Basic YWRtaW46YWJjJDEyM35+

                string requestUri = $"{destinationUrl}/{apiPath}";
                Uri uri = new Uri(requestUri);

                HttpResponseMessage response = await httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return success;
        }

        //Thread related to main forum
        public static async Task<bool> AddForumThreadAsync(
           string userName,
           string password,
           string spaceKey,
           string destinationUrl, //http://localhost:8080/confluence/rest/api/content/
           string apiPath,
           string title,
           string message,
           string parentPageId)
        {
            bool success = false;
            string result = string.Empty;

            try
            {
                //Call Api
                HttpClient httpClient = new HttpClient();

                var messageToJson = JsonConvert.SerializeObject(message);

                string requestBody = $"{{ \"type\":\"comment\", " +
                    "\"container\":{ \"type\":\"page\", \"id\":\"" + parentPageId + "\"}," +
                    "\"space\":{\"key\":\"" + spaceKey + "\"}, " +
                    "\"body\":{\"storage\":{\"value\":" + messageToJson + ",\"representation\":\"storage\"}}}";

                HttpContent httpContent = new StringContent(requestBody);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + btoa(userName + ":" + password)); //Basic YWRtaW46YWJjJDEyM35+

                string requestUri = $"{destinationUrl}/{apiPath}";
                Uri uri = new Uri(requestUri);

                HttpResponseMessage response = await httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    success = true;
                }
                else
                {
                    result = await Task.FromResult("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return success;
        }

        //Posts related to threads
        public static async Task<bool> AddSubForumAsync(
         string userName,
         string password,
         string spaceKey,
         string destinationUrl, //http://localhost:8080/confluence/rest/api/content/
         string apiPath,
         string title,
         string message,
         string parentPageId)
        {
            bool success = false;
            string result = string.Empty;

            try
            {
                //Call Api
                HttpClient httpClient = new HttpClient();
                string requestBody = $"{{ \"type\":\"page\", " +
                    "\"title\":\"" + title + "\", " +
                    "\"ancestors\":[{\"id\":" + parentPageId + "}], " +
                    "\"space\":{\"key\":\"" + spaceKey + "\"}, " +
                    "\"body\":{\"storage\":{\"value\":\"<p>" + message + "</p>\",\"representation\":\"storage\"}}}";

                HttpContent httpContent = new StringContent(requestBody);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + btoa(userName + ":" + password)); //Basic YWRtaW46YWJjJDEyM35+

                string requestUri = $"{destinationUrl}/{apiPath}";
                Uri uri = new Uri(requestUri);

                HttpResponseMessage response = await httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    success = true;
                }
                else
                {
                    result = await Task.FromResult("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return success;
        }

        public static async Task<string> SearchForumPage(
        string userName,
        string password,
        string spaceKey,
        string destinationUrl, //http://localhost:8080/confluence/rest/api/content/
        string apiPath,
        string title)
        {
            string pageId = "0";
            string result = string.Empty;

            try
            {
                //Call Api
                //"&expand=history" => For History

                HttpClient httpClient = new HttpClient();
                string searchParams = "?title=" + title + "&spaceKey=" + spaceKey;

                HttpContent httpContent = new StringContent(string.Empty);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + btoa(userName + ":" + password)); //Basic YWRtaW46YWJjJDEyM35+

                string requestUri = $"{destinationUrl}/{apiPath}" + searchParams;
                Uri uri = new Uri(requestUri);

                HttpResponseMessage response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();

                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(result);

                    var jsonDataResults = jsonData.results;

                    if (jsonDataResults.Count > 0)
                    {
                        pageId = jsonData.results[0].id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return pageId;
        }


        public static async Task<string> GetUser(
      string adminUserName,
      string password,
      string spaceKey,
      string destinationUrl, //http://localhost:8080/confluence/rest/api/content/
      string apiPath,
      string confluenceUserName)
        {
            string userKey = string.Empty;
            string result = string.Empty;

            try
            {
                //Call Api
                //"&expand=history" => For History

                HttpClient httpClient = new HttpClient();
                string searchParams = "?username=" + confluenceUserName;

                HttpContent httpContent = new StringContent(string.Empty);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + btoa(adminUserName + ":" + password)); //Basic YWRtaW46YWJjJDEyM35+

                string requestUri = $"{destinationUrl}/{apiPath}" + searchParams;
                Uri uri = new Uri(requestUri);

                HttpResponseMessage response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();

                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(result);

                    string jsonDataResults = jsonData.userKey;

                    if (!string.IsNullOrWhiteSpace(jsonDataResults))
                    {
                        userKey = jsonDataResults;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return userKey;
        }

        #region Encode, Clean and Replace

        private static string btoa(string toEncode)
        {
            byte[] bytes = Encoding.GetEncoding(28591).GetBytes(toEncode);
            string toReturn = System.Convert.ToBase64String(bytes);
            return toReturn;
        }

        private static string FontSize13 = "[size=13px]";
        private static string Bold = "[b]";
        private static string Underlined = "[u]";
        private static string AlignLeft = "[align=left]";
        private static string UnorderedList = "[list=1]";
        private static string ListItem = "[*]";
        //private static string QuotationMarks = "&quot";
        private static string EndFontSize13 = "[/size]";
        private static string EndBold = "[/b]";
        private static string EndUnderlined = "[/u]";
        private static string EndAlignLeft = "[/align]";
        private static string EndList = "[/list]";
        private static string ImageTag = "[img]";
        private static string EndImageTag = "[/img]<br>";

        private static string ReplaceFontSize13 = "<font size=\"13px\">";
        private static string ReplaceBold = "<b>";
        private static string ReplaceUnderlined = "<u>";
        private static string ReplaceAlignLeft = "<div align=\"left\">";
        private static string ReplaceUnorderedList = "<ul>";
        private static string ReplaceListItem = "<li>";
        //private static string ReplaceQuotationMarks = "<q>";
        private static string ReplaceEndFontSize13 = "</font>";
        private static string ReplaceEndBold = "</b>";
        private static string ReplaceEndUnderlined = "</u>";
        private static string ReplaceEndAlignLeft = "</div>";
        private static string ReplaceEndList = "</ul>";
        //private static string ReplaceImage = "<img src = \"";
        //private static string ReplaceEndImage = "</img>";

        public static string ReplaceTags(string text)
        {
            try
            {
                text = text.Replace(FontSize13, ReplaceFontSize13);
                text = text.Replace(Bold, ReplaceBold);
                text = text.Replace(Underlined, ReplaceUnderlined);
                text = text.Replace(AlignLeft, ReplaceAlignLeft);
                text = text.Replace(UnorderedList, ReplaceUnorderedList);
                text = text.Replace(ListItem, ReplaceListItem);
                text = text.Replace(EndFontSize13, ReplaceEndFontSize13);
                text = text.Replace(EndBold, ReplaceEndBold);
                text = text.Replace(EndUnderlined, ReplaceEndUnderlined);
                text = text.Replace(EndAlignLeft, ReplaceEndAlignLeft);
                text = text.Replace(EndList, ReplaceEndList);

                //Image tags
                text = ReplaceImageTags(text, ImageTag, EndImageTag);
            }
            catch (Exception ex)
            {
                WriteLogFile(ex.ToString());
            }

            return text;
        }

        private static List<int> AllIndexesOf(string text, string value)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = text.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }

        private static string ReplaceImageTags(string text, string start, string end)
        {
            try
            {
                int indexStart = text.IndexOf(start);

                if (indexStart == -1)
                    return text;

                int indexEnd = 0;
                bool exit = false;

                while (!exit)
                {
                    if (indexStart != -1)
                    {
                        indexEnd = text.IndexOf(end);

                        if (indexEnd != -1)
                        {
                            //Insert attributes
                            text = text.Insert(indexStart + 5, "src=\"");
                            text = text.Insert(indexEnd + 5, "\">");
                            text = text.Replace("[img]src=\"http://informatics.home", "<img src=\"http://informatics.home");
                            text = text.Replace(">[/img]", "</img>");
                        }
                        else
                        {
                            exit = true;
                        }
                    }
                    else
                    {
                        exit = true;
                    }

                    indexStart = text.IndexOf(start);
                }
            }
            catch(Exception ex)
            {
                WriteLogFile(ex.ToString());
            }
           
            return text;
        }

        public static string CleanUnnessaryTags(string text)
        {
            Regex regex = new Regex("\\[.*?\\]");
            text = regex.Replace(text, "");

            return text;
        }


        public static string ReplaceEndFontTags(string text)
        {
            text = text.Replace("</font>", string.Empty);
            return text;
        }

        #endregion

        #region Add Closing Tags 

        //public static string AddClosingTagToListElements(string text)
        //{
        //    var pattern = @"<ul>\s*(.+?)\s*</ul>";
        //    text = text.Replace(System.Environment.NewLine, "");

        //    string formattedText = FindMatches(text, pattern);
        //    Regex regex = new Regex(pattern);
        //    text = regex.Replace(text, formattedText);
        //    return text;
        //}

        //private static string FindMatches(string text, string pattern)
        //{
        //    MatchCollection matches = Regex.Matches(text, pattern);

        //    string convertedText = string.Empty;
        //    foreach (Match match in matches)
        //    {
        //        convertedText = convertedText + AddCloseListTagToLi(match.ToString());
        //    }

        //    return convertedText;
        //}

        //private static string AddCloseListTagToLi(string text)
        //{
        //    string[] tokens = text.Split(new[] { "<li>" }, StringSplitOptions.None);

        //    string tagAddedText = string.Empty;
        //    foreach (string token in tokens)
        //    {
        //        if (!string.IsNullOrWhiteSpace(token))
        //        {
        //            if (token.Equals("<ul>"))
        //            {
        //                tagAddedText = token;
        //            }
        //            else if (token.Contains("</ul>"))
        //            {
        //                string replacedToken = token.Replace("</ul>", "");
        //                replacedToken = replacedToken + ("<li>" + replacedToken.Insert(replacedToken.Length, "</li>"));
        //                tagAddedText = tagAddedText + replacedToken.Insert(replacedToken.Length, "</ul>");
        //            }
        //            else
        //            {
        //                tagAddedText = tagAddedText + ("<li>" + token.Insert(token.Length, "</li>"));
        //            }
        //        }
        //    }

        //    return tagAddedText;
        //}

        #endregion


        private static void WriteLogFile(string message)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Logs\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Logs\\");
            }

            StreamWriter file = new StreamWriter(Application.StartupPath + "\\Logs\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);

            file.WriteLine(message);
            file.Close();
        }

    }
}
